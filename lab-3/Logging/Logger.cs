namespace Logging
{
    public class Logger
    {
        public virtual void Log(string content) 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(content);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public virtual void Error(string content) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(content);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public virtual void Warn(string content) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(content);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
