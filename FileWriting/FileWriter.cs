using System.IO;

namespace FileWriting
{
    public class FileWriter
    {
        private readonly string fileName;
        private readonly object locker = new();
        public FileWriter(string fileName)
        {
            this.fileName = fileName;
        }

        public void Write(WritingUnit unit)
        {
            lock (locker)
            {
                File.AppendAllText(fileName, unit.StringBuilder.ToString());
            }
        }
    }
}
