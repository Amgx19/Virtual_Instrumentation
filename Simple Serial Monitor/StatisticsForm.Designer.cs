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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPOT1 = new System.Windows.Forms.TabPage();
            this.tabPOT2 = new System.Windows.Forms.TabPage();
            this.tabComparison = new System.Windows.Forms.TabPage();
            this.panelPOT1Stats = new System.Windows.Forms.Panel();
            this.lblPOT1Min = new System.Windows.Forms.Label();
            this.lblPOT1Max = new System.Windows.Forms.Label();
            this.lblPOT1Avg = new System.Windows.Forms.Label();
            this.lblPOT1Count = new System.Windows.Forms.Label();
            this.chartPOT1Line = new LiveCharts.WinForms.CartesianChart();
            this.chartPOT1Pie = new LiveCharts.WinForms.PieChart();
            this.gaugePOT1 = new LiveCharts.WinForms.SolidGauge();
            this.panelPOT2Stats = new System.Windows.Forms.Panel();
            this.lblPOT2Min = new System.Windows.Forms.Label();
            this.lblPOT2Max = new System.Windows.Forms.Label();
            this.lblPOT2Avg = new System.Windows.Forms.Label();
            this.lblPOT2Count = new System.Windows.Forms.Label();
            this.chartPOT2Line = new LiveCharts.WinForms.CartesianChart();
            this.chartPOT2Pie = new LiveCharts.WinForms.PieChart();
            this.gaugePOT2 = new LiveCharts.WinForms.SolidGauge();
            this.chartComparison = new LiveCharts.WinForms.CartesianChart();
            this.panelCompStats = new System.Windows.Forms.Panel();
            this.lblCorrelation = new System.Windows.Forms.Label();
            this.lblDifference = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPOT1.SuspendLayout();
            this.tabPOT2.SuspendLayout();
            this.tabComparison.SuspendLayout();
            this.panelPOT1Stats.SuspendLayout();
            this.panelPOT2Stats.SuspendLayout();
            this.panelCompStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Statistical Analysis";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(950, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1070, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✖ Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPOT1);
            this.tabControl1.Controls.Add(this.tabPOT2);
            this.tabControl1.Controls.Add(this.tabComparison);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 640);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPOT1
            // 
            this.tabPOT1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPOT1.Controls.Add(this.panelPOT1Stats);
            this.tabPOT1.Controls.Add(this.chartPOT1Line);
            this.tabPOT1.Controls.Add(this.chartPOT1Pie);
            this.tabPOT1.Controls.Add(this.gaugePOT1);
            this.tabPOT1.Location = new System.Drawing.Point(4, 26);
            this.tabPOT1.Name = "tabPOT1";
            this.tabPOT1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPOT1.Size = new System.Drawing.Size(1192, 610);
            this.tabPOT1.TabIndex = 0;
            this.tabPOT1.Text = "📊 POT1 Analysis";
            // 
            // tabPOT2
            // 
            this.tabPOT2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPOT2.Controls.Add(this.panelPOT2Stats);
            this.tabPOT2.Controls.Add(this.chartPOT2Line);
            this.tabPOT2.Controls.Add(this.chartPOT2Pie);
            this.tabPOT2.Controls.Add(this.gaugePOT2);
            this.tabPOT2.Location = new System.Drawing.Point(4, 26);
            this.tabPOT2.Name = "tabPOT2";
            this.tabPOT2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPOT2.Size = new System.Drawing.Size(1192, 610);
            this.tabPOT2.TabIndex = 1;
            this.tabPOT2.Text = "📊 POT2 Analysis";
            // 
            // tabComparison
            // 
            this.tabComparison.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabComparison.Controls.Add(this.chartComparison);
            this.tabComparison.Controls.Add(this.panelCompStats);
            this.tabComparison.Location = new System.Drawing.Point(4, 26);
            this.tabComparison.Name = "tabComparison";
            this.tabComparison.Size = new System.Drawing.Size(1192, 610);
            this.tabComparison.TabIndex = 2;
            this.tabComparison.Text = "⚖ Comparison";
            // 
            // panelPOT1Stats
            // 
            this.panelPOT1Stats.BackColor = System.Drawing.Color.White;
            this.panelPOT1Stats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPOT1Stats.Controls.Add(this.lblPOT1Min);
            this.panelPOT1Stats.Controls.Add(this.lblPOT1Max);
            this.panelPOT1Stats.Controls.Add(this.lblPOT1Avg);
            this.panelPOT1Stats.Controls.Add(this.lblPOT1Count);
            this.panelPOT1Stats.Location = new System.Drawing.Point(20, 20);
            this.panelPOT1Stats.Name = "panelPOT1Stats";
            this.panelPOT1Stats.Size = new System.Drawing.Size(700, 100);
            this.panelPOT1Stats.TabIndex = 0;
            // 
            // lblPOT1Min
            // 
            this.lblPOT1Min.AutoSize = true;
            this.lblPOT1Min.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPOT1Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblPOT1Min.Location = new System.Drawing.Point(15, 15);
            this.lblPOT1Min.Name = "lblPOT1Min";
            this.lblPOT1Min.Size = new System.Drawing.Size(79, 21);
            this.lblPOT1Min.TabIndex = 0;
            this.lblPOT1Min.Text = "Min: 0";
            // 
            // lblPOT1Max
            // 
            this.lblPOT1Max.AutoSize = true;
            this.lblPOT1Max.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPOT1Max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblPOT1Max.Location = new System.Drawing.Point(190, 15);
            this.lblPOT1Max.Name = "lblPOT1Max";
            this.lblPOT1Max.Size = new System.Drawing.Size(82, 21);
            this.lblPOT1Max.TabIndex = 1;
            this.lblPOT1Max.Text = "Max: 0";
            // 
            // lblPOT1Avg
            // 
            this.lblPOT1Avg.AutoSize = true;
            this.lblPOT1Avg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPOT1Avg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblPOT1Avg.Location = new System.Drawing.Point(380, 15);
            this.lblPOT1Avg.Name = "lblPOT1Avg";
            this.lblPOT1Avg.Size = new System.Drawing.Size(113, 21);
            this.lblPOT1Avg.TabIndex = 2;
            this.lblPOT1Avg.Text = "Average: 0";
            // 
            // lblPOT1Count
            // 
            this.lblPOT1Count.AutoSize = true;
            this.lblPOT1Count.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPOT1Count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.lblPOT1Count.Location = new System.Drawing.Point(15, 55);
            this.lblPOT1Count.Name = "lblPOT1Count";
            this.lblPOT1Count.Size = new System.Drawing.Size(145, 21);
            this.lblPOT1Count.TabIndex = 3;
            this.lblPOT1Count.Text = "Total Records: 0";
            // 
            // chartPOT1Line
            // 
            this.chartPOT1Line.Location = new System.Drawing.Point(20, 140);
            this.chartPOT1Line.Name = "chartPOT1Line";
            this.chartPOT1Line.Size = new System.Drawing.Size(700, 250);
            this.chartPOT1Line.TabIndex = 1;
            this.chartPOT1Line.Text = "POT1 Trend";
            // 
            // chartPOT1Pie
            // 
            this.chartPOT1Pie.Location = new System.Drawing.Point(20, 410);
            this.chartPOT1Pie.Name = "chartPOT1Pie";
            this.chartPOT1Pie.Size = new System.Drawing.Size(450, 180);
            this.chartPOT1Pie.TabIndex = 2;
            this.chartPOT1Pie.Text = "POT1 Distribution";
            // 
            // gaugePOT1
            // 
            this.gaugePOT1.Location = new System.Drawing.Point(750, 20);
            this.gaugePOT1.Name = "gaugePOT1";
            this.gaugePOT1.Size = new System.Drawing.Size(400, 250);
            this.gaugePOT1.TabIndex = 3;
            this.gaugePOT1.Text = "POT1 Average";
            // 
            // panelPOT2Stats
            // 
            this.panelPOT2Stats.BackColor = System.Drawing.Color.White;
            this.panelPOT2Stats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPOT2Stats.Controls.Add(this.lblPOT2Min);
            this.panelPOT2Stats.Controls.Add(this.lblPOT2Max);
            this.panelPOT2Stats.Controls.Add(this.lblPOT2Avg);
            this.panelPOT2Stats.Controls.Add(this.lblPOT2Count);
            this.panelPOT2Stats.Location = new System.Drawing.Point(20, 20);
            this.panelPOT2Stats.Name = "panelPOT2Stats";
            this.panelPOT2Stats.Size = new System.Drawing.Size(700, 100);
            this.panelPOT2Stats.TabIndex = 0;
            // 
            // lblPOT2Min
            // 
            this.lblPOT2Min.AutoSize = true;
            this.lblPOT2Min.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPOT2Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblPOT2Min.Location = new System.Drawing.Point(15, 15);
            this.lblPOT2Min.Name = "lblPOT2Min";
            this.lblPOT2Min.Size = new System.Drawing.Size(79, 21);
            this.lblPOT2Min.TabIndex = 0;
            this.lblPOT2Min.Text = "Min: 0";
            // 
            // lblPOT2Max
            // 
            this.lblPOT2Max.AutoSize = true;
            this.lblPOT2Max.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPOT2Max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblPOT2Max.Location = new System.Drawing.Point(190, 15);
            this.lblPOT2Max.Name = "lblPOT2Max";
            this.lblPOT2Max.Size = new System.Drawing.Size(82, 21);
            this.lblPOT2Max.TabIndex = 1;
            this.lblPOT2Max.Text = "Max: 0";
            // 
            // lblPOT2Avg
            // 
            this.lblPOT2Avg.AutoSize = true;
            this.lblPOT2Avg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPOT2Avg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblPOT2Avg.Location = new System.Drawing.Point(380, 15);
            this.lblPOT2Avg.Name = "lblPOT2Avg";
            this.lblPOT2Avg.Size = new System.Drawing.Size(113, 21);
            this.lblPOT2Avg.TabIndex = 2;
            this.lblPOT2Avg.Text = "Average: 0";
            // 
            // lblPOT2Count
            // 
            this.lblPOT2Count.AutoSize = true;
            this.lblPOT2Count.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPOT2Count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.lblPOT2Count.Location = new System.Drawing.Point(15, 55);
            this.lblPOT2Count.Name = "lblPOT2Count";
            this.lblPOT2Count.Size = new System.Drawing.Size(145, 21);
            this.lblPOT2Count.TabIndex = 3;
            this.lblPOT2Count.Text = "Total Records: 0";
            // 
            // chartPOT2Line
            // 
            this.chartPOT2Line.Location = new System.Drawing.Point(20, 140);
            this.chartPOT2Line.Name = "chartPOT2Line";
            this.chartPOT2Line.Size = new System.Drawing.Size(700, 250);
            this.chartPOT2Line.TabIndex = 1;
            this.chartPOT2Line.Text = "POT2 Trend";
            // 
            // chartPOT2Pie
            // 
            this.chartPOT2Pie.Location = new System.Drawing.Point(20, 410);
            this.chartPOT2Pie.Name = "chartPOT2Pie";
            this.chartPOT2Pie.Size = new System.Drawing.Size(450, 180);
            this.chartPOT2Pie.TabIndex = 2;
            this.chartPOT2Pie.Text = "POT2 Distribution";
            // 
            // gaugePOT2
            // 
            this.gaugePOT2.Location = new System.Drawing.Point(750, 20);
            this.gaugePOT2.Name = "gaugePOT2";
            this.gaugePOT2.Size = new System.Drawing.Size(400, 250);
            this.gaugePOT2.TabIndex = 3;
            this.gaugePOT2.Text = "POT2 Average";
            // 
            // chartComparison
            // 
            this.chartComparison.Location = new System.Drawing.Point(20, 140);
            this.chartComparison.Name = "chartComparison";
            this.chartComparison.Size = new System.Drawing.Size(1140, 450);
            this.chartComparison.TabIndex = 0;
            this.chartComparison.Text = "POT1 vs POT2 Comparison";
            // 
            // panelCompStats
            // 
            this.panelCompStats.BackColor = System.Drawing.Color.White;
            this.panelCompStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCompStats.Controls.Add(this.lblCorrelation);
            this.panelCompStats.Controls.Add(this.lblDifference);
            this.panelCompStats.Location = new System.Drawing.Point(20, 20);
            this.panelCompStats.Name = "panelCompStats";
            this.panelCompStats.Size = new System.Drawing.Size(1140, 100);
            this.panelCompStats.TabIndex = 1;
            // 
            // lblCorrelation
            // 
            this.lblCorrelation.AutoSize = true;
            this.lblCorrelation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCorrelation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCorrelation.Location = new System.Drawing.Point(20, 20);
            this.lblCorrelation.Name = "lblCorrelation";
            this.lblCorrelation.Size = new System.Drawing.Size(194, 25);
            this.lblCorrelation.TabIndex = 0;
            this.lblCorrelation.Text = "Correlation: N/A";
            // 
            // lblDifference
            // 
            this.lblDifference.AutoSize = true;
            this.lblDifference.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDifference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.lblDifference.Location = new System.Drawing.Point(20, 55);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(267, 25);
            this.lblDifference.TabIndex = 1;
            this.lblDifference.Text = "Average Difference: 0";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistical Analysis - Virtual Instrumentation";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPOT1.ResumeLayout(false);
            this.tabPOT2.ResumeLayout(false);
            this.tabComparison.ResumeLayout(false);
            this.panelPOT1Stats.ResumeLayout(false);
            this.panelPOT1Stats.PerformLayout();
            this.panelPOT2Stats.ResumeLayout(false);
            this.panelPOT2Stats.PerformLayout();
            this.panelCompStats.ResumeLayout(false);
            this.panelCompStats.PerformLayout();
            this.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblPOT1Min;
        private System.Windows.Forms.Label lblPOT1Max;
        private System.Windows.Forms.Label lblPOT1Avg;
        private System.Windows.Forms.Label lblPOT1Count;
        private LiveCharts.WinForms.CartesianChart chartPOT1Line;
        private LiveCharts.WinForms.PieChart chartPOT1Pie;
        private LiveCharts.WinForms.SolidGauge gaugePOT1;
        private System.Windows.Forms.Panel panelPOT2Stats;
        private System.Windows.Forms.Label lblPOT2Min;
        private System.Windows.Forms.Label lblPOT2Max;
        private System.Windows.Forms.Label lblPOT2Avg;
        private System.Windows.Forms.Label lblPOT2Count;
        private LiveCharts.WinForms.CartesianChart chartPOT2Line;
        private LiveCharts.WinForms.PieChart chartPOT2Pie;
        private LiveCharts.WinForms.SolidGauge gaugePOT2;
        private LiveCharts.WinForms.CartesianChart chartComparison;
        private System.Windows.Forms.Panel panelCompStats;
        private System.Windows.Forms.Label lblCorrelation;
        private System.Windows.Forms.Label lblDifference;
    }
}