namespace Logging
{
    public class FileWriterAdapter : Logger
    {
        FileWriter fileWriter;
        readonly string filepath;

        public FileWriterAdapter(FileWriter fileWriter, string filepath)
        {
            this.fileWriter = fileWriter;
            this.filepath = filepath;
        }

        public override void Log(string content)
        {
            fileWriter.WriteLine(content, filepath);
        }

        public override void Warn(string content)
        {
            fileWriter.WriteLine(content, filepath);
        }

        public override void Error(string content)
        {
            fileWriter.WriteLine(content, filepath);
        }
    }
}
