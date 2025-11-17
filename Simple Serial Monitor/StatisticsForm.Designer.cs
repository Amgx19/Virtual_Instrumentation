namespace Simple_Serial_Monitor
{
    partial class StatisticsForm
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
            panel1 = new Panel();
            panelLeft = new Panel();
            panelLeftBlue = new Panel();
            panelLeftSky = new Panel();
            panelLeftGreen = new Panel();
            lblTitle = new Label();
            btnRefresh = new Button();
            btnClose = new Button();
            tabControl1 = new TabControl();
            tabPOT1 = new TabPage();
            panelPOT1Stats = new Panel();
            gaugePOT1Min = new LiveCharts.WinForms.SolidGauge();
            gaugePOT1Max = new LiveCharts.WinForms.SolidGauge();
            gaugePOT1Avg = new LiveCharts.WinForms.SolidGauge();
            gaugePOT1Count = new LiveCharts.WinForms.SolidGauge();
            lblPOT1MinTitle = new Label();
            lblPOT1MaxTitle = new Label();
            lblPOT1AvgTitle = new Label();
            lblPOT1CountTitle = new Label();
            chartPOT1Line = new LiveCharts.WinForms.CartesianChart();
            chartPOT1Pie = new LiveCharts.WinForms.PieChart();
            tabPOT2 = new TabPage();
            panelPOT2Stats = new Panel();
            gaugePOT2Min = new LiveCharts.WinForms.SolidGauge();
            gaugePOT2Max = new LiveCharts.WinForms.SolidGauge();
            gaugePOT2Avg = new LiveCharts.WinForms.SolidGauge();
            gaugePOT2Count = new LiveCharts.WinForms.SolidGauge();
            lblPOT2MinTitle = new Label();
            lblPOT2MaxTitle = new Label();
            lblPOT2AvgTitle = new Label();
            lblPOT2CountTitle = new Label();
            chartPOT2Line = new LiveCharts.WinForms.CartesianChart();
            chartPOT2Pie = new LiveCharts.WinForms.PieChart();
            tabComparison = new TabPage();
            chartComparison = new LiveCharts.WinForms.CartesianChart();
            panelCompStats = new Panel();
            lblCorrelation = new Label();
            lblDifference = new Label();
            panel1.SuspendLayout();
            panelLeft.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPOT1.SuspendLayout();
            panelPOT1Stats.SuspendLayout();
            tabPOT2.SuspendLayout();
            panelPOT2Stats.SuspendLayout();
            tabComparison.SuspendLayout();
            panelCompStats.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 65, 142);
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 80);
            panel1.TabIndex = 0;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(panelLeftBlue);
            panelLeft.Controls.Add(panelLeftSky);
            panelLeft.Controls.Add(panelLeftGreen);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(15, 80);
            panelLeft.TabIndex = 3;
            // 
            // panelLeftBlue
            // 
            panelLeftBlue.BackColor = Color.FromArgb(30, 58, 138);
            panelLeftBlue.Dock = DockStyle.Left;
            panelLeftBlue.Location = new Point(10, 0);
            panelLeftBlue.Name = "panelLeftBlue";
            panelLeftBlue.Size = new Size(5, 80);
            panelLeftBlue.TabIndex = 0;
            // 
            // panelLeftSky
            // 
            panelLeftSky.BackColor = Color.FromArgb(59, 130, 246);
            panelLeftSky.Dock = DockStyle.Left;
            panelLeftSky.Location = new Point(5, 0);
            panelLeftSky.Name = "panelLeftSky";
            panelLeftSky.Size = new Size(5, 80);
            panelLeftSky.TabIndex = 1;
            // 
            // panelLeftGreen
            // 
            panelLeftGreen.BackColor = Color.FromArgb(16, 185, 129);
            panelLeftGreen.Dock = DockStyle.Left;
            panelLeftGreen.Location = new Point(0, 0);
            panelLeftGreen.Name = "panelLeftGreen";
            panelLeftGreen.Size = new Size(5, 80);
            panelLeftGreen.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(21, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(329, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📊 Statistical Analysis";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(46, 204, 113);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1086, 16);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(126, 47);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(231, 76, 60);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1223, 16);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 47);
            btnClose.TabIndex = 2;
            btnClose.Text = "✖ Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPOT1);
            tabControl1.Controls.Add(tabPOT2);
            tabControl1.Controls.Add(tabComparison);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(0, 80);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1371, 853);
            tabControl1.TabIndex = 1;
            // 
            // tabPOT1
            // 
            tabPOT1.BackColor = Color.WhiteSmoke;
            tabPOT1.Controls.Add(panelPOT1Stats);
            tabPOT1.Controls.Add(chartPOT1Line);
            tabPOT1.Controls.Add(chartPOT1Pie);
            tabPOT1.Location = new Point(4, 32);
            tabPOT1.Margin = new Padding(3, 4, 3, 4);
            tabPOT1.Name = "tabPOT1";
            tabPOT1.Padding = new Padding(3, 4, 3, 4);
            tabPOT1.Size = new Size(1363, 817);
            tabPOT1.TabIndex = 0;
            tabPOT1.Text = "📊 POT1 Analysis";
            // 
            // panelPOT1Stats
            // 
            panelPOT1Stats.BackColor = Color.White;
            panelPOT1Stats.BorderStyle = BorderStyle.FixedSingle;
            panelPOT1Stats.Controls.Add(gaugePOT1Min);
            panelPOT1Stats.Controls.Add(gaugePOT1Max);
            panelPOT1Stats.Controls.Add(gaugePOT1Avg);
            panelPOT1Stats.Controls.Add(gaugePOT1Count);
            panelPOT1Stats.Controls.Add(lblPOT1MinTitle);
            panelPOT1Stats.Controls.Add(lblPOT1MaxTitle);
            panelPOT1Stats.Controls.Add(lblPOT1AvgTitle);
            panelPOT1Stats.Controls.Add(lblPOT1CountTitle);
            panelPOT1Stats.Location = new Point(23, 27);
            panelPOT1Stats.Margin = new Padding(3, 4, 3, 4);
            panelPOT1Stats.Name = "panelPOT1Stats";
            panelPOT1Stats.Size = new Size(1303, 239);
            panelPOT1Stats.TabIndex = 0;
            // 
            // gaugePOT1Min
            // 
            gaugePOT1Min.Location = new Point(46, 20);
            gaugePOT1Min.Margin = new Padding(3, 4, 3, 4);
            gaugePOT1Min.Name = "gaugePOT1Min";
            gaugePOT1Min.Size = new Size(229, 160);
            gaugePOT1Min.TabIndex = 0;
            // 
            // gaugePOT1Max
            // 
            gaugePOT1Max.Location = new Point(354, 20);
            gaugePOT1Max.Margin = new Padding(3, 4, 3, 4);
            gaugePOT1Max.Name = "gaugePOT1Max";
            gaugePOT1Max.Size = new Size(229, 160);
            gaugePOT1Max.TabIndex = 1;
            // 
            // gaugePOT1Avg
            // 
            gaugePOT1Avg.Location = new Point(663, 20);
            gaugePOT1Avg.Margin = new Padding(3, 4, 3, 4);
            gaugePOT1Avg.Name = "gaugePOT1Avg";
            gaugePOT1Avg.Size = new Size(229, 160);
            gaugePOT1Avg.TabIndex = 2;
            // 
            // gaugePOT1Count
            // 
            gaugePOT1Count.Location = new Point(971, 20);
            gaugePOT1Count.Margin = new Padding(3, 4, 3, 4);
            gaugePOT1Count.Name = "gaugePOT1Count";
            gaugePOT1Count.Size = new Size(229, 160);
            gaugePOT1Count.TabIndex = 3;
            // 
            // lblPOT1MinTitle
            // 
            lblPOT1MinTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPOT1MinTitle.ForeColor = Color.FromArgb(52, 152, 219);
            lblPOT1MinTitle.Location = new Point(46, 187);
            lblPOT1MinTitle.Name = "lblPOT1MinTitle";
            lblPOT1MinTitle.Size = new Size(229, 33);
            lblPOT1MinTitle.TabIndex = 4;
            lblPOT1MinTitle.Text = "📉 Minimum";
            lblPOT1MinTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPOT1MaxTitle
            // 
            lblPOT1MaxTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPOT1MaxTitle.ForeColor = Color.FromArgb(231, 76, 60);
            lblPOT1MaxTitle.Location = new Point(354, 187);
            lblPOT1MaxTitle.Name = "lblPOT1MaxTitle";
            lblPOT1MaxTitle.Size = new Size(229, 33);
            lblPOT1MaxTitle.TabIndex = 5;
            lblPOT1MaxTitle.Text = "📈 Maximum";
            lblPOT1MaxTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPOT1AvgTitle
            // 
            lblPOT1AvgTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPOT1AvgTitle.ForeColor = Color.FromArgb(46, 204, 113);
            lblPOT1AvgTitle.Location = new Point(663, 187);
            lblPOT1AvgTitle.Name = "lblPOT1AvgTitle";
            lblPOT1AvgTitle.Size = new Size(229, 33);
            lblPOT1AvgTitle.TabIndex = 6;
            lblPOT1AvgTitle.Text = "📊 Average";
            lblPOT1AvgTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPOT1CountTitle
            // 
            lblPOT1CountTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPOT1CountTitle.ForeColor = Color.FromArgb(155, 89, 182);
            lblPOT1CountTitle.Location = new Point(971, 187);
            lblPOT1CountTitle.Name = "lblPOT1CountTitle";
            lblPOT1CountTitle.Size = new Size(229, 33);
            lblPOT1CountTitle.TabIndex = 7;
            lblPOT1CountTitle.Text = "🔢 Total Records";
            lblPOT1CountTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartPOT1Line
            // 
            chartPOT1Line.Location = new Point(23, 293);
            chartPOT1Line.Margin = new Padding(3, 4, 3, 4);
            chartPOT1Line.Name = "chartPOT1Line";
            chartPOT1Line.Size = new Size(800, 333);
            chartPOT1Line.TabIndex = 1;
            // 
            // chartPOT1Pie
            // 
            chartPOT1Pie.Location = new Point(829, 293);
            chartPOT1Pie.Margin = new Padding(3, 4, 3, 4);
            chartPOT1Pie.Name = "chartPOT1Pie";
            chartPOT1Pie.Size = new Size(514, 333);
            chartPOT1Pie.TabIndex = 2;
            // 
            // tabPOT2
            // 
            tabPOT2.BackColor = Color.WhiteSmoke;
            tabPOT2.Controls.Add(panelPOT2Stats);
            tabPOT2.Controls.Add(chartPOT2Line);
            tabPOT2.Controls.Add(chartPOT2Pie);
            tabPOT2.Location = new Point(4, 32);
            tabPOT2.Margin = new Padding(3, 4, 3, 4);
            tabPOT2.Name = "tabPOT2";
            tabPOT2.Padding = new Padding(3, 4, 3, 4);
            tabPOT2.Size = new Size(1363, 817);
            tabPOT2.TabIndex = 1;
            tabPOT2.Text = "📊 POT2 Analysis";
            // 
            // panelPOT2Stats
            // 
            panelPOT2Stats.BackColor = Color.White;
            panelPOT2Stats.BorderStyle = BorderStyle.FixedSingle;
            panelPOT2Stats.Controls.Add(gaugePOT2Min);
            panelPOT2Stats.Controls.Add(gaugePOT2Max);
            panelPOT2Stats.Controls.Add(gaugePOT2Avg);
            panelPOT2Stats.Controls.Add(gaugePOT2Count);
            panelPOT2Stats.Controls.Add(lblPOT2MinTitle);
            panelPOT2Stats.Controls.Add(lblPOT2MaxTitle);
            panelPOT2Stats.Controls.Add(lblPOT2AvgTitle);
            panelPOT2Stats.Controls.Add(lblPOT2CountTitle);
            panelPOT2Stats.Location = new Point(23, 27);
            panelPOT2Stats.Margin = new Padding(3, 4, 3, 4);
            panelPOT2Stats.Name = "panelPOT2Stats";
            panelPOT2Stats.Size = new Size(1303, 239);
            panelPOT2Stats.TabIndex = 0;
            // 
            // gaugePOT2Min
            // 
            gaugePOT2Min.Location = new Point(46, 20);
            gaugePOT2Min.Margin = new Padding(3, 4, 3, 4);
            gaugePOT2Min.Name = "gaugePOT2Min";
            gaugePOT2Min.Size = new Size(229, 160);
            gaugePOT2Min.TabIndex = 0;
            // 
            // gaugePOT2Max
            // 
            gaugePOT2Max.Location = new Point(354, 20);
            gaugePOT2Max.Margin = new Padding(3, 4, 3, 4);
            gaugePOT2Max.Name = "gaugePOT2Max";
            gaugePOT2Max.Size = new Size(229, 160);
            gaugePOT2Max.TabIndex = 1;
            // 
            // gaugePOT2Avg
            // 
            gaugePOT2Avg.Location = new Point(663, 20);
            gaugePOT2Avg.Margin = new Padding(3, 4, 3, 4);
            gaugePOT2Avg.Name = "gaugePOT2Avg";
            gaugePOT2Avg.Size = new Size(229, 160);
            gaugePOT2Avg.TabIndex = 2;
            // 
            // gaugePOT2Count
            // 
            gaugePOT2Count.Location = new Point(971, 20);
            gaugePOT2Count.Margin = new Padding(3, 4, 3, 4);
            gaugePOT2Count.Name = "gaugePOT2Count";
            gaugePOT2Count.Size = new Size(229, 160);
            gaugePOT2Count.TabIndex = 3;
            // 
            // lblPOT2MinTitle
            // 
            lblPOT2MinTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPOT2MinTitle.ForeColor = Color.FromArgb(52, 152, 219);
            lblPOT2MinTitle.Location = new Point(46, 187);
            lblPOT2MinTitle.Name = "lblPOT2MinTitle";
            lblPOT2MinTitle.Size = new Size(229, 33);
            lblPOT2MinTitle.TabIndex = 4;
            lblPOT2MinTitle.Text = "📉 Minimum";
            lblPOT2MinTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPOT2MaxTitle
            // 
            lblPOT2MaxTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPOT2MaxTitle.ForeColor = Color.FromArgb(231, 76, 60);
            lblPOT2MaxTitle.Location = new Point(354, 187);
            lblPOT2MaxTitle.Name = "lblPOT2MaxTitle";
            lblPOT2MaxTitle.Size = new Size(229, 33);
            lblPOT2MaxTitle.TabIndex = 5;
            lblPOT2MaxTitle.Text = "📈 Maximum";
            lblPOT2MaxTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPOT2AvgTitle
            // 
            lblPOT2AvgTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPOT2AvgTitle.ForeColor = Color.FromArgb(46, 204, 113);
            lblPOT2AvgTitle.Location = new Point(663, 187);
            lblPOT2AvgTitle.Name = "lblPOT2AvgTitle";
            lblPOT2AvgTitle.Size = new Size(229, 33);
            lblPOT2AvgTitle.TabIndex = 6;
            lblPOT2AvgTitle.Text = "📊 Average";
            lblPOT2AvgTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPOT2CountTitle
            // 
            lblPOT2CountTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPOT2CountTitle.ForeColor = Color.FromArgb(155, 89, 182);
            lblPOT2CountTitle.Location = new Point(971, 187);
            lblPOT2CountTitle.Name = "lblPOT2CountTitle";
            lblPOT2CountTitle.Size = new Size(229, 33);
            lblPOT2CountTitle.TabIndex = 7;
            lblPOT2CountTitle.Text = "🔢 Total Records";
            lblPOT2CountTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartPOT2Line
            // 
            chartPOT2Line.Location = new Point(23, 293);
            chartPOT2Line.Margin = new Padding(3, 4, 3, 4);
            chartPOT2Line.Name = "chartPOT2Line";
            chartPOT2Line.Size = new Size(800, 333);
            chartPOT2Line.TabIndex = 1;
            // 
            // chartPOT2Pie
            // 
            chartPOT2Pie.Location = new Point(829, 293);
            chartPOT2Pie.Margin = new Padding(3, 4, 3, 4);
            chartPOT2Pie.Name = "chartPOT2Pie";
            chartPOT2Pie.Size = new Size(514, 333);
            chartPOT2Pie.TabIndex = 2;
            // 
            // tabComparison
            // 
            tabComparison.BackColor = Color.WhiteSmoke;
            tabComparison.Controls.Add(chartComparison);
            tabComparison.Controls.Add(panelCompStats);
            tabComparison.Location = new Point(4, 32);
            tabComparison.Margin = new Padding(3, 4, 3, 4);
            tabComparison.Name = "tabComparison";
            tabComparison.Size = new Size(1363, 817);
            tabComparison.TabIndex = 2;
            tabComparison.Text = "⚖ Comparison";
            // 
            // chartComparison
            // 
            chartComparison.Location = new Point(23, 187);
            chartComparison.Margin = new Padding(3, 4, 3, 4);
            chartComparison.Name = "chartComparison";
            chartComparison.Size = new Size(1303, 600);
            chartComparison.TabIndex = 0;
            // 
            // panelCompStats
            // 
            panelCompStats.BackColor = Color.White;
            panelCompStats.BorderStyle = BorderStyle.FixedSingle;
            panelCompStats.Controls.Add(lblCorrelation);
            panelCompStats.Controls.Add(lblDifference);
            panelCompStats.Location = new Point(23, 27);
            panelCompStats.Margin = new Padding(3, 4, 3, 4);
            panelCompStats.Name = "panelCompStats";
            panelCompStats.Size = new Size(1303, 133);
            panelCompStats.TabIndex = 1;
            // 
            // lblCorrelation
            // 
            lblCorrelation.AutoSize = true;
            lblCorrelation.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCorrelation.ForeColor = Color.FromArgb(41, 128, 185);
            lblCorrelation.Location = new Point(23, 27);
            lblCorrelation.Name = "lblCorrelation";
            lblCorrelation.Size = new Size(204, 32);
            lblCorrelation.TabIndex = 0;
            lblCorrelation.Text = "Correlation: N/A";
            // 
            // lblDifference
            // 
            lblDifference.AutoSize = true;
            lblDifference.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDifference.ForeColor = Color.FromArgb(230, 126, 34);
            lblDifference.Location = new Point(23, 73);
            lblDifference.Name = "lblDifference";
            lblDifference.Size = new Size(261, 32);
            lblDifference.TabIndex = 1;
            lblDifference.Text = "Average Difference: 0";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 933);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "StatisticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistical Analysis - Virtual Instrumentation";
            Load += StatisticsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLeft.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPOT1.ResumeLayout(false);
            panelPOT1Stats.ResumeLayout(false);
            tabPOT2.ResumeLayout(false);
            panelPOT2Stats.ResumeLayout(false);
            tabComparison.ResumeLayout(false);
            panelCompStats.ResumeLayout(false);
            panelCompStats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPOT1;
        private System.Windows.Forms.TabPage tabPOT2;
        private System.Windows.Forms.TabPage tabComparison;

        private System.Windows.Forms.Panel panelPOT1Stats;
        private LiveCharts.WinForms.SolidGauge gaugePOT1Min;
        private LiveCharts.WinForms.SolidGauge gaugePOT1Max;
        private LiveCharts.WinForms.SolidGauge gaugePOT1Avg;
        private LiveCharts.WinForms.SolidGauge gaugePOT1Count;
        private System.Windows.Forms.Label lblPOT1MinTitle;
        private System.Windows.Forms.Label lblPOT1MaxTitle;
        private System.Windows.Forms.Label lblPOT1AvgTitle;
        private System.Windows.Forms.Label lblPOT1CountTitle;
        private LiveCharts.WinForms.CartesianChart chartPOT1Line;
        private LiveCharts.WinForms.PieChart chartPOT1Pie;

        private System.Windows.Forms.Panel panelPOT2Stats;
        private LiveCharts.WinForms.SolidGauge gaugePOT2Min;
        private LiveCharts.WinForms.SolidGauge gaugePOT2Max;
        private LiveCharts.WinForms.SolidGauge gaugePOT2Avg;
        private LiveCharts.WinForms.SolidGauge gaugePOT2Count;
        private System.Windows.Forms.Label lblPOT2MinTitle;
        private System.Windows.Forms.Label lblPOT2MaxTitle;
        private System.Windows.Forms.Label lblPOT2AvgTitle;
        private System.Windows.Forms.Label lblPOT2CountTitle;
        private LiveCharts.WinForms.CartesianChart chartPOT2Line;
        private LiveCharts.WinForms.PieChart chartPOT2Pie;

        private LiveCharts.WinForms.CartesianChart chartComparison;
        private System.Windows.Forms.Panel panelCompStats;
        private System.Windows.Forms.Label lblCorrelation;
        private System.Windows.Forms.Label lblDifference;
        private Panel panelLeft;
        private Panel panelLeftBlue;
        private Panel panelLeftSky;
        private Panel panelLeftGreen;
    }
}