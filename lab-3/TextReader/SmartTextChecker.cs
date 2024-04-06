namespace TextReader
{
    public class SmartTextChecker : ITextService
    {
        SmartTextReader smartTextReader;

        public SmartTextChecker(SmartTextReader smartTextReader)
        {
            this.smartTextReader = smartTextReader;
        }

        public char[][] ConvertTo2DArray(string filepath)
        {
            Console.WriteLine("Opening file");
            var res = smartTextReader.ConvertTo2DArray(filepath);
            Console.WriteLine("Closing file");
            Console.WriteLine($"Total rows: {res.Length}");
            Console.WriteLine($"Total symbols: {CountSymbols(res)}");
            return res;
        }

        private static int CountSymbols(char[][] array)
        {
            int amount = 0;
            foreach (char[] c in array)
            {
                amount += c.Length;
            }
            return amount;
        }
    }
}
