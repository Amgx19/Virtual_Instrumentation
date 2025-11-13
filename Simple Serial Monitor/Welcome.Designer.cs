namespace Simple_Serial_Monitor
{
    partial class Welcome
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            lblTitle = new Label();
            lblSubtitle = new Label();
            progressBar1 = new ProgressBar();
            lblLoading = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            timerFadeIn = new System.Windows.Forms.Timer(components);
            timerFadeOut = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(303, 145);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(308, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Graduation Project ";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(163, 199);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(604, 68);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Virtual Instormintions";
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = SystemColors.MenuHighlight;
            progressBar1.Location = new Point(134, 490);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(666, 29);
            progressBar1.TabIndex = 2;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Location = new Point(134, 467);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(63, 20);
            lblLoading.TabIndex = 3;
            lblLoading.Text = "Loading";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(671, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 78);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F);
            label1.Location = new Point(617, 539);
            label1.Name = "label1";
            label1.Size = new Size(183, 17);
            label1.TabIndex = 6;
            label1.Text = "Othman Al-Amine 443047358";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F);
            label2.Location = new Point(378, 539);
            label2.Name = "label2";
            label2.Size = new Size(163, 17);
            label2.TabIndex = 7;
            label2.Text = "Amjad Zakaria 443047268";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F);
            label3.Location = new Point(134, 539);
            label3.Name = "label3";
            label3.Size = new Size(150, 17);
            label3.TabIndex = 8;
            label3.Text = "Rayan Thani 443047360";
            // 
            // panel1
            // 
            panel1.BackColor = Color.YellowGreen;
            panel1.Location = new Point(58, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(34, 559);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 150, 212);
            panel2.Location = new Point(34, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(58, 559);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 62, 139);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(47, 559);
            panel3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(359, 283);
            label4.Name = "label4";
            label4.Size = new Size(182, 38);
            label4.TabIndex = 12;
            label4.Text = "2025 - 2026";
            // 
            // timerFadeIn
            // 
            timerFadeIn.Tick += timerFadeIn_Tick;
            // 
            // timerFadeOut
            // 
            timerFadeOut.Tick += timerFadeOut_Tick;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(872, 583);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblLoading);
            Controls.Add(progressBar1);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            Load += Welcome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private ProgressBar progressBar1;
        private Label lblLoading;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private System.Windows.Forms.Timer timerFadeIn;
        private System.Windows.Forms.Timer timerFadeOut;
    }
}