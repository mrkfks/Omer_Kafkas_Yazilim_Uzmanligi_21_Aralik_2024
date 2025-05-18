using System.Collections.Generic;

namespace MongoDB_Urun_Katalog_Uygulaması.ErrorLog
{
    public class ErrorLog
    {
        private readonly string _FolderPath = "ErrorLog";
        private readonly string _FilePath = "ErrorLog.txt";

        public ErrorLog()
        {
            ErrorlogControlorCreate();
            {
                DateTime dateTime = DateTime.Now;
                _FilePath = $"{_FolderPath}/{dateTime.Year}-{dateTime.Month}-{dateTime.Day} ErrorLog.txt";
            }
        }
        public ErrorLog(string folderPath)
        {
            _FilePath = $"{folderPath}/ErrorLog.txt";
        }

        private void ErrorlogControlorCreate()
        {
            if (!Directory.Exists(_FolderPath))
            {
                Directory.CreateDirectory(_FolderPath);
            }
        }
        public void WriteErrorLog(string errorMessage)
        {
            Console.WriteLine(Environment.OSVersion.VersionString);
            string line = Environment.NewLine;
        }

        public void DeleteErrorLog()
        {
            if (File.Exists(_FilePath))
            {
                File.Delete(_FilePath);
            }
        }

        public List<string> ReadErrorLog()
        {
            List<string> errorLogs = new List<string>();
            if (File.Exists(_FilePath))
            {
                using (StreamReader reader = new StreamReader(_FilePath))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        errorLogs.Add(line);
                    }
                }
            }
            return errorLogs;
        }

        public List<string> ListErrorLog()
        {
            List<string> errorLogs = new List<string>();
            if (Directory.Exists(_FolderPath))
            {
                var files = Directory.GetFiles(_FolderPath);
                foreach (var file in files)
                {
                    errorLogs.Add(Path.GetFileName(file));
                }
            }
            errorLogs.Sort();
            return errorLogs;
        }
    }
}