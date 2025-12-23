using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class MainForm : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\TodoList\\TodoDB.mdf;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
            userLabel.Text = Session.UserName;
            InitializeListView();
        }

        private void InitializeListView()
        {
            tasksListView.View = View.Details;
            tasksListView.FullRowSelect = true;
            tasksListView.GridLines = false;
            tasksListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            tasksListView.OwnerDraw = true;

            tasksListView.Columns.Add("✓", 40, HorizontalAlignment.Center);
            tasksListView.Columns.Add("Task Title", 250);
            tasksListView.Columns.Add("Description", 300);
            tasksListView.Columns.Add("Due Date", 120, HorizontalAlignment.Center);
            tasksListView.Columns.Add("Status", 100, HorizontalAlignment.Center);
            tasksListView.Columns.Add("Actions", 120, HorizontalAlignment.Center);

            tasksListView.DrawColumnHeader += TasksListView_DrawColumnHeader;
            tasksListView.DrawSubItem += TasksListView_DrawSubItem;
            tasksListView.MouseClick += TasksListView_MouseClick;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            allTasksCombo.SelectedIndex = 0;
            RefreshTasks();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            using (var todoForm = new ToDoForm(0))
            {
                this.Hide();
                if (todoForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshTasks();
                }
                this.Show();
            }
        }

        public void RefreshTasks()
        {
            LoadTasksFromDatabase();
            UpdateTaskStats();
        }

        private void LoadTasksFromDatabase()
        {
            tasksListView.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = BuildFilterQuery();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", Session.UserId);

                    if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTextBox.Text.Trim() + "%");
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new ListViewItem("");
                            bool isCompleted = Convert.ToBoolean(reader["IsCompleted"]);

                            item.SubItems.Add(reader["Title"].ToString());
                            item.SubItems.Add(reader["Description"].ToString());
                            item.SubItems.Add(reader["DueDate"] != DBNull.Value ? Convert.ToDateTime(reader["DueDate"]).ToShortDateString() : "No Date");
                            item.SubItems.Add(isCompleted ? "Completed" : "Pending");
                            item.SubItems.Add("");

                            item.Tag = new { TaskId = Convert.ToInt32(reader["Id"]), Completed = isCompleted };

                            if (isCompleted)
                            {
                                item.ForeColor = Color.Gray;
                                item.Font = new Font(tasksListView.Font, FontStyle.Strikeout);
                            }
                            tasksListView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string BuildFilterQuery()
        {
            string query = "SELECT Id, Title, Description, DueDate, IsCompleted FROM Todos WHERE UserId = @UserId";
            if (allTasksCombo.SelectedItem != null)
            {
                string statusFilter = allTasksCombo.SelectedItem.ToString();
                if (statusFilter == "Active") query += " AND IsCompleted = 0";
                else if (statusFilter == "Completed") query += " AND IsCompleted = 1";
            }
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                query += " AND (Title LIKE @SearchTerm OR Description LIKE @SearchTerm)";
            }
            query += " ORDER BY IsCompleted ASC, DueDate ASC";
            return query;
        }

        private void UpdateTaskStats()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*), SUM(CASE WHEN IsCompleted = 1 THEN 1 ELSE 0 END) FROM Todos WHERE UserId = @UserId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", Session.UserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int total = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            int completed = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                            totalCount.Text = total.ToString();
                            completedCount.Text = completed.ToString();
                            progressCount.Text = (total - completed).ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating stats: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterChanged(object sender, EventArgs e) => LoadTasksFromDatabase();
        private void refreshButton_Click(object sender, EventArgs e) => RefreshTasks();

        private void TasksListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(248, 249, 250)), e.Bounds);
            TextRenderer.DrawText(e.Graphics, e.Header.Text, new Font("Segoe UI", 10, FontStyle.Bold), e.Bounds, Color.FromArgb(73, 80, 87), TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }

        private void TasksListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = false;
            Color backColor = e.Item.Selected ? Color.FromArgb(222, 226, 230) : e.Item.Index % 2 == 0 ? Color.White : Color.FromArgb(248, 249, 250);
            e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);

            if (e.ColumnIndex == 0)
            {
                var tag = e.Item.Tag as dynamic;
                string checkSymbol = tag.Completed ? "✓" : "";
                TextRenderer.DrawText(e.Graphics, checkSymbol, new Font("Segoe UI", 12, FontStyle.Bold), e.Bounds, Color.SeaGreen, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            else if (e.ColumnIndex == 5)
            {
                int iconSize = 20;
                int y = e.Bounds.Top + (e.Bounds.Height - iconSize) / 2; 

                Rectangle editBounds = new Rectangle(e.Bounds.Left + 25, y, iconSize, iconSize);
                Rectangle deleteBounds = new Rectangle(e.Bounds.Left + 75, y, iconSize, iconSize);

                TextRenderer.DrawText(e.Graphics, "✎", new Font("Segoe UI", 12), editBounds, Color.FromArgb(13, 110, 253), TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                TextRenderer.DrawText(e.Graphics, "🗑", new Font("Segoe UI", 12), deleteBounds, Color.FromArgb(220, 53, 69), TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            else
            {
                Color textColor = e.Item.ForeColor == Color.Empty ? Color.FromArgb(33, 37, 41) : e.Item.ForeColor;
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.Item.Font, e.Bounds, textColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
        }

        private void TasksListView_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = tasksListView.GetItemAt(e.X, e.Y);
            if (item == null) return;

            ListViewItem.ListViewSubItem subItem = item.GetSubItemAt(e.X, e.Y);
            if (subItem == null) return;
            int subItemIndex = item.SubItems.IndexOf(subItem);

            var tag = item.Tag as dynamic;
            int taskId = tag.TaskId;

            if (subItemIndex == 0) 
            {
                ToggleTaskCompletion(item);
            }
            else if (subItemIndex == 5) 
            {
                int iconSize = 20;
                int y = item.SubItems[5].Bounds.Top + (item.SubItems[5].Bounds.Height - iconSize) / 2;

                Rectangle editBounds = new Rectangle(item.SubItems[5].Bounds.Left + 25, y, iconSize, iconSize);
                Rectangle deleteBounds = new Rectangle(item.SubItems[5].Bounds.Left + 75, y, iconSize, iconSize);

                if (editBounds.Contains(e.Location))
                {
                    using (var todoForm = new ToDoForm(taskId))
                    {
                        this.Hide();
                        if (todoForm.ShowDialog() == DialogResult.OK)
                        {
                            RefreshTasks();
                        }
                        this.Show();
                    }
                }
                else if (deleteBounds.Contains(e.Location))
                {
                    if (MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        DeleteTask(taskId);
                    }
                }
            }
        }

        private void ToggleTaskCompletion(ListViewItem item)
        {
            var tag = item.Tag as dynamic;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Todos SET IsCompleted = @IsCompleted WHERE Id = @Id AND UserId = @UserId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IsCompleted", !tag.Completed);
                    cmd.Parameters.AddWithValue("@Id", tag.TaskId);
                    cmd.Parameters.AddWithValue("@UserId", Session.UserId);
                    cmd.ExecuteNonQuery();
                    RefreshTasks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating task: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTask(int taskId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Todos WHERE Id = @Id AND UserId = @UserId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", taskId);
                    cmd.Parameters.AddWithValue("@UserId", Session.UserId);
                    cmd.ExecuteNonQuery();
                    RefreshTasks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting task: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["LoginForm"] == null)
            {
                Application.Exit();
            }
        }
    }
}
