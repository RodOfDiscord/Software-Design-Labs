namespace TextReader
{
    public class SmartTextReader : ITextService
    {
        public char[][] ConvertTo2DArray(string filepath)
        {
            var lines = ReadFile("test.txt").Split("\r\n");
            char[][] res = new char[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                res[i] = new char[lines[i].Length];
                for (int j = 0; j < lines[i].Length; j++)
                {
                    res[i][j] = lines[i][j];
                }
            }
            return res;
        }

        public string ReadFile(string filepath)
        {
            using StreamReader sr = new(filepath);
            return sr.ReadToEnd();
        }
    }
}
