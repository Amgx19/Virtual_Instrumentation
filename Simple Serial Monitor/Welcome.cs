using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace Simple_Serial_Monitor
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            this.Opacity = 0; // نبدأ بشفافية صفر
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            // إعداد المؤقتين
            timerFadeIn.Interval = 30;
            timerFadeOut.Interval = 30;

            progressBar1.Value = 0;
            lblLoading.Text = "Loading... 0%";

            // نبدأ بتشغيل الدخول
            timerFadeIn.Start();
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05; // يزيد الشفافية تدريجيًا
            else
                timerFadeIn.Stop(); // توقف بعد ما يصير كامل الظهور
        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
                this.Opacity -= 0.05; // تقليل الشفافية تدريجيًا
            else
            {
                timerFadeOut.Stop();
                // بعد الانتهاء → فتح الفورم الرئيسي
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;
                lblLoading.Text = $"Loading... {progressBar1.Value}%";
            }
            else
            {
                timer1.Stop();
                timerFadeOut.Start(); // بعد الانتهاء من التحميل، نفعل الخروج
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // المستخدم ضغط "Start" بنفسه
            timerFadeOut.Start();
        }
    }
}

