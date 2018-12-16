using System;
using System.IO;
using System.Text;

namespace Logic
{
    public class TextFileManager
    {
        protected string FilePath;
        protected StreamWriter FileStreamWriter;
        protected StreamReader FileStreamReader;
        
        public TextFileManager(string filePath) => FilePath = filePath;
        

        public void WriteToFile(string input)
        {
            using (FileStreamWriter = new StreamWriter(FilePath, false))
            {
                FileStreamWriter.Write(input);
            }
        }

        public string ReadFromFile()
        {
            string ret = "";
            using (FileStreamReader = new StreamReader(FilePath))
            {
                ret = FileStreamReader.ReadToEnd();
            }
            return ret;
        }
    }
}
