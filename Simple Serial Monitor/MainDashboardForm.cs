using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.Data.Sqlite;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Simple_Serial_Monitor
{
    public partial class MainDashboardForm : Form
    {
        SerialPort serialPort = new SerialPort();
        string latestData = "";
        private bool SimulationMode = false;
        private Random rand = new Random();
        ChartValues<int> chartValues1 = new ChartValues<int>();
        ChartValues<int> chartValues2 = new ChartValues<int>();

        private string _connString = "Data Source=data.db";

        // عدادات للتحكم بسرعة الإدخال
        private int dbCounter = 0;
        private int chart2Counter = 0;

        public MainDashboardForm()
        {
            InitializeComponent();
            InitDatabase();
        }

        private void InitDatabase()
        {
            using var conn = new SqliteConnection(_connString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS readings(
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    pot1 INTEGER,
                    pot2 INTEGER,
                    raw TEXT,
                    timestamp DATETIME DEFAULT CURRENT_TIMESTAMP
                );";
            cmd.ExecuteNonQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (string port in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(port);
            }
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

            serialPort.DataReceived += SerialPort_DataReceived;

            System.Windows.Forms.Timer uiTimer = new System.Windows.Forms.Timer();
            uiTimer.Interval = 1000;
            uiTimer.Tick += UiTimer_Tick;
            uiTimer.Start();

            solidGauge1.Value = 0;
            solidGauge1.To = 1023;
            solidGauge1.FromColor = System.Windows.Media.Color.FromRgb(42, 65, 142);
            solidGauge1.ToColor = System.Windows.Media.Color.FromRgb(149, 194, 65);

            solidGauge2.Value = 0;
            solidGauge2.To = 1023;
            solidGauge2.FromColor = System.Windows.Media.Color.FromRgb(42, 65, 142);
            solidGauge2.ToColor = System.Windows.Media.Color.FromRgb(149, 194, 65);

            SimulationMode = false;
            btnSimulation.Text = "Start Simulation";

            textBox2.Text = "POT1: 0 | POT2: 0";
        }

        private void open_btn(object sender, EventArgs e)
        {
            if (SimulationMode)
            {
                MessageBox.Show("⚠ Simulation Mode Active - No COM Port Opened", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                serialPort.PortName = comboBox1.Text;
                serialPort.BaudRate = 9600;
                serialPort.Parity = Parity.None;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.NewLine = "\n";

                serialPort.Open();
                MessageBox.Show($"✅ Connected to {comboBox1.Text}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SimulationMode)
            {
                MessageBox.Show("⚠ Simulation Mode Active - No COM Port To Close", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    latestData = "";
                    MessageBox.Show("✅ Connection Closed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("⚠ Port is already closed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (SimulationMode) return;
            try
            {
                latestData = serialPort.ReadLine().Trim();
            }
            catch { }
        }

        private void UiTimer_Tick(object? sender, EventArgs e)
        {
            if (!SimulationMode && !serialPort.IsOpen)
            {
                return;
            }

            int val1, val2;

            if (SimulationMode)
            {
                val1 = rand.Next(0, 1024);
                val2 = rand.Next(0, 1024);
            }
            else
            {
                if (!string.IsNullOrEmpty(latestData) && latestData.Length >= 8)
                {
                    string pot1 = latestData.Substring(0, 4);
                    string pot2 = latestData.Substring(4, 4);

                    if (!int.TryParse(pot1, out val1)) val1 = 0;
                    if (!int.TryParse(pot2, out val2)) val2 = 0;
                }
                else
                {
                    return;
                }
            }

            // تحديث الشارت ببطء
            chart2Counter++;
            if (chart2Counter >= 2)
            {
                chartValues1.Add(val1);
                if (chartValues1.Count > 30) chartValues1.RemoveAt(0);

                chartValues2.Add(val2);
                if (chartValues2.Count > 30) chartValues2.RemoveAt(0);

                // تنظيف المحاور
                cartesianChart1.AxisX.Clear();
                cartesianChart1.AxisY.Clear();

                cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "POT1",
                        Values = chartValues1,
                        Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(42, 65, 142)),
                        Fill = System.Windows.Media.Brushes.Transparent,
                        StrokeThickness = 2
                    }
                };

                cartesianChart1.AxisY.Add(new Axis { MinValue = 0, MaxValue = 1023 });

                // تنظيف المحاور
                cartesianChart2.AxisX.Clear();
                cartesianChart2.AxisY.Clear();

                cartesianChart2.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "POT2",
                        Values = chartValues2,
                        Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(149, 194, 65)),
                        Fill = System.Windows.Media.Brushes.Transparent,
                        StrokeThickness = 2
                    }
                };

                cartesianChart2.AxisY.Add(new Axis { MinValue = 0, MaxValue = 1023 });

                chart2Counter = 0;
            }

            // تحديث الواجهة
            textBox2.Text = $"POT1: {val1} | POT2: {val2}";
            solidGauge1.Value = val1;
            solidGauge2.Value = val2;

            // تخزين في الداتابيس
            dbCounter++;
            if (dbCounter >= 3)
            {
                using (var conn = new SqliteConnection(_connString))
                {
                    conn.Open();
                    using var cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO readings(pot1, pot2, raw) VALUES ($p1, $p2, $raw)";
                    cmd.Parameters.AddWithValue("$p1", val1);
                    cmd.Parameters.AddWithValue("$p2", val2);
                    cmd.Parameters.AddWithValue("$raw", $"{val1:D4}{val2:D4}");
                    cmd.ExecuteNonQuery();
                }
                LoadDataGrids();
                dbCounter = 0;
            }
        }

        private void LoadDataGrids()
        {
            using var conn = new SqliteConnection(_connString);
            conn.Open();

            using (var cmd1 = conn.CreateCommand())
            {
                cmd1.CommandText = "SELECT id, pot1, timestamp FROM readings ORDER BY id DESC LIMIT 20";
                using var reader1 = cmd1.ExecuteReader();
                var table1 = new System.Data.DataTable();
                table1.Load(reader1);
                dataGridView1.DataSource = table1;
            }

            using (var cmd2 = conn.CreateCommand())
            {
                cmd2.CommandText = "SELECT id, pot2, timestamp FROM readings ORDER BY id DESC LIMIT 20";
                using var reader2 = cmd2.ExecuteReader();
                var table2 = new System.Data.DataTable();
                table2.Load(reader2);
                dataGridView2.DataSource = table2;
            }
        }

        private void btnSimulation_Click(object sender, EventArgs e)
        {
            SimulationMode = !SimulationMode;
            if (SimulationMode)
            {
                btnSimulation.Text = "Stop Simulation";
                btnSimulation.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
                MessageBox.Show("✅ Simulation Mode Enabled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnSimulation.Text = "Start Simulation";
                btnSimulation.BackColor = System.Drawing.Color.FromArgb(42, 65, 142);
                MessageBox.Show("❌ Simulation Mode Disabled - Real Data Mode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("⚠ Are you sure you want to clear all data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var con = new SqliteConnection(_connString))
                {
                    con.Open();
                    string sql = "DROP TABLE readings;";
                    using (var cmd = new SqliteCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    InitDatabase();
                }

                solidGauge1.Value = 0;
                solidGauge2.Value = 0;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();
                dataGridView2.Refresh();

                MessageBox.Show("✅ All data cleared from database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm statsForm = new StatisticsForm();
            statsForm.ShowDialog();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            DatabaseViewerForm dbForm = new DatabaseViewerForm();
            dbForm.ShowDialog();
        }
    }
}