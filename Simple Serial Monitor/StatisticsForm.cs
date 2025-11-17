using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;
using MediaBrushes = System.Windows.Media.Brushes;

namespace Simple_Serial_Monitor
{
    public partial class StatisticsForm : Form
    {
        private string _connString = "Data Source=data.db";
        private List<int> pot1Values = new List<int>();
        private List<int> pot2Values = new List<int>();

        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllData();
            MessageBox.Show("✅ Data Refreshed Successfully!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAllData()
        {
            pot1Values.Clear();
            pot2Values.Clear();

            try
            {
                using var conn = new SqliteConnection(_connString);
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT pot1, pot2 FROM readings ORDER BY id ASC";
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pot1Values.Add(reader.GetInt32(0));
                    pot2Values.Add(reader.GetInt32(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pot1Values.Count == 0)
            {
                MessageBox.Show("⚠ No data found in database!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // تحديث POT1
            UpdatePOT1Statistics();
            UpdatePOT1Charts();

            // تحديث POT2
            UpdatePOT2Statistics();
            UpdatePOT2Charts();

            // تحديث المقارنة
            UpdateComparisonChart();
        }

        // ========== POT1 Statistics ==========
        private void UpdatePOT1Statistics()
        {
            if (pot1Values.Count == 0) return;

            int min = pot1Values.Min();
            int max = pot1Values.Max();
            double avg = pot1Values.Average();
            int count = pot1Values.Count;

            // تحديث Gauge للـ Min (أزرق)
            gaugePOT1Min.From = 0;
            gaugePOT1Min.To = 1023;
            gaugePOT1Min.Value = min;
            gaugePOT1Min.Uses360Mode = false;
            gaugePOT1Min.FromColor = System.Windows.Media.Color.FromRgb(41, 128, 185);
            gaugePOT1Min.ToColor = System.Windows.Media.Color.FromRgb(52, 152, 219);

            // تحديث Gauge للـ Max (أحمر)
            gaugePOT1Max.From = 0;
            gaugePOT1Max.To = 1023;
            gaugePOT1Max.Value = max;
            gaugePOT1Max.Uses360Mode = false;
            gaugePOT1Max.FromColor = System.Windows.Media.Color.FromRgb(192, 57, 43);
            gaugePOT1Max.ToColor = System.Windows.Media.Color.FromRgb(231, 76, 60);

            // تحديث Gauge للـ Average (أخضر)
            gaugePOT1Avg.From = 0;
            gaugePOT1Avg.To = 1023;
            gaugePOT1Avg.Value = Math.Round(avg, 0);
            gaugePOT1Avg.Uses360Mode = false;
            gaugePOT1Avg.FromColor = System.Windows.Media.Color.FromRgb(39, 174, 96);
            gaugePOT1Avg.ToColor = System.Windows.Media.Color.FromRgb(46, 204, 113);

            // تحديث Gauge للـ Count (بنفسجي) - نسبة مئوية من 1000
            double countPercent = Math.Min(count, 1000);
            gaugePOT1Count.From = 0;
            gaugePOT1Count.To = 100;
            gaugePOT1Count.Value = countPercent;
            gaugePOT1Count.Uses360Mode = false;
            gaugePOT1Count.FromColor = System.Windows.Media.Color.FromRgb(142, 68, 173);
            gaugePOT1Count.ToColor = System.Windows.Media.Color.FromRgb(155, 89, 182);
            gaugePOT1Count.LabelFormatter = val => count.ToString();
        }

        private void UpdatePOT1Charts()
        {
            if (pot1Values.Count == 0) return;

            // 🟢 تنظيف المحاور قبل الإضافة
            chartPOT1Line.AxisX.Clear();
            chartPOT1Line.AxisY.Clear();
            chartPOT1Line.Refresh();

            // Line Chart - آخر 50 قراءة
            var recentValues = pot1Values.Skip(Math.Max(0, pot1Values.Count - 50)).ToList();
            chartPOT1Line.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "POT1 Trend",
                    Values = new ChartValues<int>(recentValues),
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 8,
                    Fill = MediaBrushes.Transparent,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(52, 152, 219)),
                    StrokeThickness = 3
                }
            };

            chartPOT1Line.AxisX.Add(new Axis
            {
                Title = "Reading Number",
                FontSize = 12
            });

            chartPOT1Line.AxisY.Add(new Axis
            {
                Title = "Value",
                FontSize = 12,
                MinValue = 0,
                MaxValue = 1023
            });

            // Pie Chart - توزيع النطاقات
            int low = pot1Values.Count(v => v < 341);
            int medium = pot1Values.Count(v => v >= 341 && v <= 682);
            int high = pot1Values.Count(v => v > 682);

            chartPOT1Pie.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Low (0-340)",
                    Values = new ChartValues<int> { low },
                    DataLabels = true,
                    LabelPoint = point => $"{point.Y} ({point.Participation:P0})",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(52, 152, 219))
                },
                new PieSeries
                {
                    Title = "Medium (341-682)",
                    Values = new ChartValues<int> { medium },
                    DataLabels = true,
                    LabelPoint = point => $"{point.Y} ({point.Participation:P0})",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(241, 196, 15))
                },
                new PieSeries
                {
                    Title = "High (683-1023)",
                    Values = new ChartValues<int> { high },
                    DataLabels = true,
                    LabelPoint = point => $"{point.Y} ({point.Participation:P0})",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(231, 76, 60))
                }
            };

            chartPOT1Pie.LegendLocation = LegendLocation.Bottom;
        }

        // ========== POT2 Statistics ==========
        private void UpdatePOT2Statistics()
        {
            if (pot2Values.Count == 0) return;

            // 🟢 تنظيف المحاور قبل الإضافة
            chartPOT2Line.AxisX.Clear();
            chartPOT2Line.AxisY.Clear();
            chartPOT2Line.Refresh();

            int min = pot2Values.Min();
            int max = pot2Values.Max();
            double avg = pot2Values.Average();
            int count = pot2Values.Count;

            lblPOT2MinTitle.Text = $"📉 Min: {min}";
            lblPOT2MaxTitle.Text = $"📈 Max: {max}";
            lblPOT2AvgTitle.Text = $"📊 Average: {avg:F2}";
            lblPOT2CountTitle.Text = $"🔢 Total Records: {count}";

            // تحديث Gauge للـ Min (أزرق)
            gaugePOT2Min.From = 0;
            gaugePOT2Min.To = 1023;
            gaugePOT2Min.Value = min;
            gaugePOT2Min.Uses360Mode = false;
            gaugePOT2Min.FromColor = System.Windows.Media.Color.FromRgb(41, 128, 185);
            gaugePOT2Min.ToColor = System.Windows.Media.Color.FromRgb(52, 152, 219);

            // تحديث Gauge للـ Max (أحمر)
            gaugePOT2Max.From = 0;
            gaugePOT2Max.To = 1023;
            gaugePOT2Max.Value = max;
            gaugePOT2Max.Uses360Mode = false;
            gaugePOT2Max.FromColor = System.Windows.Media.Color.FromRgb(192, 57, 43);
            gaugePOT2Max.ToColor = System.Windows.Media.Color.FromRgb(231, 76, 60);

            // تحديث Gauge للـ Average (أخضر)
            gaugePOT2Avg.From = 0;
            gaugePOT2Avg.To = 1023;
            gaugePOT2Avg.Value = Math.Round(avg, 0);
            gaugePOT2Avg.Uses360Mode = false;
            gaugePOT2Avg.FromColor = System.Windows.Media.Color.FromRgb(39, 174, 96);
            gaugePOT2Avg.ToColor = System.Windows.Media.Color.FromRgb(46, 204, 113);

            // تحديث Gauge للـ Count (بنفسجي) - نسبة مئوية من 1000
            double countPercent = Math.Min(count, 1000);
            gaugePOT2Count.From = 0;
            gaugePOT2Count.To = 100;
            gaugePOT2Count.Value = countPercent;
            gaugePOT2Count.Uses360Mode = false;
            gaugePOT2Count.FromColor = System.Windows.Media.Color.FromRgb(142, 68, 173);
            gaugePOT2Count.ToColor = System.Windows.Media.Color.FromRgb(155, 89, 182);
            gaugePOT2Count.LabelFormatter = val => count.ToString();

        }

        private void UpdatePOT2Charts()
        {
            if (pot2Values.Count == 0) return;

            // 🟢 تنظيف المحاور قبل الإضافة
            chartPOT2Line.AxisX.Clear();
            chartPOT2Line.AxisY.Clear();

            // Line Chart - آخر 50 قراءة
            var recentValues = pot2Values.Skip(Math.Max(0, pot2Values.Count - 50)).ToList();
            chartPOT2Line.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "POT2 Trend",
                    Values = new ChartValues<int>(recentValues),
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 8,
                    Fill = MediaBrushes.Transparent,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(155, 89, 182)),
                    StrokeThickness = 3
                }
            };

            chartPOT2Line.AxisX.Add(new Axis
            {
                Title = "Reading Number",
                FontSize = 12
            });

            chartPOT2Line.AxisY.Add(new Axis
            {
                Title = "Value",
                FontSize = 12,
                MinValue = 0,
                MaxValue = 1023
            });

            // Pie Chart - توزيع النطاقات
            int low = pot2Values.Count(v => v < 341);
            int medium = pot2Values.Count(v => v >= 341 && v <= 682);
            int high = pot2Values.Count(v => v > 682);

            chartPOT2Pie.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Low (0-340)",
                    Values = new ChartValues<int> { low },
                    DataLabels = true,
                    LabelPoint = point => $"{point.Y} ({point.Participation:P0})",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(52, 152, 219))
                },
                new PieSeries
                {
                    Title = "Medium (341-682)",
                    Values = new ChartValues<int> { medium },
                    DataLabels = true,
                    LabelPoint = point => $"{point.Y} ({point.Participation:P0})",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(241, 196, 15))
                },
                new PieSeries
                {
                    Title = "High (683-1023)",
                    Values = new ChartValues<int> { high },
                    DataLabels = true,
                    LabelPoint = point => $"{point.Y} ({point.Participation:P0})",
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(231, 76, 60))
                }
            };

            chartPOT2Pie.LegendLocation = LegendLocation.Bottom;
        }

        // ========== Comparison ==========
        private void UpdateComparisonChart()
        {
            if (pot1Values.Count == 0 || pot2Values.Count == 0) return;

            chartComparison.AxisX.Clear();
            chartComparison.AxisY.Clear();
            chartComparison.Refresh();

            // حساب الارتباط (Correlation)
            double correlation = CalculateCorrelation(pot1Values, pot2Values);
            lblCorrelation.Text = $"📊 Correlation: {correlation:F3}";

            // حساب متوسط الفرق
            double avgDiff = pot1Values.Zip(pot2Values, (p1, p2) => Math.Abs(p1 - p2)).Average();
            lblDifference.Text = $"📏 Average Difference: {avgDiff:F2}";

            // رسم المقارنة - آخر 50 قراءة
            var count = Math.Min(50, pot1Values.Count);
            var recent1 = pot1Values.Skip(pot1Values.Count - count).ToList();
            var recent2 = pot2Values.Skip(pot2Values.Count - count).ToList();

            chartComparison.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "POT1",
                    Values = new ChartValues<int>(recent1),
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 8,
                    Fill = MediaBrushes.Transparent,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(52, 152, 219)),
                    StrokeThickness = 3
                },
                new LineSeries
                {
                    Title = "POT2",
                    Values = new ChartValues<int>(recent2),
                    PointGeometry = DefaultGeometries.Diamond,
                    PointGeometrySize = 8,
                    Fill = MediaBrushes.Transparent,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(155, 89, 182)),
                    StrokeThickness = 3
                }
            };

            chartComparison.AxisX.Add(new Axis
            {
                Title = "Reading Number",
                FontSize = 14
            });

            chartComparison.AxisY.Add(new Axis
            {
                Title = "Value",
                FontSize = 14,
                MinValue = 0,
                MaxValue = 1023
            });

            chartComparison.LegendLocation = LegendLocation.Top;
        }

        // حساب معامل الارتباط (Pearson Correlation)
        private double CalculateCorrelation(List<int> x, List<int> y)
        {
            if (x.Count != y.Count || x.Count == 0) return 0;

            double avgX = x.Average();
            double avgY = y.Average();

            double sumXY = 0, sumX2 = 0, sumY2 = 0;

            for (int i = 0; i < x.Count; i++)
            {
                double dx = x[i] - avgX;
                double dy = y[i] - avgY;
                sumXY += dx * dy;
                sumX2 += dx * dx;
                sumY2 += dy * dy;
            }

            if (sumX2 == 0 || sumY2 == 0) return 0;

            return sumXY / Math.Sqrt(sumX2 * sumY2);
        }
    }
}