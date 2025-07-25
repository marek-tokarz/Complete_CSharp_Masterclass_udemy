namespace LogingToTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");
            string message = "This is a log entry";

            if(!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, message + "\n");
            Console.ReadKey();
        }
    }
}
