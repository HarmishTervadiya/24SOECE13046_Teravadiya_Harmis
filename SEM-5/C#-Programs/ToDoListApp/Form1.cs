using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        TextBox txtTask;
        Button btnAdd, btnDelete, btnLoad;
        ListBox lstTasks;

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToDoDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "ToDo List with SQL DB";
            this.Width = 400;
            this.Height = 500;

            txtTask = new TextBox { Top = 20, Left = 20, Width = 240 };
            btnAdd = new Button { Top = 20, Left = 270, Text = "Add Task" };
            btnAdd.Click += BtnAdd_Click;

            lstTasks = new ListBox { Top = 60, Left = 20, Width = 340, Height = 300 };

            btnDelete = new Button { Top = 370, Left = 20, Text = "Delete Selected", Width = 150 };
            btnDelete.Click += BtnDelete_Click;

            btnLoad = new Button { Top = 370, Left = 210, Text = "Reload Tasks", Width = 150 };
            btnLoad.Click += BtnLoad_Click;

            Controls.Add(txtTask);
            Controls.Add(btnAdd);
            Controls.Add(lstTasks);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void LoadTasks()
        {
            lstTasks.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Description FROM Tasks", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstTasks.Items.Add($"{reader["Id"]}: {reader["Description"]}");
                }

                reader.Close();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string task = txtTask.Text.Trim();
            if (string.IsNullOrEmpty(task))
            {
                MessageBox.Show("Enter a task!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Tasks (Description) VALUES (@desc)", conn);
                cmd.Parameters.AddWithValue("@desc", task);
                cmd.ExecuteNonQuery();
            }

            txtTask.Clear();
            LoadTasks();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem == null)
            {
                MessageBox.Show("Select a task to delete.");
                return;
            }

            string selected = lstTasks.SelectedItem.ToString();
            int taskId = int.Parse(selected.Split(':')[0]);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Tasks WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", taskId);
                cmd.ExecuteNonQuery();
            }

            LoadTasks();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }

        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.Run(new Form1());
        //}
    }
}
