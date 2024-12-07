using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExpenseManagementApp
{
    public static class Logger
    {
        private static string logFilePath = "logs.json";

        public static void LogException(Exception ex)
        {
            var logEntry = new
            {
                Message = ex.Message,
                StackTrace = ex.StackTrace,
                Date = DateTime.Now
            };

            string logContent = JsonConvert.SerializeObject(logEntry, Formatting.Indented);

            if (!File.Exists(logFilePath))
            {
                File.WriteAllText(logFilePath, "[");
            }

            string existingContent = File.ReadAllText(logFilePath);
            existingContent = existingContent.TrimEnd(']', '\n') + "," + logContent + "\n]";

            File.WriteAllText(logFilePath, existingContent);
        }
    }
}
