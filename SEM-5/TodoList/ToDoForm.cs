using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ToDoForm : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\TodoList\\TodoDB.mdf;Integrated Security=True";
        private int _taskId; // 0 for new task, > 0 for existing task

        public ToDoForm(int taskId)
        {
            InitializeComponent();
            _taskId = taskId;
        }

        private void ToDoForm_Load(object sender, EventArgs e)
        {
            if (_taskId > 0)
            {
                // EDIT MODE: Load the task data FIRST.
                this.Text = "Edit Task";
                titleLabel.Text = "Edit Task";
                createTaskButton.Text = "Save Changes";
                LoadTaskData();
            }

            // Set the minimum date AFTER loading data.
            // This prevents the error when loading tasks with past due dates.
            dueDatePicker.MinDate = DateTime.Now;
        }

        private void LoadTaskData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Title, Description, DueDate FROM Todos WHERE Id = @TaskId AND UserId = @UserId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TaskId", _taskId);
                    cmd.Parameters.AddWithValue("@UserId", Session.UserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            taskTitleTextBox.Text = reader["Title"].ToString();
                            descriptionTextBox.Text = reader["Description"].ToString();
                            if (reader["DueDate"] != DBNull.Value)
                            {
                                // This is now safe because MinDate has not been set yet.
                                dueDatePicker.Value = Convert.ToDateTime(reader["DueDate"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading task data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(taskTitleTextBox.Text))
            {
                MessageBox.Show("Task title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                taskTitleTextBox.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query;
                    if (_taskId == 0) // Insert new task
                    {
                        query = "INSERT INTO Todos (UserId, Title, Description, DueDate, IsCompleted) VALUES (@UserId, @Title, @Description, @DueDate, 0)";
                    }
                    else // Update existing task
                    {
                        query = "UPDATE Todos SET Title = @Title, Description = @Description, DueDate = @DueDate WHERE Id = @TaskId AND UserId = @UserId";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Title", taskTitleTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Description", descriptionTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@DueDate", dueDatePicker.Value);
                    cmd.Parameters.AddWithValue("@UserId", Session.UserId);

                    if (_taskId > 0)
                    {
                        cmd.Parameters.AddWithValue("@TaskId", _taskId);
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(_taskId == 0 ? "Task created successfully!" : "Task updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving task: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
