using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Virtual_Instrumentation
{
    public partial class DatabaseViewerForm : Form
    {
        string _connString = DatabaseInitializer.ConnectionString;
        private string _currentTable = "";

        public DatabaseViewerForm()
        {
            InitializeComponent();
        }

        private void DatabaseViewerForm_Load(object sender, EventArgs e)
        {
            LoadTableNames();
        }

        // ============================================================
        // Load all table names
        // ============================================================
        private void LoadTableNames()
        {
            try
            {
                comboBoxTables.Items.Clear();

                using var conn = new SqliteConnection(_connString);
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText =
                    "SELECT name FROM sqlite_master WHERE type='table' AND name NOT LIKE 'sqlite_%' ORDER BY name";

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxTables.Items.Add(reader.GetString(0));
                }

                if (comboBoxTables.Items.Count > 0)
                    comboBoxTables.SelectedIndex = 0;
                else
                    MessageBox.Show("⚠ No tables found in database!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error loading tables: {ex.Message}");
            }
        }

        // ============================================================
        // Load selected table data
        // ============================================================
        private void LoadTableData(string tableName)
        {
            if (string.IsNullOrEmpty(tableName)) return;

            try
            {
                _currentTable = tableName;

                using var conn = new SqliteConnection(_connString);
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM {tableName}";

                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridViewMain.DataSource = dt;
                lblTotalRecords.Text = $"Total Records: {dt.Rows.Count}";

                dataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewMain.AlternatingRowsDefaultCellStyle.BackColor =
                    System.Drawing.Color.FromArgb(249, 250, 251);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error loading data: {ex.Message}");
            }
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTables.SelectedItem != null)
#pragma warning disable CS8604 // Possible null reference argument.
                LoadTableData(comboBoxTables.SelectedItem.ToString());
#pragma warning restore CS8604 // Possible null reference argument.
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTableNames();

            if (comboBoxTables.SelectedItem != null)
#pragma warning disable CS8604 // Possible null reference argument.
                LoadTableData(comboBoxTables.SelectedItem.ToString());
#pragma warning restore CS8604 // Possible null reference argument.

            MessageBox.Show("✅ Tables refreshed successfully!");
        }

        // ============================================================
        // Delete selected rows
        // ============================================================
        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠ Please select at least one row to delete!");
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete {dataGridViewMain.SelectedRows.Count} row(s)?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                using var conn = new SqliteConnection(_connString);
                conn.Open();

                foreach (DataGridViewRow row in dataGridViewMain.SelectedRows)
                {
                    if (row.Cells["id"].Value == null) continue;

                    int id = Convert.ToInt32(row.Cells["id"].Value);

                    using var cmd = conn.CreateCommand();
                    cmd.CommandText = $"DELETE FROM {_currentTable} WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                LoadTableData(_currentTable);
                MessageBox.Show("✅ Selected rows deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Delete Error: {ex.Message}");
            }
        }

        // ============================================================
        // Delete all rows
        // ============================================================
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentTable))
            {
                MessageBox.Show("⚠ No table selected!");
                return;
            }

            var confirm = MessageBox.Show(
                $"⚠ This will DELETE ALL DATA from table '{_currentTable}'.\nAre you sure?",
                "BIG WARNING!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                using var conn = new SqliteConnection(_connString);
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = $"DELETE FROM {_currentTable}";
                cmd.ExecuteNonQuery();

                LoadTableData(_currentTable);
                MessageBox.Show($"✅ All records removed from '{_currentTable}'!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Delete All Error: {ex.Message}");
            }
        }

        // ============================================================
        // Export CSV
        // ============================================================
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.Rows.Count == 0)
            {
                MessageBox.Show("⚠ No data to export!");
                return;
            }

            using SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV File (*.csv)|*.csv",
                FileName = $"{_currentTable}_{DateTime.Now:yyyyMMdd_HHmmss}.csv",
                Title = "Export Data"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                var sb = new StringBuilder();

                // Headers
                var headers = dataGridViewMain.Columns.Cast<DataGridViewColumn>()
                    .Select(c => c.HeaderText);
                sb.AppendLine(string.Join(",", headers));

                // Rows
                foreach (DataGridViewRow row in dataGridViewMain.Rows)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>()
                        .Select(c => c.Value?.ToString() ?? "");
                    sb.AppendLine(string.Join(",", cells));
                }

                File.WriteAllText(sfd.FileName, sb.ToString());
                MessageBox.Show("✅ CSV file exported successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Export Error: {ex.Message}");
            }
        }

        // ============================================================
        // Search (ID or timestamp)
        // ============================================================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadTableData(_currentTable);
                return;
            }

            try
            {
                using var conn = new SqliteConnection(_connString);
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText =
                    $"SELECT * FROM {_currentTable} WHERE CAST(id AS TEXT) LIKE @s OR timestamp LIKE @s";
                cmd.Parameters.AddWithValue("@s", $"%{txtSearch.Text}%");

                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridViewMain.DataSource = dt;
                lblTotalRecords.Text = $"Search Results: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Search Error: {ex.Message}");
            }
        }

        // ============================================================
        // Execute custom SQL SELECT queries
        // ============================================================
        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomQuery.Text))
            {
                MessageBox.Show("⚠ Please type a SQL SELECT query!");
                return;
            }

            string q = txtCustomQuery.Text.Trim().ToUpper();
            if (!q.StartsWith("SELECT"))
            {
                MessageBox.Show("⚠ Only SELECT queries are allowed for safety!");
                return;
            }

            try
            {
                using var conn = new SqliteConnection(_connString);
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = txtCustomQuery.Text;

                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridViewMain.DataSource = dt;
                lblTotalRecords.Text = $"Query Results: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Query Error: {ex.Message}");
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
