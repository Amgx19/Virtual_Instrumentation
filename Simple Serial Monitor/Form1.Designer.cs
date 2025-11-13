namespace Simple_Serial_Monitor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnOpen_Click = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button4 = new Button();
            textBox2 = new TextBox();
            solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            groupBox3 = new GroupBox();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            groupBox4 = new GroupBox();
            solidGauge2 = new LiveCharts.WinForms.SolidGauge();
            cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            btnSimulation = new Button();
            btnClearData = new Button();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 29);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Port: ";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(55, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // btnOpen_Click
            // 
            btnOpen_Click.Location = new Point(317, 25);
            btnOpen_Click.Name = "btnOpen_Click";
            btnOpen_Click.Size = new Size(94, 29);
            btnOpen_Click.TabIndex = 2;
            btnOpen_Click.Text = "Open";
            btnOpen_Click.UseVisualStyleBackColor = true;
            btnOpen_Click.Click += open_btn;
            // 
            // button2
            // 
            button2.Location = new Point(417, 25);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(516, 58);
            textBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(428, 91);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Send";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(22, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 134);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Send Here";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(556, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(528, 134);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Receive Here";
            // 
            // button4
            // 
            button4.Location = new Point(428, 91);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Receive";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 26);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(516, 59);
            textBox2.TabIndex = 4;
            // 
            // solidGauge1
            // 
            solidGauge1.Location = new Point(7, 35);
            solidGauge1.Name = "solidGauge1";
            solidGauge1.Size = new Size(250, 125);
            solidGauge1.TabIndex = 12;
            solidGauge1.Text = "solidGauge1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(515, 251);
            dataGridView1.TabIndex = 13;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 176);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(516, 251);
            dataGridView2.TabIndex = 15;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cartesianChart1);
            groupBox3.Controls.Add(solidGauge1);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(22, 223);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(528, 433);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "POT1";
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(275, 26);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(247, 143);
            cartesianChart1.TabIndex = 14;
            cartesianChart1.Text = "cartesianChart2";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(solidGauge2);
            groupBox4.Controls.Add(cartesianChart2);
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(556, 223);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(528, 433);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "POT2";
            // 
            // solidGauge2
            // 
            solidGauge2.Location = new Point(6, 26);
            solidGauge2.Name = "solidGauge2";
            solidGauge2.Size = new Size(250, 125);
            solidGauge2.TabIndex = 20;
            solidGauge2.Text = "solidGauge2";
            // 
            // cartesianChart2
            // 
            cartesianChart2.Location = new Point(275, 26);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(247, 143);
            cartesianChart2.TabIndex = 19;
            cartesianChart2.Text = "cartesianChart1";
            // 
            // btnSimulation
            // 
            btnSimulation.Location = new Point(131, 20);
            btnSimulation.Name = "btnSimulation";
            btnSimulation.Size = new Size(151, 29);
            btnSimulation.TabIndex = 18;
            btnSimulation.Text = " Start Simulation";
            btnSimulation.UseVisualStyleBackColor = true;
            btnSimulation.Click += btnSimulation_Click;
            // 
            // btnClearData
            // 
            btnClearData.Location = new Point(317, 20);
            btnClearData.Name = "btnClearData";
            btnClearData.Size = new Size(151, 29);
            btnClearData.TabIndex = 19;
            btnClearData.Text = "Clear Data";
            btnClearData.UseVisualStyleBackColor = true;
            btnClearData.Click += btnClearData_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(comboBox1);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(btnOpen_Click);
            groupBox5.Controls.Add(button2);
            groupBox5.Location = new Point(22, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(528, 65);
            groupBox5.TabIndex = 20;
            groupBox5.TabStop = false;
            groupBox5.Text = "Port Settings";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnClearData);
            groupBox6.Controls.Add(btnSimulation);
            groupBox6.Location = new Point(556, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(529, 65);
            groupBox6.TabIndex = 21;
            groupBox6.TabStop = false;
            groupBox6.Text = "Data Settings";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1097, 671);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Virtual Instrumentation";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button btnOpen_Click;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button4;
        private TextBox textBox2;
        private LiveCharts.WinForms.SolidGauge solidGauge1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnSimulation;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private Button btnClearData;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private LiveCharts.WinForms.SolidGauge solidGauge2;
    }
}
