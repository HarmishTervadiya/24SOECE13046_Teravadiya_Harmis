using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class RegisterForm : Form
    {

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\24SOECE13046_Harmis_Teravadiya\\TodoList\\TodoDB.mdf;Integrated Security=True";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text.Trim()))
            {
                MessageBox.Show("Please enter your full name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(usernameTextBox.Text.Trim()))
            {
                MessageBox.Show("Please enter your username.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(passwordTextBox.Text.Trim()))
            {
                MessageBox.Show("Please enter your password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTextBox.Focus();
                return;
            }

            if (!termsCheckBox.Checked)
            {
                MessageBox.Show("Please accept the Terms and Conditions to continue.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


              SqlConnection conn = new SqlConnection(connectionString);
            
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Users (Name, Username, Password) VALUES (@Name, @Username, @Password)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", nameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text.Trim());

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Registration successful! You can now log in.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Go to Login Form
                        var loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        


        private void signInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void haveAccountLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
