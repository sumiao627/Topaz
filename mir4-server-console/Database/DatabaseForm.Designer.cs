﻿namespace Server_Console.Database
{
    partial class DatabaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            AdminTree = new TreeView();
            DatabaseTabs = new TabControl();
            tabAdmin = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            AdminData = new DataGridView();
            tabDevice = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            DeviceTree = new TreeView();
            DeviceData = new DataGridView();
            tabFront = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            FrontTree = new TreeView();
            FrontData = new DataGridView();
            tabGame = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            GameTree = new TreeView();
            GameData = new DataGridView();
            tabUser = new TabPage();
            tableLayoutPanel8 = new TableLayoutPanel();
            UserTree = new TreeView();
            UserData = new DataGridView();
            AccountsBox = new GroupBox();
            btnFilter = new Button();
            EmailLabel = new Label();
            EmailSearch = new TextBox();
            CharIDLabel = new Label();
            CharIDSearch = new TextBox();
            AccountNameLabel = new Label();
            AccountNameSearch = new TextBox();
            CharNameLabel = new Label();
            AccountIDLabel = new Label();
            CharNameSearch = new TextBox();
            AccountIDSearch = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            treeView1 = new TreeView();
            dataGridView1 = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            treeView5 = new TreeView();
            dataGridView5 = new DataGridView();
            tableLayoutPanel7 = new TableLayoutPanel();
            DatabaseTabs.SuspendLayout();
            tabAdmin.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminData).BeginInit();
            tabDevice.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeviceData).BeginInit();
            tabFront.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FrontData).BeginInit();
            tabGame.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GameData).BeginInit();
            tabUser.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserData).BeginInit();
            AccountsBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // AdminTree
            // 
            AdminTree.Dock = DockStyle.Fill;
            AdminTree.FullRowSelect = true;
            AdminTree.Location = new Point(3, 3);
            AdminTree.Name = "AdminTree";
            AdminTree.Size = new Size(186, 630);
            AdminTree.TabIndex = 0;
            AdminTree.NodeMouseClick += AdminTree_NodeMouseClick;
            // 
            // DatabaseTabs
            // 
            DatabaseTabs.Controls.Add(tabAdmin);
            DatabaseTabs.Controls.Add(tabDevice);
            DatabaseTabs.Controls.Add(tabFront);
            DatabaseTabs.Controls.Add(tabGame);
            DatabaseTabs.Controls.Add(tabUser);
            DatabaseTabs.Dock = DockStyle.Fill;
            DatabaseTabs.Location = new Point(137, 3);
            DatabaseTabs.Name = "DatabaseTabs";
            DatabaseTabs.SelectedIndex = 0;
            DatabaseTabs.Size = new Size(1124, 670);
            DatabaseTabs.TabIndex = 2;
            DatabaseTabs.SelectedIndexChanged += DatabaseTabs_SelectedIndexChanged;
            // 
            // tabAdmin
            // 
            tabAdmin.Controls.Add(tableLayoutPanel2);
            tabAdmin.Location = new Point(4, 24);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.Padding = new Padding(3);
            tabAdmin.Size = new Size(1116, 642);
            tabAdmin.TabIndex = 0;
            tabAdmin.Text = "Admin";
            tabAdmin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.3553715F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.64463F));
            tableLayoutPanel2.Controls.Add(AdminTree, 0, 0);
            tableLayoutPanel2.Controls.Add(AdminData, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1110, 636);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // AdminData
            // 
            AdminData.BackgroundColor = SystemColors.Window;
            AdminData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminData.Dock = DockStyle.Fill;
            AdminData.GridColor = Color.Black;
            AdminData.Location = new Point(195, 3);
            AdminData.Name = "AdminData";
            AdminData.Size = new Size(912, 630);
            AdminData.TabIndex = 1;
            // 
            // tabDevice
            // 
            tabDevice.Controls.Add(tableLayoutPanel4);
            tabDevice.Location = new Point(4, 24);
            tabDevice.Name = "tabDevice";
            tabDevice.Padding = new Padding(3);
            tabDevice.Size = new Size(1116, 642);
            tabDevice.TabIndex = 2;
            tabDevice.Text = "Device";
            tabDevice.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.3553715F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.64463F));
            tableLayoutPanel4.Controls.Add(DeviceTree, 0, 0);
            tableLayoutPanel4.Controls.Add(DeviceData, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1110, 636);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // DeviceTree
            // 
            DeviceTree.Dock = DockStyle.Fill;
            DeviceTree.FullRowSelect = true;
            DeviceTree.Location = new Point(3, 3);
            DeviceTree.Name = "DeviceTree";
            DeviceTree.Size = new Size(186, 630);
            DeviceTree.TabIndex = 0;
            DeviceTree.NodeMouseClick += DeviceTree_NodeMouseClick;
            // 
            // DeviceData
            // 
            DeviceData.BackgroundColor = SystemColors.Window;
            DeviceData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DeviceData.Dock = DockStyle.Fill;
            DeviceData.GridColor = Color.Black;
            DeviceData.Location = new Point(195, 3);
            DeviceData.Name = "DeviceData";
            DeviceData.Size = new Size(912, 630);
            DeviceData.TabIndex = 1;
            // 
            // tabFront
            // 
            tabFront.Controls.Add(tableLayoutPanel5);
            tabFront.Location = new Point(4, 24);
            tabFront.Name = "tabFront";
            tabFront.Size = new Size(1116, 642);
            tabFront.TabIndex = 3;
            tabFront.Text = "Front";
            tabFront.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.3553715F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.64463F));
            tableLayoutPanel5.Controls.Add(FrontTree, 0, 0);
            tableLayoutPanel5.Controls.Add(FrontData, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1116, 642);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // FrontTree
            // 
            FrontTree.Dock = DockStyle.Fill;
            FrontTree.FullRowSelect = true;
            FrontTree.Location = new Point(3, 3);
            FrontTree.Name = "FrontTree";
            FrontTree.Size = new Size(187, 636);
            FrontTree.TabIndex = 0;
            FrontTree.NodeMouseClick += FrontTree_NodeMouseClick;
            // 
            // FrontData
            // 
            FrontData.BackgroundColor = SystemColors.Window;
            FrontData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FrontData.Dock = DockStyle.Fill;
            FrontData.GridColor = Color.Black;
            FrontData.Location = new Point(196, 3);
            FrontData.Name = "FrontData";
            FrontData.Size = new Size(917, 636);
            FrontData.TabIndex = 1;
            // 
            // tabGame
            // 
            tabGame.Controls.Add(tableLayoutPanel6);
            tabGame.Location = new Point(4, 24);
            tabGame.Name = "tabGame";
            tabGame.Size = new Size(1116, 642);
            tabGame.TabIndex = 4;
            tabGame.Text = "Game";
            tabGame.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.3553715F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.64463F));
            tableLayoutPanel6.Controls.Add(GameTree, 0, 0);
            tableLayoutPanel6.Controls.Add(GameData, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1116, 642);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // GameTree
            // 
            GameTree.Dock = DockStyle.Fill;
            GameTree.FullRowSelect = true;
            GameTree.Location = new Point(3, 3);
            GameTree.Name = "GameTree";
            GameTree.Size = new Size(187, 636);
            GameTree.TabIndex = 0;
            GameTree.NodeMouseClick += GameTree_NodeMouseClick;
            // 
            // GameData
            // 
            GameData.BackgroundColor = SystemColors.Window;
            GameData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GameData.Dock = DockStyle.Fill;
            GameData.GridColor = Color.Black;
            GameData.Location = new Point(196, 3);
            GameData.Name = "GameData";
            GameData.Size = new Size(917, 636);
            GameData.TabIndex = 1;
            // 
            // tabUser
            // 
            tabUser.Controls.Add(tableLayoutPanel8);
            tabUser.Location = new Point(4, 24);
            tabUser.Name = "tabUser";
            tabUser.Size = new Size(1116, 642);
            tabUser.TabIndex = 5;
            tabUser.Text = "User";
            tabUser.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.3553715F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.64463F));
            tableLayoutPanel8.Controls.Add(UserTree, 0, 0);
            tableLayoutPanel8.Controls.Add(UserData, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(1116, 642);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // UserTree
            // 
            UserTree.Dock = DockStyle.Fill;
            UserTree.FullRowSelect = true;
            UserTree.Location = new Point(3, 3);
            UserTree.Name = "UserTree";
            UserTree.Size = new Size(187, 636);
            UserTree.TabIndex = 0;
            UserTree.NodeMouseClick += UserTree_NodeMouseClick;
            // 
            // UserData
            // 
            UserData.BackgroundColor = SystemColors.Window;
            UserData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserData.Dock = DockStyle.Fill;
            UserData.GridColor = Color.Black;
            UserData.Location = new Point(196, 3);
            UserData.Name = "UserData";
            UserData.Size = new Size(917, 636);
            UserData.TabIndex = 1;
            // 
            // AccountsBox
            // 
            AccountsBox.Controls.Add(btnFilter);
            AccountsBox.Controls.Add(EmailLabel);
            AccountsBox.Controls.Add(EmailSearch);
            AccountsBox.Controls.Add(CharIDLabel);
            AccountsBox.Controls.Add(CharIDSearch);
            AccountsBox.Controls.Add(AccountNameLabel);
            AccountsBox.Controls.Add(AccountNameSearch);
            AccountsBox.Controls.Add(CharNameLabel);
            AccountsBox.Controls.Add(AccountIDLabel);
            AccountsBox.Controls.Add(CharNameSearch);
            AccountsBox.Controls.Add(AccountIDSearch);
            AccountsBox.Location = new Point(3, 3);
            AccountsBox.Name = "AccountsBox";
            AccountsBox.Size = new Size(128, 273);
            AccountsBox.TabIndex = 0;
            AccountsBox.TabStop = false;
            AccountsBox.Text = "Search / Filter";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(50, 242);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 10;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(3, 195);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 9;
            EmailLabel.Text = "Email";
            // 
            // EmailSearch
            // 
            EmailSearch.Location = new Point(3, 213);
            EmailSearch.Name = "EmailSearch";
            EmailSearch.Size = new Size(122, 23);
            EmailSearch.TabIndex = 8;
            // 
            // CharIDLabel
            // 
            CharIDLabel.AutoSize = true;
            CharIDLabel.Location = new Point(3, 151);
            CharIDLabel.Name = "CharIDLabel";
            CharIDLabel.Size = new Size(72, 15);
            CharIDLabel.TabIndex = 7;
            CharIDLabel.Text = "Character ID";
            // 
            // CharIDSearch
            // 
            CharIDSearch.Location = new Point(3, 169);
            CharIDSearch.Name = "CharIDSearch";
            CharIDSearch.Size = new Size(122, 23);
            CharIDSearch.TabIndex = 6;
            // 
            // AccountNameLabel
            // 
            AccountNameLabel.AutoSize = true;
            AccountNameLabel.Location = new Point(3, 107);
            AccountNameLabel.Name = "AccountNameLabel";
            AccountNameLabel.Size = new Size(87, 15);
            AccountNameLabel.TabIndex = 5;
            AccountNameLabel.Text = "Account Name";
            // 
            // AccountNameSearch
            // 
            AccountNameSearch.Location = new Point(3, 125);
            AccountNameSearch.Name = "AccountNameSearch";
            AccountNameSearch.Size = new Size(122, 23);
            AccountNameSearch.TabIndex = 4;
            // 
            // CharNameLabel
            // 
            CharNameLabel.AutoSize = true;
            CharNameLabel.Location = new Point(3, 63);
            CharNameLabel.Name = "CharNameLabel";
            CharNameLabel.Size = new Size(93, 15);
            CharNameLabel.TabIndex = 3;
            CharNameLabel.Text = "Character Name";
            // 
            // AccountIDLabel
            // 
            AccountIDLabel.AutoSize = true;
            AccountIDLabel.Location = new Point(3, 19);
            AccountIDLabel.Name = "AccountIDLabel";
            AccountIDLabel.Size = new Size(66, 15);
            AccountIDLabel.TabIndex = 2;
            AccountIDLabel.Text = "Account ID";
            // 
            // CharNameSearch
            // 
            CharNameSearch.Location = new Point(3, 81);
            CharNameSearch.Name = "CharNameSearch";
            CharNameSearch.Size = new Size(122, 23);
            CharNameSearch.TabIndex = 1;
            // 
            // AccountIDSearch
            // 
            AccountIDSearch.Location = new Point(3, 37);
            AccountIDSearch.Name = "AccountIDSearch";
            AccountIDSearch.Size = new Size(122, 23);
            AccountIDSearch.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.63049F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.3695145F));
            tableLayoutPanel1.Controls.Add(AccountsBox, 0, 0);
            tableLayoutPanel1.Controls.Add(DatabaseTabs, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1264, 676);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.FullRowSelect = true;
            treeView1.LineColor = Color.Empty;
            treeView1.Location = new Point(3, 3);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(28, 630);
            treeView1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(37, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(160, 630);
            dataGridView1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.3553715F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.64463F));
            tableLayoutPanel3.Controls.Add(treeView1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // treeView5
            // 
            treeView5.Dock = DockStyle.Fill;
            treeView5.FullRowSelect = true;
            treeView5.LineColor = Color.Empty;
            treeView5.Location = new Point(3, 3);
            treeView5.Name = "treeView5";
            treeView5.Size = new Size(28, 630);
            treeView5.TabIndex = 0;
            // 
            // dataGridView5
            // 
            dataGridView5.BackgroundColor = SystemColors.Window;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Dock = DockStyle.Fill;
            dataGridView5.GridColor = SystemColors.Window;
            dataGridView5.Location = new Point(37, 3);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(160, 630);
            dataGridView5.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.3553715F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.64463F));
            tableLayoutPanel7.Controls.Add(treeView5, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.Size = new Size(200, 100);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // DatabaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 676);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DatabaseForm";
            Text = "Database Editor";
            Load += DatabaseForm_Load;
            DatabaseTabs.ResumeLayout(false);
            tabAdmin.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AdminData).EndInit();
            tabDevice.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DeviceData).EndInit();
            tabFront.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FrontData).EndInit();
            tabGame.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GameData).EndInit();
            tabUser.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UserData).EndInit();
            AccountsBox.ResumeLayout(false);
            AccountsBox.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeView AdminTree;
        private TabControl DatabaseTabs;
        private GroupBox AccountsBox;
        private Label AccountIDLabel;
        private TextBox CharNameSearch;
        private TextBox AccountIDSearch;
        private Label CharNameLabel;
        private Label AccountNameLabel;
        private TextBox AccountNameSearch;
        private Label CharIDLabel;
        private TextBox CharIDSearch;
        private Label EmailLabel;
        private TextBox EmailSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabAdmin;
        private DataGridView AdminData;
        private TabPage tabDevice;
        private TabPage tabFront;
        private TabPage tabGame;
        private TabPage tabUser;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TreeView DeviceTree;
        private DataGridView DeviceData;
        private TableLayoutPanel tableLayoutPanel5;
        private TreeView FrontTree;
        private DataGridView FrontData;
        private TableLayoutPanel tableLayoutPanel6;
        private TreeView GameTree;
        private DataGridView GameData;
        private TableLayoutPanel tableLayoutPanel8;
        private TreeView UserTree;
        private DataGridView UserData;
        private TreeView treeView1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private TreeView treeView5;
        private DataGridView dataGridView5;
        private TableLayoutPanel tableLayoutPanel7;
        private Button btnFilter;
    }
}