namespace Virtual_Instrumentation
{
    partial class DatabaseViewerForm
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseViewerForm));
            panelTop = new Panel();
            btnClose = new Button();
            panel1 = new Panel();
            panelLeftBlue = new Panel();
            panelLeftSky = new Panel();
            panelLeftGreen = new Panel();
            lblTitle = new Label();
            panelLeft = new Panel();
            groupBoxTables = new GroupBox();
            lblTableName = new Label();
            comboBoxTables = new ComboBox();
            btnRefresh = new Button();
            lblTotalRecords = new Label();
            groupBoxData = new GroupBox();
            dataGridViewMain = new DataGridView();
            panelActions = new Panel();
            btnDeleteSelected = new Button();
            btnDeleteAll = new Button();
            btnExportCSV = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            groupBoxQuery = new GroupBox();
            txtCustomQuery = new TextBox();
            btnExecuteQuery = new Button();
            lblQueryHint = new Label();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxTables.SuspendLayout();
            groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            panelActions.SuspendLayout();
            groupBoxQuery.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(30, 58, 138);
            panelTop.Controls.Add(btnClose);
            panelTop.Controls.Add(panel1);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1300, 70);
            panelTop.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(231, 76, 60);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1134, 12);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 47);
            btnClose.TabIndex = 5;
            btnClose.Text = "✖ Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelLeftBlue);
            panel1.Controls.Add(panelLeftSky);
            panel1.Controls.Add(panelLeftGreen);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(15, 70);
            panel1.TabIndex = 4;
            // 
            // panelLeftBlue
            // 
            panelLeftBlue.BackColor = Color.FromArgb(30, 58, 138);
            panelLeftBlue.Dock = DockStyle.Left;
            panelLeftBlue.Location = new Point(10, 0);
            panelLeftBlue.Name = "panelLeftBlue";
            panelLeftBlue.Size = new Size(5, 70);
            panelLeftBlue.TabIndex = 0;
            // 
            // panelLeftSky
            // 
            panelLeftSky.BackColor = Color.FromArgb(59, 130, 246);
            panelLeftSky.Dock = DockStyle.Left;
            panelLeftSky.Location = new Point(5, 0);
            panelLeftSky.Name = "panelLeftSky";
            panelLeftSky.Size = new Size(5, 70);
            panelLeftSky.TabIndex = 1;
            // 
            // panelLeftGreen
            // 
            panelLeftGreen.BackColor = Color.FromArgb(16, 185, 129);
            panelLeftGreen.Dock = DockStyle.Left;
            panelLeftGreen.Location = new Point(0, 0);
            panelLeftGreen.Name = "panelLeftGreen";
            panelLeftGreen.Size = new Size(5, 70);
            panelLeftGreen.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(21, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(444, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🗄 Database Management";
            // 
            // panelLeft
            // 
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(0, 70);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(1300, 630);
            panelLeft.TabIndex = 1;
            // 
            // groupBoxTables
            // 
            groupBoxTables.Controls.Add(lblTableName);
            groupBoxTables.Controls.Add(comboBoxTables);
            groupBoxTables.Controls.Add(btnRefresh);
            groupBoxTables.Controls.Add(lblTotalRecords);
            groupBoxTables.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxTables.ForeColor = Color.FromArgb(30, 58, 138);
            groupBoxTables.Location = new Point(35, 90);
            groupBoxTables.Name = "groupBoxTables";
            groupBoxTables.Size = new Size(1245, 90);
            groupBoxTables.TabIndex = 2;
            groupBoxTables.TabStop = false;
            groupBoxTables.Text = "Table Selection";
            // 
            // lblTableName
            // 
            lblTableName.AutoSize = true;
            lblTableName.Font = new Font("Segoe UI", 10F);
            lblTableName.ForeColor = Color.FromArgb(100, 116, 139);
            lblTableName.Location = new Point(20, 35);
            lblTableName.Name = "lblTableName";
            lblTableName.Size = new Size(103, 23);
            lblTableName.TabIndex = 0;
            lblTableName.Text = "Select Table:";
            // 
            // comboBoxTables
            // 
            comboBoxTables.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTables.Font = new Font("Segoe UI", 10F);
            comboBoxTables.FormattingEnabled = true;
            comboBoxTables.Location = new Point(120, 32);
            comboBoxTables.Name = "comboBoxTables";
            comboBoxTables.Size = new Size(250, 31);
            comboBoxTables.TabIndex = 1;
            comboBoxTables.SelectedIndexChanged += comboBoxTables_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(59, 130, 246);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(390, 30);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 30);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalRecords.ForeColor = Color.FromArgb(16, 185, 129);
            lblTotalRecords.Location = new Point(950, 35);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(152, 25);
            lblTotalRecords.TabIndex = 3;
            lblTotalRecords.Text = "Total Records: 0";
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(dataGridViewMain);
            groupBoxData.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxData.ForeColor = Color.FromArgb(30, 58, 138);
            groupBoxData.Location = new Point(35, 195);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(1245, 350);
            groupBoxData.TabIndex = 3;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Data View";
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.AllowUserToAddRows = false;
            dataGridViewMain.BackgroundColor = Color.FromArgb(241, 245, 249);
            dataGridViewMain.BorderStyle = BorderStyle.None;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.Location = new Point(20, 30);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.ReadOnly = true;
            dataGridViewMain.RowHeadersWidth = 51;
            dataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMain.Size = new Size(1205, 300);
            dataGridViewMain.TabIndex = 0;
            // 
            // panelActions
            // 
            panelActions.BackColor = Color.White;
            panelActions.Controls.Add(btnDeleteSelected);
            panelActions.Controls.Add(btnDeleteAll);
            panelActions.Controls.Add(btnExportCSV);
            panelActions.Controls.Add(btnSearch);
            panelActions.Controls.Add(txtSearch);
            panelActions.Location = new Point(35, 560);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(630, 130);
            panelActions.TabIndex = 4;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.BackColor = Color.FromArgb(239, 68, 68);
            btnDeleteSelected.FlatStyle = FlatStyle.Flat;
            btnDeleteSelected.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteSelected.ForeColor = Color.White;
            btnDeleteSelected.Location = new Point(20, 70);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(180, 40);
            btnDeleteSelected.TabIndex = 0;
            btnDeleteSelected.Text = "🗑 Delete Selected";
            btnDeleteSelected.UseVisualStyleBackColor = false;
            btnDeleteSelected.Click += btnDeleteSelected_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.FromArgb(220, 38, 38);
            btnDeleteAll.FlatStyle = FlatStyle.Flat;
            btnDeleteAll.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteAll.ForeColor = Color.White;
            btnDeleteAll.Location = new Point(220, 70);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(180, 40);
            btnDeleteAll.TabIndex = 1;
            btnDeleteAll.Text = "⚠ Delete All Records";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnExportCSV
            // 
            btnExportCSV.BackColor = Color.FromArgb(16, 185, 129);
            btnExportCSV.FlatStyle = FlatStyle.Flat;
            btnExportCSV.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExportCSV.ForeColor = Color.White;
            btnExportCSV.Location = new Point(420, 70);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(180, 40);
            btnExportCSV.TabIndex = 2;
            btnExportCSV.Text = "📤 Export to CSV";
            btnExportCSV.UseVisualStyleBackColor = false;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(59, 130, 246);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(480, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 35);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "🔍 Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(20, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by ID or timestamp...";
            txtSearch.Size = new Size(440, 32);
            txtSearch.TabIndex = 3;
            // 
            // groupBoxQuery
            // 
            groupBoxQuery.Controls.Add(txtCustomQuery);
            groupBoxQuery.Controls.Add(btnExecuteQuery);
            groupBoxQuery.Controls.Add(lblQueryHint);
            groupBoxQuery.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxQuery.ForeColor = Color.FromArgb(30, 58, 138);
            groupBoxQuery.Location = new Point(685, 560);
            groupBoxQuery.Name = "groupBoxQuery";
            groupBoxQuery.Size = new Size(595, 130);
            groupBoxQuery.TabIndex = 5;
            groupBoxQuery.TabStop = false;
            groupBoxQuery.Text = "Custom SQL Query";
            // 
            // txtCustomQuery
            // 
            txtCustomQuery.Font = new Font("Consolas", 10F);
            txtCustomQuery.Location = new Point(20, 30);
            txtCustomQuery.Multiline = true;
            txtCustomQuery.Name = "txtCustomQuery";
            txtCustomQuery.PlaceholderText = "SELECT * FROM readings WHERE pot1 > 500";
            txtCustomQuery.Size = new Size(555, 50);
            txtCustomQuery.TabIndex = 0;
            // 
            // btnExecuteQuery
            // 
            btnExecuteQuery.BackColor = Color.FromArgb(16, 185, 129);
            btnExecuteQuery.FlatStyle = FlatStyle.Flat;
            btnExecuteQuery.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExecuteQuery.ForeColor = Color.White;
            btnExecuteQuery.Location = new Point(435, 85);
            btnExecuteQuery.Name = "btnExecuteQuery";
            btnExecuteQuery.Size = new Size(140, 30);
            btnExecuteQuery.TabIndex = 1;
            btnExecuteQuery.Text = "▶ Execute Query";
            btnExecuteQuery.UseVisualStyleBackColor = false;
            btnExecuteQuery.Click += btnExecuteQuery_Click;
            // 
            // lblQueryHint
            // 
            lblQueryHint.AutoSize = true;
            lblQueryHint.Font = new Font("Segoe UI", 8F);
            lblQueryHint.ForeColor = Color.FromArgb(100, 116, 139);
            lblQueryHint.Location = new Point(20, 92);
            lblQueryHint.Name = "lblQueryHint";
            lblQueryHint.Size = new Size(318, 19);
            lblQueryHint.TabIndex = 2;
            lblQueryHint.Text = "⚠ Use SELECT queries only. Be careful with filters!";
            // 
            // DatabaseViewerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 700);
            Controls.Add(groupBoxQuery);
            Controls.Add(panelActions);
            Controls.Add(groupBoxData);
            Controls.Add(groupBoxTables);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DatabaseViewerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Database Management - Virtual Instrumentation";
            Load += DatabaseViewerForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel1.ResumeLayout(false);
            groupBoxTables.ResumeLayout(false);
            groupBoxTables.PerformLayout();
            groupBoxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            panelActions.ResumeLayout(false);
            panelActions.PerformLayout();
            groupBoxQuery.ResumeLayout(false);
            groupBoxQuery.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBoxTables;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBoxQuery;
        private System.Windows.Forms.TextBox txtCustomQuery;
        private System.Windows.Forms.Button btnExecuteQuery;
        private System.Windows.Forms.Label lblQueryHint;
        private Panel panel1;
        private Panel panelLeftBlue;
        private Panel panelLeftSky;
        private Panel panelLeftGreen;
        private Button btnClose;
    }
}