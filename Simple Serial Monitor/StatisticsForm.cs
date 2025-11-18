using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;
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

        [Obsolete]
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var sfd = new SaveFileDialog
                {
                    Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                    FileName = $"Statistics_Report_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
                };

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");

                using (var package = new ExcelPackage())
                {
                    // ===== Sheet 1: Dashboard (ملخص شامل) =====
                    var wsDashboard = package.Workbook.Worksheets.Add("📊 Dashboard");

                    // عنوان رئيسي
                    wsDashboard.Cells["A1:F1"].Merge = true;
                    wsDashboard.Cells["A1"].Value = "POT SENSORS STATISTICS REPORT";
                    wsDashboard.Cells["A1"].Style.Font.Size = 20;
                    wsDashboard.Cells["A1"].Style.Font.Bold = true;
                    wsDashboard.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    wsDashboard.Cells["A1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    wsDashboard.Cells["A1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(52, 152, 219));
                    wsDashboard.Cells["A1"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    wsDashboard.Row(1).Height = 30;

                    // معلومات التقرير
                    wsDashboard.Cells["A2"].Value = "Report Date:";
                    wsDashboard.Cells["B2"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    wsDashboard.Cells["A3"].Value = "Total Records:";
                    wsDashboard.Cells["B3"].Value = pot1Values.Count;
                    wsDashboard.Cells["A2:A3"].Style.Font.Bold = true;

                    // POT1 Summary
                    wsDashboard.Cells["A5:C5"].Merge = true;
                    wsDashboard.Cells["A5"].Value = "POT1 SUMMARY";
                    wsDashboard.Cells["A5"].Style.Font.Size = 14;
                    wsDashboard.Cells["A5"].Style.Font.Bold = true;
                    wsDashboard.Cells["A5"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    wsDashboard.Cells["A5"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(41, 128, 185));
                    wsDashboard.Cells["A5"].Style.Font.Color.SetColor(System.Drawing.Color.White);

                    wsDashboard.Cells["A6"].Value = "Metric";
                    wsDashboard.Cells["B6"].Value = "Value";
                    wsDashboard.Cells["C6"].Value = "Percentage";
                    wsDashboard.Cells["A6:C6"].Style.Font.Bold = true;
                    wsDashboard.Cells["A6:C6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    wsDashboard.Cells["A6:C6"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                    wsDashboard.Cells["A7"].Value = "Minimum";
                    wsDashboard.Cells["B7"].Value = pot1Values.Min();
                    wsDashboard.Cells["C7"].Formula = $"=B7/1023";
                    wsDashboard.Cells["C7"].Style.Numberformat.Format = "0.00%";

                    wsDashboard.Cells["A8"].Value = "Maximum";
                    wsDashboard.Cells["B8"].Value = pot1Values.Max();
                    wsDashboard.Cells["C8"].Formula = $"=B8/1023";
                    wsDashboard.Cells["C8"].Style.Numberformat.Format = "0.00%";

                    wsDashboard.Cells["A9"].Value = "Average";
                    wsDashboard.Cells["B9"].Value = pot1Values.Average();
                    wsDashboard.Cells["C9"].Formula = $"=B9/1023";
                    wsDashboard.Cells["C9"].Style.Numberformat.Format = "0.00%";

                    wsDashboard.Cells["A10"].Value = "Standard Deviation";
                    wsDashboard.Cells["B10"].Value = CalculateStandardDeviation(pot1Values);
                    wsDashboard.Cells["B10"].Style.Numberformat.Format = "0.00";

                    // POT2 Summary
                    wsDashboard.Cells["A12:C12"].Merge = true;
                    wsDashboard.Cells["A12"].Value = "POT2 SUMMARY";
                    wsDashboard.Cells["A12"].Style.Font.Size = 14;
                    wsDashboard.Cells["A12"].Style.Font.Bold = true;
                    wsDashboard.Cells["A12"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    wsDashboard.Cells["A12"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(155, 89, 182));
                    wsDashboard.Cells["A12"].Style.Font.Color.SetColor(System.Drawing.Color.White);

                    wsDashboard.Cells["A13"].Value = "Metric";
                    wsDashboard.Cells["B13"].Value = "Value";
                    wsDashboard.Cells["C13"].Value = "Percentage";
                    wsDashboard.Cells["A13:C13"].Style.Font.Bold = true;
                    wsDashboard.Cells["A13:C13"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    wsDashboard.Cells["A13:C13"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                    wsDashboard.Cells["A14"].Value = "Minimum";
                    wsDashboard.Cells["B14"].Value = pot2Values.Min();
                    wsDashboard.Cells["C14"].Formula = $"=B14/1023";
                    wsDashboard.Cells["C14"].Style.Numberformat.Format = "0.00%";

                    wsDashboard.Cells["A15"].Value = "Maximum";
                    wsDashboard.Cells["B15"].Value = pot2Values.Max();
                    wsDashboard.Cells["C15"].Formula = $"=B15/1023";
                    wsDashboard.Cells["C15"].Style.Numberformat.Format = "0.00%";

                    wsDashboard.Cells["A16"].Value = "Average";
                    wsDashboard.Cells["B16"].Value = pot2Values.Average();
                    wsDashboard.Cells["C16"].Formula = $"=B16/1023";
                    wsDashboard.Cells["C16"].Style.Numberformat.Format = "0.00%";

                    wsDashboard.Cells["A17"].Value = "Standard Deviation";
                    wsDashboard.Cells["B17"].Value = CalculateStandardDeviation(pot2Values);
                    wsDashboard.Cells["B17"].Style.Numberformat.Format = "0.00";

                    // Comparison
                    wsDashboard.Cells["E5:F5"].Merge = true;
                    wsDashboard.Cells["E5"].Value = "COMPARISON";
                    wsDashboard.Cells["E5"].Style.Font.Size = 14;
                    wsDashboard.Cells["E5"].Style.Font.Bold = true;
                    wsDashboard.Cells["E5"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    wsDashboard.Cells["E5"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(39, 174, 96));
                    wsDashboard.Cells["E5"].Style.Font.Color.SetColor(System.Drawing.Color.White);

                    wsDashboard.Cells["E6"].Value = "Metric";
                    wsDashboard.Cells["F6"].Value = "Value";
                    wsDashboard.Cells["E6:F6"].Style.Font.Bold = true;
                    wsDashboard.Cells["E6:F6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    wsDashboard.Cells["E6:F6"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                    wsDashboard.Cells["E7"].Value = "Correlation";
                    wsDashboard.Cells["F7"].Value = CalculateCorrelation(pot1Values, pot2Values);
                    wsDashboard.Cells["F7"].Style.Numberformat.Format = "0.000";

                    wsDashboard.Cells["E8"].Value = "Avg Difference";
                    wsDashboard.Cells["F8"].Value = pot1Values.Zip(pot2Values, (a, b) => Math.Abs(a - b)).Average();
                    wsDashboard.Cells["F8"].Style.Numberformat.Format = "0.00";

                    wsDashboard.Cells.AutoFitColumns();

                    // إضافة بيانات للشارت في Dashboard (آخر 30 قراءة)
                    int dashboardDataStart = 20;
                    wsDashboard.Cells["H19"].Value = "Reading";
                    wsDashboard.Cells["I19"].Value = "POT1";
                    wsDashboard.Cells["J19"].Value = "POT2";
                    wsDashboard.Cells["H19:J19"].Style.Font.Bold = true;


                    var recentCount = Math.Min(30, pot1Values.Count);
                    var recentPot1 = pot1Values.Skip(pot1Values.Count - recentCount).ToList();
                    var recentPot2 = pot2Values.Skip(pot2Values.Count - recentCount).ToList();

                    for (int i = 0; i < recentCount; i++)
                    {
                        int row = dashboardDataStart + i;
                        wsDashboard.Cells[row, 8].Value = i + 1;
                        wsDashboard.Cells[row, 9].Value = recentPot1[i];
                        wsDashboard.Cells[row, 10].Value = recentPot2[i];
                    }

                    // إضافة رسم بياني للمقارنة في Dashboard
                    var comparisonChart = wsDashboard.Drawings.AddChart("ComparisonChart", eChartType.Line);
                    comparisonChart.Title.Text = "POT1 vs POT2 - Last 30 Readings";
                    comparisonChart.Title.Font.Size = 14;
                    comparisonChart.Title.Font.Bold = true;
                    comparisonChart.SetPosition(1, 0, 7, 0);
                    comparisonChart.SetSize(700, 350);

                    var pot1ChartSeries = comparisonChart.Series.Add(wsDashboard.Cells[dashboardDataStart, 9, dashboardDataStart + recentCount - 1, 9],
                                                                     wsDashboard.Cells[dashboardDataStart, 8, dashboardDataStart + recentCount - 1, 8]);
                    pot1ChartSeries.Header = "POT1";

                    var pot2ChartSeries = comparisonChart.Series.Add(wsDashboard.Cells[dashboardDataStart, 10, dashboardDataStart + recentCount - 1, 10],
                                                                     wsDashboard.Cells[dashboardDataStart, 8, dashboardDataStart + recentCount - 1, 8]);
                    pot2ChartSeries.Header = "POT2";

                    comparisonChart.XAxis.Title.Text = "Reading Number";
                    comparisonChart.YAxis.Title.Text = "Value";
                    comparisonChart.Legend.Position = eLegendPosition.Bottom;

                    // ===== Sheet 2: POT1 Details =====
                    var ws1 = package.Workbook.Worksheets.Add("📈 POT1 Details");

                    // Header
                    ws1.Cells["A1:C1"].Merge = true;
                    ws1.Cells["A1"].Value = "POT1 DETAILED STATISTICS";
                    ws1.Cells["A1"].Style.Font.Size = 16;
                    ws1.Cells["A1"].Style.Font.Bold = true;
                    ws1.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws1.Cells["A1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws1.Cells["A1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(52, 152, 219));
                    ws1.Cells["A1"].Style.Font.Color.SetColor(System.Drawing.Color.White);

                    // Statistics Table
                    ws1.Cells["A3"].Value = "Metric";
                    ws1.Cells["B3"].Value = "Value";
                    ws1.Cells["C3"].Value = "Description";
                    ws1.Cells["A3:C3"].Style.Font.Bold = true;
                    ws1.Cells["A3:C3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws1.Cells["A3:C3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                    ws1.Cells["A4"].Value = "Minimum";
                    ws1.Cells["B4"].Value = pot1Values.Min();
                    ws1.Cells["C4"].Value = "Lowest recorded value";

                    ws1.Cells["A5"].Value = "Maximum";
                    ws1.Cells["B5"].Value = pot1Values.Max();
                    ws1.Cells["C5"].Value = "Highest recorded value";

                    ws1.Cells["A6"].Value = "Average";
                    ws1.Cells["B6"].Value = pot1Values.Average();
                    ws1.Cells["B6"].Style.Numberformat.Format = "0.00";
                    ws1.Cells["C6"].Value = "Mean of all readings";

                    ws1.Cells["A7"].Value = "Median";
                    ws1.Cells["B7"].Value = CalculateMedian(pot1Values);
                    ws1.Cells["C7"].Value = "Middle value";

                    ws1.Cells["A8"].Value = "Standard Deviation";
                    ws1.Cells["B8"].Value = CalculateStandardDeviation(pot1Values);
                    ws1.Cells["B8"].Style.Numberformat.Format = "0.00";
                    ws1.Cells["C8"].Value = "Measure of spread";

                    ws1.Cells["A9"].Value = "Count";
                    ws1.Cells["B9"].Value = pot1Values.Count;
                    ws1.Cells["C9"].Value = "Total number of readings";

                    // Distribution Analysis
                    ws1.Cells["A11:C11"].Merge = true;
                    ws1.Cells["A11"].Value = "VALUE DISTRIBUTION";
                    ws1.Cells["A11"].Style.Font.Bold = true;
                    ws1.Cells["A11"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws1.Cells["A11"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                    ws1.Cells["A12"].Value = "Range";
                    ws1.Cells["B12"].Value = "Count";
                    ws1.Cells["C12"].Value = "Percentage";
                    ws1.Cells["A12:C12"].Style.Font.Bold = true;

                    int pot1Low = pot1Values.Count(v => v < 341);
                    int pot1Medium = pot1Values.Count(v => v >= 341 && v <= 682);
                    int pot1High = pot1Values.Count(v => v > 682);

                    ws1.Cells["A13"].Value = "Low (0-340)";
                    ws1.Cells["B13"].Value = pot1Low;
                    ws1.Cells["C13"].Formula = $"=B13/{pot1Values.Count}";
                    ws1.Cells["C13"].Style.Numberformat.Format = "0.00%";
                    ws1.Cells["A13"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws1.Cells["A13"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(52, 152, 219));

                    ws1.Cells["A14"].Value = "Medium (341-682)";
                    ws1.Cells["B14"].Value = pot1Medium;
                    ws1.Cells["C14"].Formula = $"=B14/{pot1Values.Count}";
                    ws1.Cells["C14"].Style.Numberformat.Format = "0.00%";
                    ws1.Cells["A14"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws1.Cells["A14"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(241, 196, 15));

                    ws1.Cells["A15"].Value = "High (683-1023)";
                    ws1.Cells["B15"].Value = pot1High;
                    ws1.Cells["C15"].Formula = $"=B15/{pot1Values.Count}";
                    ws1.Cells["C15"].Style.Numberformat.Format = "0.00%";
                    ws1.Cells["A15"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws1.Cells["A15"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(231, 76, 60));

                    ws1.Cells.AutoFitColumns();

                    // إضافة Pie Chart لتوزيع POT1
                    var pot1PieChart = ws1.Drawings.AddChart("POT1Distribution", eChartType.Pie);
                    pot1PieChart.Title.Text = "POT1 Value Distribution";
                    pot1PieChart.SetPosition(1, 0, 4, 0);
                    pot1PieChart.SetSize(400, 300);
                    var pot1PieSeries = pot1PieChart.Series.Add(ws1.Cells["B13:B15"], ws1.Cells["A13:A15"]);
                    pot1PieSeries.Header = "Distribution";

                    // ===== Sheet 3: POT2 Details =====
                    var ws2 = package.Workbook.Worksheets.Add("📈 POT2 Details");

                    // Header
                    ws2.Cells["A1:C1"].Merge = true;
                    ws2.Cells["A1"].Value = "POT2 DETAILED STATISTICS";
                    ws2.Cells["A1"].Style.Font.Size = 16;
                    ws2.Cells["A1"].Style.Font.Bold = true;
                    ws2.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws2.Cells["A1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws2.Cells["A1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(155, 89, 182));
                    ws2.Cells["A1"].Style.Font.Color.SetColor(System.Drawing.Color.White);

                    // Statistics Table
                    ws2.Cells["A3"].Value = "Metric";
                    ws2.Cells["B3"].Value = "Value";
                    ws2.Cells["C3"].Value = "Description";
                    ws2.Cells["A3:C3"].Style.Font.Bold = true;
                    ws2.Cells["A3:C3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws2.Cells["A3:C3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Plum);

                    ws2.Cells["A4"].Value = "Minimum";
                    ws2.Cells["B4"].Value = pot2Values.Min();
                    ws2.Cells["C4"].Value = "Lowest recorded value";

                    ws2.Cells["A5"].Value = "Maximum";
                    ws2.Cells["B5"].Value = pot2Values.Max();
                    ws2.Cells["C5"].Value = "Highest recorded value";

                    ws2.Cells["A6"].Value = "Average";
                    ws2.Cells["B6"].Value = pot2Values.Average();
                    ws2.Cells["B6"].Style.Numberformat.Format = "0.00";
                    ws2.Cells["C6"].Value = "Mean of all readings";

                    ws2.Cells["A7"].Value = "Median";
                    ws2.Cells["B7"].Value = CalculateMedian(pot2Values);
                    ws2.Cells["C7"].Value = "Middle value";

                    ws2.Cells["A8"].Value = "Standard Deviation";
                    ws2.Cells["B8"].Value = CalculateStandardDeviation(pot2Values);
                    ws2.Cells["B8"].Style.Numberformat.Format = "0.00";
                    ws2.Cells["C8"].Value = "Measure of spread";

                    ws2.Cells["A9"].Value = "Count";
                    ws2.Cells["B9"].Value = pot2Values.Count;
                    ws2.Cells["C9"].Value = "Total number of readings";

                    // Distribution Analysis
                    ws2.Cells["A11:C11"].Merge = true;
                    ws2.Cells["A11"].Value = "VALUE DISTRIBUTION";
                    ws2.Cells["A11"].Style.Font.Bold = true;
                    ws2.Cells["A11"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws2.Cells["A11"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                    ws2.Cells["A12"].Value = "Range";
                    ws2.Cells["B12"].Value = "Count";
                    ws2.Cells["C12"].Value = "Percentage";
                    ws2.Cells["A12:C12"].Style.Font.Bold = true;

                    int pot2Low = pot2Values.Count(v => v < 341);
                    int pot2Medium = pot2Values.Count(v => v >= 341 && v <= 682);
                    int pot2High = pot2Values.Count(v => v > 682);

                    ws2.Cells["A13"].Value = "Low (0-340)";
                    ws2.Cells["B13"].Value = pot2Low;
                    ws2.Cells["C13"].Formula = $"=B13/{pot2Values.Count}";
                    ws2.Cells["C13"].Style.Numberformat.Format = "0.00%";
                    ws2.Cells["A13"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws2.Cells["A13"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(52, 152, 219));

                    ws2.Cells["A14"].Value = "Medium (341-682)";
                    ws2.Cells["B14"].Value = pot2Medium;
                    ws2.Cells["C14"].Formula = $"=B14/{pot2Values.Count}";
                    ws2.Cells["C14"].Style.Numberformat.Format = "0.00%";
                    ws2.Cells["A14"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws2.Cells["A14"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(241, 196, 15));

                    ws2.Cells["A15"].Value = "High (683-1023)";
                    ws2.Cells["B15"].Value = pot2High;
                    ws2.Cells["C15"].Formula = $"=B15/{pot2Values.Count}";
                    ws2.Cells["C15"].Style.Numberformat.Format = "0.00%";
                    ws2.Cells["A15"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws2.Cells["A15"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(231, 76, 60));

                    ws2.Cells.AutoFitColumns();

                    // إضافة Pie Chart لتوزيع POT2
                    var pot2PieChart = ws2.Drawings.AddChart("POT2Distribution", eChartType.Pie);
                    pot2PieChart.Title.Text = "POT2 Value Distribution";
                    pot2PieChart.SetPosition(1, 0, 4, 0);
                    pot2PieChart.SetSize(400, 300);
                    var pot2Series = pot2PieChart.Series.Add(ws2.Cells["B13:B15"], ws2.Cells["A13:A15"]);
                    pot2Series.Header = "Distribution";

                    // ===== Sheet 4: Raw Data =====
                    var ws4 = package.Workbook.Worksheets.Add("📄 Raw Data");

                    ws4.Cells["A1:D1"].Merge = true;
                    ws4.Cells["A1"].Value = "RAW SENSOR READINGS";
                    ws4.Cells["A1"].Style.Font.Size = 16;
                    ws4.Cells["A1"].Style.Font.Bold = true;
                    ws4.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws4.Cells["A1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws4.Cells["A1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(44, 62, 80));
                    ws4.Cells["A1"].Style.Font.Color.SetColor(System.Drawing.Color.White);

                    ws4.Cells["A3"].Value = "Index";
                    ws4.Cells["B3"].Value = "POT1";
                    ws4.Cells["C3"].Value = "POT2";
                    ws4.Cells["D3"].Value = "Difference";
                    ws4.Cells["A3:D3"].Style.Font.Bold = true;
                    ws4.Cells["A3:D3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws4.Cells["A3:D3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    ws4.Cells["A3:D3"].Style.Border.Bottom.Style = ExcelBorderStyle.Thick;

                    for (int i = 0; i < pot1Values.Count; i++)
                    {
                        int row = i + 4;
                        ws4.Cells[row, 1].Value = i + 1;
                        ws4.Cells[row, 2].Value = pot1Values[i];
                        ws4.Cells[row, 3].Value = pot2Values[i];
                        ws4.Cells[row, 4].Formula = $"=ABS(B{row}-C{row})";

                        // تلوين الصفوف بالتناوب
                        if (i % 2 == 0)
                        {
                            ws4.Cells[row, 1, row, 4].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            ws4.Cells[row, 1, row, 4].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(236, 240, 241));
                        }
                    }

                    // إضافة Borders
                    ws4.Cells[3, 1, pot1Values.Count + 3, 4].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    ws4.Cells[3, 1, pot1Values.Count + 3, 4].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    ws4.Cells[3, 1, pot1Values.Count + 3, 4].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    ws4.Cells[3, 1, pot1Values.Count + 3, 4].Style.Border.Right.Style = ExcelBorderStyle.Thin;

                    ws4.Cells.AutoFitColumns();

                    // إضافة بيانات للشارت (آخر 100 قراءة للمقارنة)
                    int rawDataCount = Math.Min(100, pot1Values.Count);
                    int chartDataStartRow = pot1Values.Count + 6; // بعد البيانات الأساسية

                    ws4.Cells[chartDataStartRow, 6].Value = "Reading";
                    ws4.Cells[chartDataStartRow, 7].Value = "POT1";
                    ws4.Cells[chartDataStartRow, 8].Value = "POT2";
                    ws4.Cells[chartDataStartRow, 6, chartDataStartRow, 8].Style.Font.Bold = true;

                    var rawPot1Recent = pot1Values.Skip(pot1Values.Count - rawDataCount).ToList();
                    var rawPot2Recent = pot2Values.Skip(pot2Values.Count - rawDataCount).ToList();

                    for (int i = 0; i < rawDataCount; i++)
                    {
                        int row = chartDataStartRow + 1 + i;
                        ws4.Cells[row, 6].Value = i + 1;
                        ws4.Cells[row, 7].Value = rawPot1Recent[i];
                        ws4.Cells[row, 8].Value = rawPot2Recent[i];
                    }

                    // إضافة Scatter Chart للمقارنة
                    var scatterChart = ws4.Drawings.AddChart("DataComparison", eChartType.Line);
                    scatterChart.Title.Text = "POT1 vs POT2 Comparison - Last 100 Readings";
                    scatterChart.Title.Font.Size = 14;
                    scatterChart.Title.Font.Bold = true;
                    scatterChart.SetPosition(1, 0, 5, 0);
                    scatterChart.SetSize(700, 400);

                    var scatterPot1 = scatterChart.Series.Add(ws4.Cells[chartDataStartRow + 1, 7, chartDataStartRow + rawDataCount, 7],
                                                              ws4.Cells[chartDataStartRow + 1, 6, chartDataStartRow + rawDataCount, 6]);
                    scatterPot1.Header = "POT1";

                    var scatterPot2 = scatterChart.Series.Add(ws4.Cells[chartDataStartRow + 1, 8, chartDataStartRow + rawDataCount, 8],
                                                              ws4.Cells[chartDataStartRow + 1, 6, chartDataStartRow + rawDataCount, 6]);
                    scatterPot2.Header = "POT2";

                    scatterChart.XAxis.Title.Text = "Reading Number";
                    scatterChart.YAxis.Title.Text = "Sensor Value";
                    scatterChart.Legend.Position = eLegendPosition.Top;

                    // حفظ الملف
                    package.SaveAs(sfd.FileName);
                }

                MessageBox.Show("✅ Enhanced Excel Report Exported Successfully!\n\n📊 Features:\n- Professional Dashboard\n- Detailed Statistics\n- Distribution Analysis\n- Visual Charts\n- Formatted Tables",
                    "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error exporting Excel: {ex.Message}\n\nStack Trace: {ex.StackTrace}",
                    "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper Functions
        private double CalculateStandardDeviation(List<int> values)
        {
            if (values.Count == 0) return 0;
            double avg = values.Average();
            double sumOfSquares = values.Sum(v => Math.Pow(v - avg, 2));
            return Math.Sqrt(sumOfSquares / values.Count);
        }

        private double CalculateMedian(List<int> values)
        {
            if (values.Count == 0) return 0;
            var sorted = values.OrderBy(v => v).ToList();
            int mid = sorted.Count / 2;
            if (sorted.Count % 2 == 0)
                return (sorted[mid - 1] + sorted[mid]) / 2.0;
            return sorted[mid];
        }
    }
}