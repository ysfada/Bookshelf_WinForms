using Bookshelf.Properties;
using dotenv.net.Utilities;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace Bookshelf.Database
{
    internal static class Database
    {
        public static string ConnectionString { get; } = Settings.Default.ConnectionString;

        static Database()
        {
            var envReader = new EnvReader();

            ConnectionString = string.Format(
                ConnectionString,
                envReader.GetStringValue("DB_HOST"),
                envReader.GetStringValue("DB_PORT"),
                envReader.GetStringValue("DB_CATALOG"),
                envReader.GetStringValue("DB_USERNAME"),
                envReader.GetStringValue("DB_PASSWORD"));
        }

        public static SqlConnection CreateConnection()
        {
            return new(ConnectionString);
        }

        public static void ExecuteSqlFiles(string path)
        {
            var files = Directory.GetFiles(path, "*.up.sql", SearchOption.AllDirectories);

            if (files.Length == 0) return;

            foreach (var file in files)
            {
                if (file.Length == 0) return;

                var sqlFileText = File.ReadAllText(file);

                var cmdTexts = Regex.Split(sqlFileText, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                foreach (var cmdText in cmdTexts)
                {
                    if (cmdText.Trim() == "") continue;

                    using var connection = CreateConnection();

                    var command = new SqlCommand(cmdText, connection);

                    try
                    {
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        var spError = cmdText.Length > 100 ? cmdText.Substring(0, 100) + " ...\n..." : cmdText;
                        throw new Exception($"Please check the SqlServer script.\nFile: {path} \nLine: {ex.LineNumber} \nError: {ex.Message} \nSQL Command: \n{spError}");
                    }
                }
            }
        }
    }
}