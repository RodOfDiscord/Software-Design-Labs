using System.Text.RegularExpressions;

namespace TextReader
{
    public class SmartTextReaderLocker : ITextService
    {
        SmartTextReader smartTextReader;
        string blockFilesPattern;

        public SmartTextReaderLocker(SmartTextReader smartTextReader, string blockFilesPattern)
        {
            this.smartTextReader = smartTextReader;
            this.blockFilesPattern = blockFilesPattern;
        }

        public char[][] ConvertTo2DArray(string filepath)
        {
            if (Regex.IsMatch(filepath, blockFilesPattern))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            return smartTextReader.ConvertTo2DArray(filepath);
        }

        public void ChangePattern(string pattern)
        {
            blockFilesPattern = pattern;
        }
    }
}
