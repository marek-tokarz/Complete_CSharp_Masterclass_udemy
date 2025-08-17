namespace BasicsOfDelegates
{
    internal class Program
    {
        // 1. Declaration
        public delegate void Notify(string message);
        // no body for a delegate

        static void Main(string[] args)
        {
            // Delegates define a method signature,
            // and any method assigned to a delegate must match this signature.

            // 2. Instantiation:
            // Notify notifyDelegate = ShowMessage;
            Notify notifyDelegate = new Notify(ShowMessage);

            // 3. Invocation
            notifyDelegate("Hello, Delegates!");

            Console.ReadKey();
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
