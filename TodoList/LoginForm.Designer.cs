namespace ToDoList
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel logoPanel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2Button signInButton;
        private System.Windows.Forms.Panel signUpLinkPanel;
        private System.Windows.Forms.Label dontHaveAccountLabel;
        private System.Windows.Forms.LinkLabel signUpLink;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.logoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.signInButton = new Guna.UI2.WinForms.Guna2Button();
            this.signUpLinkPanel = new System.Windows.Forms.Panel();
            this.dontHaveAccountLabel = new System.Windows.Forms.Label();
            this.signUpLink = new System.Windows.Forms.LinkLabel();
            this.logoPanel.SuspendLayout();
            this.signUpLinkPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.logoPanel.BorderRadius = 8;
            this.logoPanel.Controls.Add(this.logoLabel);
            this.logoPanel.Location = new System.Drawing.Point(227, 49);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(80, 74);
            this.logoPanel.TabIndex = 0;
            // 
            // logoLabel
            // 
            this.logoLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(0, 0);
            this.logoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(80, 74);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "☰";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.welcomeLabel.Location = new System.Drawing.Point(67, 148);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(400, 39);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome Back";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.subtitleLabel.Location = new System.Drawing.Point(67, 193);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(400, 25);
            this.subtitleLabel.TabIndex = 2;
            this.subtitleLabel.Text = "Sign in to your account to continue";
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.usernameLabel.Location = new System.Drawing.Point(63, 246);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(80, 20);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.usernameTextBox.BorderRadius = 6;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.DefaultText = "";
            this.usernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.usernameTextBox.Location = new System.Drawing.Point(67, 272);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Enter your username";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.Size = new System.Drawing.Size(400, 49);
            this.usernameTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.passwordLabel.Location = new System.Drawing.Point(63, 342);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 20);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.passwordTextBox.BorderRadius = 6;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.passwordTextBox.Location = new System.Drawing.Point(67, 368);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.PlaceholderText = "Enter your password";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(400, 49);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // signInButton
            // 
            this.signInButton.BorderRadius = 6;
            this.signInButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signInButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signInButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signInButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signInButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.signInButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.signInButton.Location = new System.Drawing.Point(67, 486);
            this.signInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(400, 55);
            this.signInButton.TabIndex = 9;
            this.signInButton.Text = "Sign In";
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signUpLinkPanel
            // 
            this.signUpLinkPanel.Controls.Add(this.dontHaveAccountLabel);
            this.signUpLinkPanel.Controls.Add(this.signUpLink);
            this.signUpLinkPanel.Location = new System.Drawing.Point(67, 566);
            this.signUpLinkPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUpLinkPanel.Name = "signUpLinkPanel";
            this.signUpLinkPanel.Size = new System.Drawing.Size(400, 25);
            this.signUpLinkPanel.TabIndex = 10;
            // 
            // dontHaveAccountLabel
            // 
            this.dontHaveAccountLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dontHaveAccountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dontHaveAccountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.dontHaveAccountLabel.Location = new System.Drawing.Point(68, 0);
            this.dontHaveAccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dontHaveAccountLabel.Name = "dontHaveAccountLabel";
            this.dontHaveAccountLabel.Size = new System.Drawing.Size(207, 25);
            this.dontHaveAccountLabel.TabIndex = 0;
            this.dontHaveAccountLabel.Text = "Don\'t have an account?";
            this.dontHaveAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // signUpLink
            // 
            this.signUpLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.signUpLink.AutoSize = true;
            this.signUpLink.Dock = System.Windows.Forms.DockStyle.Left;
            this.signUpLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.signUpLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.signUpLink.Location = new System.Drawing.Point(0, 0);
            this.signUpLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signUpLink.Name = "signUpLink";
            this.signUpLink.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.signUpLink.Size = new System.Drawing.Size(68, 20);
            this.signUpLink.TabIndex = 1;
            this.signUpLink.TabStop = true;
            this.signUpLink.Text = "Sign up";
            this.signUpLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.signUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLink_LinkClicked);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.signInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(533, 640);
            this.Controls.Add(this.signUpLinkPanel);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.logoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskFlow - Login";
            this.logoPanel.ResumeLayout(false);
            this.signUpLinkPanel.ResumeLayout(false);
            this.signUpLinkPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
