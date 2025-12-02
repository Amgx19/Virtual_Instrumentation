namespace Virtual_Instrumentation
{
    partial class WelcomeForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            timer1 = new System.Windows.Forms.Timer(components);
            timerFadeIn = new System.Windows.Forms.Timer(components);
            timerFadeOut = new System.Windows.Forms.Timer(components);
            panelMain = new Panel();
            pictureBox1 = new PictureBox();
            panelContent = new Panel();
            lblProjectTitle = new Label();
            lblMainTitle = new Label();
            lblYear = new Label();
            panelProgress = new Panel();
            progressBarFill = new Panel();
            lblLoading = new Label();
            lblPercent = new Label();
            panelStudents = new Panel();
            lblStudent1 = new Label();
            lblStudent2 = new Label();
            lblStudent3 = new Label();
            panelLeftDecoration = new Panel();
            panelBlue = new Panel();
            panelSkyBlue = new Panel();
            panelGreen = new Panel();
            panelTopDecoration = new Panel();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContent.SuspendLayout();
            panelProgress.SuspendLayout();
            panelStudents.SuspendLayout();
            panelLeftDecoration.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // timerFadeIn
            // 
            timerFadeIn.Interval = 30;
            timerFadeIn.Tick += timerFadeIn_Tick;
            // 
            // timerFadeOut
            // 
            timerFadeOut.Interval = 30;
            timerFadeOut.Tick += timerFadeOut_Tick;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(pictureBox1);
            panelMain.Controls.Add(panelContent);
            panelMain.Controls.Add(panelLeftDecoration);
            panelMain.Controls.Add(panelTopDecoration);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1000, 600);
            panelMain.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.شعار_الجامعة_هندسة;
            pictureBox1.Location = new Point(156, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(744, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(lblProjectTitle);
            panelContent.Controls.Add(lblMainTitle);
            panelContent.Controls.Add(lblYear);
            panelContent.Controls.Add(panelProgress);
            panelContent.Controls.Add(panelStudents);
            panelContent.Location = new Point(120, 80);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(860, 500);
            panelContent.TabIndex = 0;
            // 
            // lblProjectTitle
            // 
            lblProjectTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblProjectTitle.ForeColor = Color.FromArgb(42, 65, 142);
            lblProjectTitle.Location = new Point(50, 80);
            lblProjectTitle.Name = "lblProjectTitle";
            lblProjectTitle.Size = new Size(760, 45);
            lblProjectTitle.TabIndex = 0;
            lblProjectTitle.Text = "Graduation Project";
            lblProjectTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMainTitle
            // 
            lblMainTitle.Font = new Font("Segoe UI", 38F, FontStyle.Bold);
            lblMainTitle.ForeColor = Color.FromArgb(42, 65, 142);
            lblMainTitle.Location = new Point(50, 135);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(760, 90);
            lblMainTitle.TabIndex = 1;
            lblMainTitle.Text = "Virtual Instrumentation";
            lblMainTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            lblYear.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblYear.ForeColor = Color.FromArgb(149, 194, 65);
            lblYear.Location = new Point(50, 235);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(760, 40);
            lblYear.TabIndex = 2;
            lblYear.Text = "2025 - 2026";
            lblYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelProgress
            // 
            panelProgress.Controls.Add(progressBarFill);
            panelProgress.Controls.Add(lblLoading);
            panelProgress.Controls.Add(lblPercent);
            panelProgress.Location = new Point(150, 310);
            panelProgress.Name = "panelProgress";
            panelProgress.Size = new Size(560, 80);
            panelProgress.TabIndex = 3;
            // 
            // progressBarFill
            // 
            progressBarFill.BackColor = Color.FromArgb(30, 58, 138);
            progressBarFill.Location = new Point(0, 40);
            progressBarFill.Name = "progressBarFill";
            progressBarFill.Size = new Size(0, 8);
            progressBarFill.TabIndex = 0;
            // 
            // lblLoading
            // 
            lblLoading.Font = new Font("Segoe UI", 12F);
            lblLoading.ForeColor = Color.FromArgb(100, 116, 139);
            lblLoading.Location = new Point(0, 0);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(560, 30);
            lblLoading.TabIndex = 1;
            lblLoading.Text = "Loading System...";
            lblLoading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPercent
            // 
            lblPercent.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPercent.ForeColor = Color.FromArgb(42, 65, 142);
            lblPercent.Location = new Point(0, 50);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(560, 30);
            lblPercent.TabIndex = 2;
            lblPercent.Text = "0%";
            lblPercent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelStudents
            // 
            panelStudents.Controls.Add(lblStudent1);
            panelStudents.Controls.Add(lblStudent2);
            panelStudents.Controls.Add(lblStudent3);
            panelStudents.Location = new Point(50, 420);
            panelStudents.Name = "panelStudents";
            panelStudents.Size = new Size(760, 50);
            panelStudents.TabIndex = 4;
            // 
            // lblStudent1
            // 
            lblStudent1.Font = new Font("Segoe UI", 10F);
            lblStudent1.ForeColor = Color.FromArgb(100, 116, 139);
            lblStudent1.Location = new Point(0, 10);
            lblStudent1.Name = "lblStudent1";
            lblStudent1.Size = new Size(250, 30);
            lblStudent1.TabIndex = 0;
            lblStudent1.Text = "Rayan Thani 443047360";
            lblStudent1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStudent2
            // 
            lblStudent2.Font = new Font("Segoe UI", 10F);
            lblStudent2.ForeColor = Color.FromArgb(100, 116, 139);
            lblStudent2.Location = new Point(255, 10);
            lblStudent2.Name = "lblStudent2";
            lblStudent2.Size = new Size(250, 30);
            lblStudent2.TabIndex = 1;
            lblStudent2.Text = "Amjad Zakaria 443047268";
            lblStudent2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStudent3
            // 
            lblStudent3.Font = new Font("Segoe UI", 10F);
            lblStudent3.ForeColor = Color.FromArgb(100, 116, 139);
            lblStudent3.Location = new Point(510, 10);
            lblStudent3.Name = "lblStudent3";
            lblStudent3.Size = new Size(250, 30);
            lblStudent3.TabIndex = 2;
            lblStudent3.Text = "Othman Al-Amein 443047358";
            lblStudent3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLeftDecoration
            // 
            panelLeftDecoration.Controls.Add(panelBlue);
            panelLeftDecoration.Controls.Add(panelSkyBlue);
            panelLeftDecoration.Controls.Add(panelGreen);
            panelLeftDecoration.Dock = DockStyle.Left;
            panelLeftDecoration.Location = new Point(0, 8);
            panelLeftDecoration.Name = "panelLeftDecoration";
            panelLeftDecoration.Size = new Size(80, 592);
            panelLeftDecoration.TabIndex = 1;
            // 
            // panelBlue
            // 
            panelBlue.BackColor = Color.FromArgb(42, 65, 142);
            panelBlue.Dock = DockStyle.Left;
            panelBlue.Location = new Point(55, 0);
            panelBlue.Name = "panelBlue";
            panelBlue.Size = new Size(25, 592);
            panelBlue.TabIndex = 0;
            // 
            // panelSkyBlue
            // 
            panelSkyBlue.BackColor = Color.FromArgb(34, 151, 213);
            panelSkyBlue.Dock = DockStyle.Left;
            panelSkyBlue.Location = new Point(30, 0);
            panelSkyBlue.Name = "panelSkyBlue";
            panelSkyBlue.Size = new Size(25, 592);
            panelSkyBlue.TabIndex = 1;
            // 
            // panelGreen
            // 
            panelGreen.BackColor = Color.FromArgb(149, 194, 65);
            panelGreen.Dock = DockStyle.Left;
            panelGreen.Location = new Point(0, 0);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(30, 592);
            panelGreen.TabIndex = 2;
            // 
            // panelTopDecoration
            // 
            panelTopDecoration.BackColor = Color.FromArgb(42, 65, 142);
            panelTopDecoration.Dock = DockStyle.Top;
            panelTopDecoration.Location = new Point(0, 0);
            panelTopDecoration.Name = "panelTopDecoration";
            panelTopDecoration.Size = new Size(1000, 8);
            panelTopDecoration.TabIndex = 2;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            Load += Welcome_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContent.ResumeLayout(false);
            panelProgress.ResumeLayout(false);
            panelStudents.ResumeLayout(false);
            panelLeftDecoration.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerFadeIn;
        private System.Windows.Forms.Timer timerFadeOut;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Panel progressBarFill;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Panel panelStudents;
        private System.Windows.Forms.Label lblStudent1;
        private System.Windows.Forms.Label lblStudent2;
        private System.Windows.Forms.Label lblStudent3;
        private System.Windows.Forms.Panel panelLeftDecoration;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelSkyBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelTopDecoration;
        private PictureBox pictureBox1;
    }
}