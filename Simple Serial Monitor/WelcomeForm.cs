using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;


namespace Virtual_Instrumentation
{
    public partial class WelcomeForm : Form
    {
        private int progressValue = 0;

        public WelcomeForm()
        {
            InitializeComponent();
            this.Opacity = 0;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            // إعداد المؤقتات
            timerFadeIn.Interval = 30;
            timerFadeOut.Interval = 30;
            timer1.Interval = 40;

            // البداية
            progressValue = 0;
            progressBarFill.Width = 0;
            lblPercent.Text = "0%";
            lblLoading.Text = "Initializing System...";

            // بدء تأثير الظهور
            timerFadeIn.Start();
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                timerFadeIn.Stop();
                timer1.Start(); // بدء شريط التقدم
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressValue < 100)
            {
                progressValue += 2;

                // تحديث شريط التقدم (560 عرض الشريط الكامل)
                progressBarFill.Width = (int)(560 * (progressValue / 100.0));

                // تحديث النسبة المئوية
                lblPercent.Text = $"{progressValue}%";

                // تحديث نص التحميل حسب التقدم
                if (progressValue < 30)
                    lblLoading.Text = "Loading Components...";
                else if (progressValue < 60)
                    lblLoading.Text = "Initializing Hardware...";
                else if (progressValue < 90)
                    lblLoading.Text = "Preparing Interface...";
                else
                    lblLoading.Text = "Almost Ready...";
            }
            else
            {
                timer1.Stop();
                lblLoading.Text = "Loading Complete!";

                // انتظر نصف ثانية ثم ابدأ الاختفاء
                System.Threading.Tasks.Task.Delay(500).ContinueWith(t =>
                {
                    if (this.IsHandleCreated)
                    {
                        this.Invoke(new Action(() => timerFadeOut.Start()));
                    }
                });
            }
        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                timerFadeOut.Stop();

                // فتح الفورم الرئيسي
                MainDashboardForm mainForm = new MainDashboardForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}