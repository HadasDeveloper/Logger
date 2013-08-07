using System;
using System.IO;


namespace Logger
{
    public class FileLogWriter
    {
        private string folderPath;

        public FileLogWriter()
        {
            folderPath = "D:\\Logs\\";
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
        }

        public FileLogWriter(string path)
        {
            folderPath = path;
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
        }

        private string GetFilePath(string fileName)
        {
            return
                (string.Format("{0}{1}.txt", folderPath, fileName));
        }


        public void WriteToLog(DateTime time, string message, string fileName)
        {
            string filePath = GetFilePath(fileName);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(string.Format("{0}:    {1}", time, message));
            }
        }

    }
}
