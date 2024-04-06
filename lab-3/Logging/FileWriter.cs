
namespace Logging
{
    public class FileWriter
    {
        public void Write(string content, string filepath)
        {
            using StreamWriter outputFile = new(filepath, true);
            outputFile.Write(content);
        }

        public void WriteLine(string content, string filepath)
        {
            using StreamWriter outputFile = new(filepath, true);
            outputFile.WriteLine(content);
        }
    }
}
