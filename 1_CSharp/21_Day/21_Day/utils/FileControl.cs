using System.Collections.Generic;

namespace _21_Day.Utils
{
    public class FileControl
    {
        private readonly string _FolderPath = "files";
        private readonly string _FilePath;

        public FileControl()
        {
            FolderControlOrCreate();
            DateTime date = DateTime.Now;
            _FilePath = $"{_FolderPath}/{date.Year}-{date.Month}-{date.Day}.txt";

        }


        public FileControl(string filePath)
        {
            _FilePath = $"{_FolderPath}/{filePath}.txt";
        }
        private void FolderControlOrCreate()
        {
            if(!Directory.Exists(_FolderPath))
            {
                Directory.CreateDirectory(_FolderPath);
            }
        }
        
        public void WriteToFile(string content)
        {
            // File.WriteAllText(_FilePath,content); // Replace
            Console.WriteLine (Environment.OSVersion.VersionString);
            string line = Environment.NewLine;
            File.AppendAllText(_FilePath, $"{content}{line}"); // Append - Ekle
        }

        public void DeleteFile()
        {
            if (File.Exists(_FilePath))
            {
                File.Delete(_FilePath);
            }
        }

        public List<string> ReadFile()
        {
            List<string> list = new List<string>();
            if(File.Exists(_FilePath))
            {
                using var reader = new StreamReader(_FilePath);
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
            }
            return list;
        }

        public List<string> listFile()
        {
            List<string> list = new List<string>();
            if (Directory.Exists(_FolderPath))
            {
                var files = Directory.GetFiles(_FolderPath);
                foreach (var file in files)
                {
                    list.Add(Path.GetFileName(file));
                }
            }
            return list;
        }
        
    }
}