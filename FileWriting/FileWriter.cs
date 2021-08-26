using System.IO;
using System.Threading.Tasks;

namespace FileWriting
{
    public class FileWriter
    {
        public async Task WriteAsync(WritingUnit unit, StreamWriter streamWriter)
        {
             await streamWriter.WriteAsync(unit.StringBuilder.ToString());
        }
    }
}
