using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace Virtual_Instrumentation
{
    public static class DatabaseInitializer
    {
        public static string DbPath { get; private set; }
        public static string ConnectionString => $"Data Source={DbPath}";

        public static void Initialize()
        {
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "VirtualInstrumentation");

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            DbPath = Path.Combine(folder, "data.db");

            if (!File.Exists(DbPath))
                CreateDatabase();
        }

        private static void CreateDatabase()
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            using var cmd = connection.CreateCommand();
            cmd.CommandText =
                @"CREATE TABLE IF NOT EXISTS readings(
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    pot1 INTEGER,
                    pot2 INTEGER,
                    raw TEXT,
                    timestamp DATETIME DEFAULT CURRENT_TIMESTAMP
                );";
            cmd.ExecuteNonQuery();
        }
    }
}
