namespace Virtual_Instrumentation
{
    partial class MainDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboardForm));
            panelTop = new Panel();
            btnDatabase = new Button();
            btnStatistics = new Button();
            panelLeft = new Panel();
            panelLeftBlue = new Panel();
            panelLeftSky = new Panel();
            panelLeftGreen = new Panel();
            lblTitle = new Label();
            groupBoxPort = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnOpen = new Button();
            btnClose = new Button();
            groupBoxData = new GroupBox();
            btnSimulation = new Button();
            btnClearData = new Button();
            groupBoxReceive = new GroupBox();
            textBox2 = new TextBox();
            groupBoxPOT1 = new GroupBox();
            solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            dataGridView1 = new DataGridView();
            groupBoxPOT2 = new GroupBox();
            solidGauge2 = new LiveCharts.WinForms.SolidGauge();
            cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            dataGridView2 = new DataGridView();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxPort.SuspendLayout();
            groupBoxData.SuspendLayout();
            groupBoxReceive.SuspendLayout();
            groupBoxPOT1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxPOT2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(30, 58, 138);
            panelTop.Controls.Add(btnDatabase);
            panelTop.Controls.Add(btnStatistics);
            panelTop.Controls.Add(panelLeft);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1200, 70);
            panelTop.TabIndex = 0;
            // 
            // btnDatabase
            // 
            btnDatabase.BackColor = Color.FromArgb(16, 185, 129);
            btnDatabase.FlatStyle = FlatStyle.Flat;
            btnDatabase.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDatabase.ForeColor = Color.White;
            btnDatabase.Location = new Point(772, 11);
            btnDatabase.Margin = new Padding(3, 4, 3, 4);
            btnDatabase.Name = "btnDatabase";
            btnDatabase.Size = new Size(185, 47);
            btnDatabase.TabIndex = 6;
            btnDatabase.Text = "🗄 DB Management";
            btnDatabase.UseVisualStyleBackColor = false;
            btnDatabase.Click += btnDatabase_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.BackColor = Color.FromArgb(16, 185, 129);
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStatistics.ForeColor = Color.White;
            btnStatistics.Location = new Point(975, 12);
            btnStatistics.Margin = new Padding(3, 4, 3, 4);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(185, 47);
            btnStatistics.TabIndex = 5;
            btnStatistics.Text = "📊 Statistics";
            btnStatistics.UseVisualStyleBackColor = false;
            btnStatistics.Click += BtnStatistics_Click;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(panelLeftBlue);
            panelLeft.Controls.Add(panelLeftSky);
            panelLeft.Controls.Add(panelLeftGreen);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(15, 70);
            panelLeft.TabIndex = 4;
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
            lblTitle.Size = new Size(284, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Main Dashboard";
            // 
            // groupBoxPort
            // 
            groupBoxPort.Controls.Add(label1);
            groupBoxPort.Controls.Add(comboBox1);
            groupBoxPort.Controls.Add(btnOpen);
            groupBoxPort.Controls.Add(btnClose);
            groupBoxPort.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxPort.ForeColor = Color.FromArgb(30, 58, 138);
            groupBoxPort.Location = new Point(35, 90);
            groupBoxPort.Name = "groupBoxPort";
            groupBoxPort.Size = new Size(380, 90);
            groupBoxPort.TabIndex = 2;
            groupBoxPort.TabStop = false;
            groupBoxPort.Text = "Port Settings";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(100, 116, 139);
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(45, 23);
            label1.TabIndex = 0;
            label1.Text = "Port:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(60, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 31);
            comboBox1.TabIndex = 1;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.FromArgb(16, 185, 129);
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(210, 30);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 30);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += open_btn;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(239, 68, 68);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(290, 30);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 30);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(btnSimulation);
            groupBoxData.Controls.Add(btnClearData);
            groupBoxData.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxData.ForeColor = Color.FromArgb(30, 58, 138);
            groupBoxData.Location = new Point(435, 90);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(340, 90);
            groupBoxData.TabIndex = 3;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Data Settings";
            // 
            // btnSimulation
            // 
            btnSimulation.BackColor = Color.FromArgb(59, 130, 246);
            btnSimulation.FlatStyle = FlatStyle.Flat;
            btnSimulation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSimulation.ForeColor = Color.White;
            btnSimulation.Location = new Point(20, 30);
            btnSimulation.Name = "btnSimulation";
            btnSimulation.Size = new Size(140, 35);
            btnSimulation.TabIndex = 0;
            btnSimulation.Text = "Start Simulation";
            btnSimulation.UseVisualStyleBackColor = false;
            btnSimulation.Click += btnSimulation_Click;
            // 
            // btnClearData
            // 
            btnClearData.BackColor = Color.FromArgb(239, 68, 68);
            btnClearData.FlatStyle = FlatStyle.Flat;
            btnClearData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClearData.ForeColor = Color.White;
            btnClearData.Location = new Point(180, 30);
            btnClearData.Name = "btnClearData";
            btnClearData.Size = new Size(140, 35);
            btnClearData.TabIndex = 1;
            btnClearData.Text = "Clear Data";
            btnClearData.UseVisualStyleBackColor = false;
            btnClearData.Click += btnClearData_Click;
            // 
            // groupBoxReceive
            // 
            groupBoxReceive.Controls.Add(textBox2);
            groupBoxReceive.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxReceive.ForeColor = Color.FromArgb(30, 58, 138);
            groupBoxReceive.Location = new Point(795, 90);
            groupBoxReceive.Name = "groupBoxReceive";
            groupBoxReceive.Size = new Size(385, 90);
            groupBoxReceive.TabIndex = 4;
            groupBoxReceive.TabStop = false;
            groupBoxReceive.Text = "Current Reading";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(241, 245, 249);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Consolas", 12F, FontStyle.Bold);
            textBox2.ForeColor = Color.FromArgb(30, 58, 138);
            textBox2.Location = new Point(15, 30);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(355, 45);
            textBox2.TabIndex = 0;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBoxPOT1
            // 
            groupBoxPOT1.Controls.Add(solidGauge1);
            groupBoxPOT1.Controls.Add(cartesianChart1);
            groupBoxPOT1.Controls.Add(dataGridView1);
            groupBoxPOT1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxPOT1.ForeColor = Color.FromArgb(30, 58, 138);
            groupBoxPOT1.Location = new Point(35, 200);
            groupBoxPOT1.Name = "groupBoxPOT1";
            groupBoxPOT1.Size = new Size(560, 520);
            groupBoxPOT1.TabIndex = 5;
            groupBoxPOT1.TabStop = false;
            groupBoxPOT1.Text = "📌 POT1 Monitor";
            // 
            // solidGauge1
            // 
            solidGauge1.Location = new Point(20, 35);
            solidGauge1.Name = "solidGauge1";
            solidGauge1.Size = new Size(250, 173);
            solidGauge1.TabIndex = 0;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(290, 35);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(250, 173);
            cartesianChart1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(241, 245, 249);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(520, 286);
            dataGridView1.TabIndex = 2;
            // 
            // groupBoxPOT2
            // 
            groupBoxPOT2.Controls.Add(solidGauge2);
            groupBoxPOT2.Controls.Add(cartesianChart2);
            groupBoxPOT2.Controls.Add(dataGridView2);
            groupBoxPOT2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBoxPOT2.ForeColor = Color.FromArgb(30, 58, 138);
            groupBoxPOT2.Location = new Point(620, 200);
            groupBoxPOT2.Name = "groupBoxPOT2";
            groupBoxPOT2.Size = new Size(560, 520);
            groupBoxPOT2.TabIndex = 6;
            groupBoxPOT2.TabStop = false;
            groupBoxPOT2.Text = "📌 POT2 Monitor";
            // 
            // solidGauge2
            // 
            solidGauge2.Location = new Point(20, 35);
            solidGauge2.Name = "solidGauge2";
            solidGauge2.Size = new Size(250, 173);
            solidGauge2.TabIndex = 0;
            // 
            // cartesianChart2
            // 
            cartesianChart2.Location = new Point(290, 35);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(250, 173);
            cartesianChart2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(241, 245, 249);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(20, 214);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(520, 286);
            dataGridView2.TabIndex = 2;
            // 
            // MainDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 750);
            Controls.Add(groupBoxPOT2);
            Controls.Add(groupBoxPOT1);
            Controls.Add(groupBoxReceive);
            Controls.Add(groupBoxData);
            Controls.Add(groupBoxPort);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Dashboard - Virtual Instrumentation";
            FormClosing += MainDashboardForm_FormClosing;
            Load += MainDashboardForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelLeft.ResumeLayout(false);
            groupBoxPort.ResumeLayout(false);
            groupBoxPort.PerformLayout();
            groupBoxData.ResumeLayout(false);
            groupBoxReceive.ResumeLayout(false);
            groupBoxReceive.PerformLayout();
            groupBoxPOT1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxPOT2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Button btnSimulation;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.GroupBox groupBoxReceive;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBoxPOT1;
        private LiveCharts.WinForms.SolidGauge solidGauge1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxPOT2;
        private LiveCharts.WinForms.SolidGauge solidGauge2;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Panel panelLeft;
        private Panel panelLeftBlue;
        private Panel panelLeftSky;
        private Panel panelLeftGreen;
        private Button btnStatistics;
        private Button btnDatabase;
    }
}