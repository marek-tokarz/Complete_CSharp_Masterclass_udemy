namespace DependencyInjectionApp
{
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering nails");
        }
    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing a wood");
        }
    }
    public class Builder
    {
        private Hammer _hammer;
        private Saw _saw;

        public Builder()
        {
                _hammer = new Hammer(); // Builder is responsible for
                                        // creating its dependencies
                _saw = new Saw();
        }

        public void BuildHous()
        {
            _hammer.Use();
            Console.WriteLine("The house is built");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
