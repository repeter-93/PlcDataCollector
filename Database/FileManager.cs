using System;
using System.IO;
using System.Text;

namespace PlcDataCollector.Database
{
    class FileManager
    {
        public string FilePath { get; set; }

        public FileManager(string path)
        {
            this.FilePath = @path;
        }

        public void FileWriteLine(string text)
        {
            FileWrite(text + "\n");
        }

        public void FileWrite(string text)
        {
            try
            {
                FileStream fs = null;
                if (File.Exists(FilePath))
                {
                    using (fs = File.Open(FilePath, FileMode.Append, FileAccess.Write, FileShare.None))
                    {
                        Byte[] inputText = new UTF8Encoding(true).GetBytes(text);
                        fs.Write(inputText, 0, inputText.Length);
                    }
                }
                else
                {
                    using (fs = File.Create(FilePath))
                    {
                        Byte[] inputText = new UTF8Encoding(true).GetBytes(text);
                        fs.Write(inputText, 0, inputText.Length);
                    }
                }
            }
            catch (Exception e)
            {
                Desharp.Debug.Log(Desharp.Level.DEBUG);
                Desharp.Debug.Log(e);
            }
        }
    }
}