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
            
            // delegate LogHandler - assigning a method from a class Logger
            LogHandler logHandler = logger.LogToConsole;
            /*
            logHandler("Logging to console");

            // overriding a logHandler with another method
            logHandler = logger.LogToFile;
            logHandler("Logging to file");
            */

            // Multicast delegate
            logHandler += logger.LogToFile;

            // invoking the multicast delegate
            logHandler("Log this info");

            foreach (LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occured with error handling");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: " + ex.Message);
                }

            }

            // Removing a method from a delegate
            if(IsMethodInDelegate(logHandler, logger.LogToFile))
            {
                logHandler -= logger.LogToFile;
                Console.WriteLine("LogToFile method removed");
            }else
            {
                Console.WriteLine("LogToFile method not found");
            }

            if(logHandler != null)
            {
                // logHandler("After removing a logToFile");
                InvokeSafely(logHandler, "After removing a logToFile");
            }

            Console.ReadKey();
        }

        static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHandler = logHandler;
            if (tempLogHandler != null)
            {
                tempLogHandler(message);
            }
        }

        static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
        {
            if(logHandler == null)
            {
                return false;
            }

            foreach(var d in logHandler.GetInvocationList())
            {
                if(d == (Delegate)method)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
