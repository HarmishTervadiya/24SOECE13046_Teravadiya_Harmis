namespace ToDoList
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel logoPanel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label createAccountLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label nameLabel;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2CheckBox termsCheckBox;
        private Guna.UI2.WinForms.Guna2Button signUpButton;
        private System.Windows.Forms.Panel signInLinkPanel;
        private System.Windows.Forms.Label haveAccountLabel;
        private System.Windows.Forms.LinkLabel signInLink;

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
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.termsCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.signUpButton = new Guna.UI2.WinForms.Guna2Button();
            this.signInLinkPanel = new System.Windows.Forms.Panel();
            this.haveAccountLabel = new System.Windows.Forms.Label();
            this.signInLink = new System.Windows.Forms.LinkLabel();
            this.logoPanel.SuspendLayout();
            this.signInLinkPanel.SuspendLayout();
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
            // createAccountLabel
            // 
            this.createAccountLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.createAccountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.createAccountLabel.Location = new System.Drawing.Point(67, 148);
            this.createAccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(400, 39);
            this.createAccountLabel.TabIndex = 1;
            this.createAccountLabel.Text = "Create Account";
            this.createAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.subtitleLabel.Text = "Sign up to get started";
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.nameLabel.Location = new System.Drawing.Point(63, 246);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(80, 20);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Full Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.nameTextBox.BorderRadius = 6;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.nameTextBox.Location = new System.Drawing.Point(67, 272);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderText = "Enter your full name";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(400, 49);
            this.nameTextBox.TabIndex = 4;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.usernameLabel.Location = new System.Drawing.Point(63, 342);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(80, 20);
            this.usernameLabel.TabIndex = 5;
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
            this.usernameTextBox.Location = new System.Drawing.Point(67, 368);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Enter your username";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.Size = new System.Drawing.Size(400, 49);
            this.usernameTextBox.TabIndex = 6;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.passwordLabel.Location = new System.Drawing.Point(63, 438);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 20);
            this.passwordLabel.TabIndex = 7;
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
            this.passwordTextBox.Location = new System.Drawing.Point(67, 464);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.PlaceholderText = "Enter your password";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(400, 49);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // termsCheckBox
            // 
            this.termsCheckBox.AutoSize = true;
            this.termsCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.termsCheckBox.CheckedState.BorderRadius = 2;
            this.termsCheckBox.CheckedState.BorderThickness = 0;
            this.termsCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.termsCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.termsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.termsCheckBox.Location = new System.Drawing.Point(67, 538);
            this.termsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.termsCheckBox.Name = "termsCheckBox";
            this.termsCheckBox.Size = new System.Drawing.Size(267, 24);
            this.termsCheckBox.TabIndex = 9;
            this.termsCheckBox.Text = "I agree to the Terms and Conditions";
            this.termsCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.termsCheckBox.UncheckedState.BorderRadius = 0;
            this.termsCheckBox.UncheckedState.BorderThickness = 1;
            this.termsCheckBox.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // signUpButton
            // 
            this.signUpButton.BorderRadius = 6;
            this.signUpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signUpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signUpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signUpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signUpButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.signUpButton.Location = new System.Drawing.Point(67, 585);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(400, 55);
            this.signUpButton.TabIndex = 10;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // signInLinkPanel
            // 
            this.signInLinkPanel.Controls.Add(this.haveAccountLabel);
            this.signInLinkPanel.Controls.Add(this.signInLink);
            this.signInLinkPanel.Location = new System.Drawing.Point(67, 665);
            this.signInLinkPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signInLinkPanel.Name = "signInLinkPanel";
            this.signInLinkPanel.Size = new System.Drawing.Size(400, 25);
            this.signInLinkPanel.TabIndex = 11;
            // 
            // haveAccountLabel
            // 
            this.haveAccountLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.haveAccountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.haveAccountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.haveAccountLabel.Location = new System.Drawing.Point(63, 0);
            this.haveAccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.haveAccountLabel.Name = "haveAccountLabel";
            this.haveAccountLabel.Size = new System.Drawing.Size(220, 25);
            this.haveAccountLabel.TabIndex = 0;
            this.haveAccountLabel.Text = "Already have an account?";
            this.haveAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // signInLink
            // 
            this.signInLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.signInLink.AutoSize = true;
            this.signInLink.Dock = System.Windows.Forms.DockStyle.Left;
            this.signInLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.signInLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.signInLink.Location = new System.Drawing.Point(0, 0);
            this.signInLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signInLink.Name = "signInLink";
            this.signInLink.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.signInLink.Size = new System.Drawing.Size(63, 20);
            this.signInLink.TabIndex = 1;
            this.signInLink.TabStop = true;
            this.signInLink.Text = "Sign in";
            this.signInLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.signInLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signInLink_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(533, 738);
            this.Controls.Add(this.signInLinkPanel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.termsCheckBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.createAccountLabel);
            this.Controls.Add(this.logoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskFlow - Register";
            this.logoPanel.ResumeLayout(false);
            this.signInLinkPanel.ResumeLayout(false);
            this.signInLinkPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
