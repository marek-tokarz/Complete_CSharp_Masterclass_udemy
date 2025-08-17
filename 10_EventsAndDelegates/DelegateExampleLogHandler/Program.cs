namespace DelegateExampleLogHandler
{
    public delegate void LogHandler(string message);

    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console Log: " + message);
        }

        public void LogToFile(string message)
        {
            Console.WriteLine("File log: " + message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // class Logger
            Logger logger = new Logger();
            
            // delegate LogHandler - assigning a lmethod from a class Logger
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Logging to console");

            // overriding a logHandler with another method
            logHandler = logger.LogToFile;
            logHandler("Logging to file");

            Console.ReadKey();
        }
    }
}
