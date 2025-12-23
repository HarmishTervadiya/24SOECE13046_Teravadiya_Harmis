namespace ToDoList
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Label userIcon;
        private System.Windows.Forms.Label userLabel;
        private Guna.UI2.WinForms.Guna2Button logoutButton;
        private Guna.UI2.WinForms.Guna2Panel contentPanel;
        private System.Windows.Forms.Label myTasksLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private Guna.UI2.WinForms.Guna2Button addTaskButton;
        private Guna.UI2.WinForms.Guna2Panel statsPanel;
        private Guna.UI2.WinForms.Guna2Panel totalTasksPanel;
        private System.Windows.Forms.Label totalIcon;
        private System.Windows.Forms.Label totalCount;
        private System.Windows.Forms.Label totalLabel;
        private Guna.UI2.WinForms.Guna2Panel progressPanel;
        private System.Windows.Forms.Label progressIcon;
        private System.Windows.Forms.Label progressCount;
        private System.Windows.Forms.Label progressLabel;
        private Guna.UI2.WinForms.Guna2Panel completedPanel;
        private System.Windows.Forms.Label completedIcon;
        private System.Windows.Forms.Label completedCount;
        private System.Windows.Forms.Label completedLabel;
        private Guna.UI2.WinForms.Guna2Panel filterPanel;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox allTasksCombo;
        private System.Windows.Forms.ListView tasksListView;
        private Guna.UI2.WinForms.Guna2Button refreshButton;

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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "Review Project Proposal",
            "Read through the new proposal from the design team.",
            "23/08/2025",
            "Completed",
            ""}, -1, System.Drawing.Color.Gray, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Strikeout));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "Prepare for Team Meeting",
            "Gather all necessary documents and talking points.",
            "25/08/2025",
            "Pending",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "Submit Weekly Report",
            "Finalize and submit the Q3 weekly progress report.",
            "28/08/2025",
            "Pending",
            ""}, -1);
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.logoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.userIcon = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.contentPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.myTasksLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.addTaskButton = new Guna.UI2.WinForms.Guna2Button();
            this.statsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.totalTasksPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.totalIcon = new System.Windows.Forms.Label();
            this.totalCount = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.progressPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.progressIcon = new System.Windows.Forms.Label();
            this.progressCount = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.completedPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.completedIcon = new System.Windows.Forms.Label();
            this.completedCount = new System.Windows.Forms.Label();
            this.completedLabel = new System.Windows.Forms.Label();
            this.filterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.allTasksCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tasksListView = new System.Windows.Forms.ListView();
            this.refreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.headerPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.totalTasksPanel.SuspendLayout();
            this.progressPanel.SuspendLayout();
            this.completedPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.headerPanel.BorderThickness = 1;
            this.headerPanel.Controls.Add(this.logoutButton);
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.userPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1600, 86);
            this.headerPanel.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.logoutButton.BorderRadius = 6;
            this.logoutButton.BorderThickness = 1;
            this.logoutButton.FillColor = System.Drawing.Color.Transparent;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.logoutButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.logoutButton.HoverState.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(1496, 25);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(67, 37);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "➦";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.titleLabel.Location = new System.Drawing.Point(33, 23);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(134, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "TaskFlow";
            // 
            // userPanel
            // 
            this.userPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userPanel.Controls.Add(this.userIcon);
            this.userPanel.Controls.Add(this.userLabel);
            this.userPanel.Location = new System.Drawing.Point(1253, 18);
            this.userPanel.Margin = new System.Windows.Forms.Padding(4);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(240, 49);
            this.userPanel.TabIndex = 1;
            // 
            // userIcon
            // 
            this.userIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.userIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.userIcon.Location = new System.Drawing.Point(13, 6);
            this.userIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(40, 37);
            this.userIcon.TabIndex = 0;
            this.userIcon.Text = "👤";
            this.userIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.userLabel.Location = new System.Drawing.Point(60, 12);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(96, 25);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "John Doe";
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.contentPanel.Controls.Add(this.myTasksLabel);
            this.contentPanel.Controls.Add(this.subtitleLabel);
            this.contentPanel.Controls.Add(this.addTaskButton);
            this.contentPanel.Controls.Add(this.statsPanel);
            this.contentPanel.Controls.Add(this.filterPanel);
            this.contentPanel.Controls.Add(this.tasksListView);
            this.contentPanel.Controls.Add(this.refreshButton);
            this.contentPanel.Location = new System.Drawing.Point(0, 86);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(40, 25, 40, 25);
            this.contentPanel.Size = new System.Drawing.Size(1600, 837);
            this.contentPanel.TabIndex = 1;
            // 
            // myTasksLabel
            // 
            this.myTasksLabel.AutoSize = true;
            this.myTasksLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.myTasksLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.myTasksLabel.Location = new System.Drawing.Point(40, 25);
            this.myTasksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myTasksLabel.Name = "myTasksLabel";
            this.myTasksLabel.Size = new System.Drawing.Size(179, 50);
            this.myTasksLabel.TabIndex = 0;
            this.myTasksLabel.Text = "My Tasks";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.subtitleLabel.Location = new System.Drawing.Point(43, 80);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(384, 25);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "Manage your daily tasks and stay organized.";
            // 
            // addTaskButton
            // 
            this.addTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTaskButton.BorderRadius = 6;
            this.addTaskButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.addTaskButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.addTaskButton.ForeColor = System.Drawing.Color.White;
            this.addTaskButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.addTaskButton.Location = new System.Drawing.Point(1363, 37);
            this.addTaskButton.Margin = new System.Windows.Forms.Padding(4);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(187, 55);
            this.addTaskButton.TabIndex = 2;
            this.addTaskButton.Text = "+ Add Task";
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // statsPanel
            // 
            this.statsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statsPanel.BorderRadius = 8;
            this.statsPanel.Controls.Add(this.totalTasksPanel);
            this.statsPanel.Controls.Add(this.progressPanel);
            this.statsPanel.Controls.Add(this.completedPanel);
            this.statsPanel.FillColor = System.Drawing.Color.White;
            this.statsPanel.Location = new System.Drawing.Point(40, 123);
            this.statsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.statsPanel.Size = new System.Drawing.Size(1520, 123);
            this.statsPanel.TabIndex = 3;
            // 
            // totalTasksPanel
            // 
            this.totalTasksPanel.BackColor = System.Drawing.Color.Transparent;
            this.totalTasksPanel.Controls.Add(this.totalIcon);
            this.totalTasksPanel.Controls.Add(this.totalCount);
            this.totalTasksPanel.Controls.Add(this.totalLabel);
            this.totalTasksPanel.Location = new System.Drawing.Point(40, 25);
            this.totalTasksPanel.Margin = new System.Windows.Forms.Padding(4);
            this.totalTasksPanel.Name = "totalTasksPanel";
            this.totalTasksPanel.Size = new System.Drawing.Size(267, 74);
            this.totalTasksPanel.TabIndex = 0;
            // 
            // totalIcon
            // 
            this.totalIcon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.totalIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.totalIcon.Location = new System.Drawing.Point(0, 12);
            this.totalIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalIcon.Name = "totalIcon";
            this.totalIcon.Size = new System.Drawing.Size(53, 49);
            this.totalIcon.TabIndex = 0;
            this.totalIcon.Text = "📋";
            this.totalIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCount
            // 
            this.totalCount.AutoSize = true;
            this.totalCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.totalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.totalCount.Location = new System.Drawing.Point(60, 0);
            this.totalCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(46, 54);
            this.totalCount.TabIndex = 1;
            this.totalCount.Text = "0";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.totalLabel.Location = new System.Drawing.Point(67, 49);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 25);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total Tasks";
            // 
            // progressPanel
            // 
            this.progressPanel.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel.Controls.Add(this.progressIcon);
            this.progressPanel.Controls.Add(this.progressCount);
            this.progressPanel.Controls.Add(this.progressLabel);
            this.progressPanel.Location = new System.Drawing.Point(373, 25);
            this.progressPanel.Margin = new System.Windows.Forms.Padding(4);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(267, 74);
            this.progressPanel.TabIndex = 1;
            // 
            // progressIcon
            // 
            this.progressIcon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.progressIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.progressIcon.Location = new System.Drawing.Point(0, 12);
            this.progressIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.progressIcon.Name = "progressIcon";
            this.progressIcon.Size = new System.Drawing.Size(53, 49);
            this.progressIcon.TabIndex = 0;
            this.progressIcon.Text = "⏳";
            this.progressIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressCount
            // 
            this.progressCount.AutoSize = true;
            this.progressCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.progressCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.progressCount.Location = new System.Drawing.Point(60, 0);
            this.progressCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.progressCount.Name = "progressCount";
            this.progressCount.Size = new System.Drawing.Size(46, 54);
            this.progressCount.TabIndex = 1;
            this.progressCount.Text = "0";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.progressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.progressLabel.Location = new System.Drawing.Point(67, 49);
            this.progressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(106, 25);
            this.progressLabel.TabIndex = 2;
            this.progressLabel.Text = "In Progress";
            // 
            // completedPanel
            // 
            this.completedPanel.BackColor = System.Drawing.Color.Transparent;
            this.completedPanel.Controls.Add(this.completedIcon);
            this.completedPanel.Controls.Add(this.completedCount);
            this.completedPanel.Controls.Add(this.completedLabel);
            this.completedPanel.Location = new System.Drawing.Point(707, 25);
            this.completedPanel.Margin = new System.Windows.Forms.Padding(4);
            this.completedPanel.Name = "completedPanel";
            this.completedPanel.Size = new System.Drawing.Size(267, 74);
            this.completedPanel.TabIndex = 2;
            // 
            // completedIcon
            // 
            this.completedIcon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.completedIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.completedIcon.Location = new System.Drawing.Point(0, 12);
            this.completedIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.completedIcon.Name = "completedIcon";
            this.completedIcon.Size = new System.Drawing.Size(53, 49);
            this.completedIcon.TabIndex = 0;
            this.completedIcon.Text = "✅";
            this.completedIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completedCount
            // 
            this.completedCount.AutoSize = true;
            this.completedCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.completedCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.completedCount.Location = new System.Drawing.Point(60, 0);
            this.completedCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.completedCount.Name = "completedCount";
            this.completedCount.Size = new System.Drawing.Size(46, 54);
            this.completedCount.TabIndex = 1;
            this.completedCount.Text = "0";
            // 
            // completedLabel
            // 
            this.completedLabel.AutoSize = true;
            this.completedLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.completedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.completedLabel.Location = new System.Drawing.Point(67, 49);
            this.completedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.completedLabel.Name = "completedLabel";
            this.completedLabel.Size = new System.Drawing.Size(104, 25);
            this.completedLabel.TabIndex = 2;
            this.completedLabel.Text = "Completed";
            // 
            // filterPanel
            // 
            this.filterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterPanel.BorderRadius = 8;
            this.filterPanel.Controls.Add(this.searchTextBox);
            this.filterPanel.Controls.Add(this.allTasksCombo);
            this.filterPanel.FillColor = System.Drawing.Color.White;
            this.filterPanel.Location = new System.Drawing.Point(40, 265);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Padding = new System.Windows.Forms.Padding(27, 18, 27, 18);
            this.filterPanel.Size = new System.Drawing.Size(1520, 86);
            this.filterPanel.TabIndex = 4;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.Transparent;
            this.searchTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.searchTextBox.BorderRadius = 6;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.searchTextBox.Location = new System.Drawing.Point(27, 18);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "🔍 Search tasks...";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(533, 49);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.FilterChanged);
            // 
            // allTasksCombo
            // 
            this.allTasksCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allTasksCombo.BackColor = System.Drawing.Color.Transparent;
            this.allTasksCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.allTasksCombo.BorderRadius = 6;
            this.allTasksCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.allTasksCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allTasksCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.allTasksCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.allTasksCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.allTasksCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.allTasksCombo.ItemHeight = 34;
            this.allTasksCombo.Items.AddRange(new object[] {
            "All Tasks",
            "Active",
            "Completed"});
            this.allTasksCombo.Location = new System.Drawing.Point(1280, 18);
            this.allTasksCombo.Margin = new System.Windows.Forms.Padding(4);
            this.allTasksCombo.Name = "allTasksCombo";
            this.allTasksCombo.Size = new System.Drawing.Size(212, 40);
            this.allTasksCombo.TabIndex = 1;
            this.allTasksCombo.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
            // 
            // tasksListView
            // 
            this.tasksListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tasksListView.BackColor = System.Drawing.Color.White;
            this.tasksListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tasksListView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tasksListView.FullRowSelect = true;
            this.tasksListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.tasksListView.HideSelection = false;
            this.tasksListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.tasksListView.Location = new System.Drawing.Point(40, 369);
            this.tasksListView.Margin = new System.Windows.Forms.Padding(4);
            this.tasksListView.Name = "tasksListView";
            this.tasksListView.Size = new System.Drawing.Size(1520, 369);
            this.tasksListView.TabIndex = 5;
            this.tasksListView.UseCompatibleStateImageBehavior = false;
            this.tasksListView.View = System.Windows.Forms.View.Details;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.refreshButton.BorderRadius = 6;
            this.refreshButton.BorderThickness = 1;
            this.refreshButton.FillColor = System.Drawing.Color.White;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.refreshButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.refreshButton.Location = new System.Drawing.Point(700, 757);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(200, 55);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Refresh Tasks";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 923);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1359, 875);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskFlow - Task Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.totalTasksPanel.ResumeLayout(false);
            this.totalTasksPanel.PerformLayout();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            this.completedPanel.ResumeLayout(false);
            this.completedPanel.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
