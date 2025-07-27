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

        public Hammer Hammer {get; set; }
        public Saw Saw { get; set; }

        /*
        private Hammer _hammer;
        private Saw _saw;
        */

        // Setter DI - a default constructor is used instead of custom constructor

        /*
        public Builder(Hammer hammer, Saw saw)
        {
            _hammer = hammer; // Constructor Dependency Injection (DI)
            _saw = saw;
            
            
               // _hammer = new Hammer(); // Builder is responsible for
                                          // creating its dependencies
               // _saw = new Saw();
            
        }
        */

        public void BuildHouse()
        {
            Hammer.Use();
            Saw.Use();
            Console.WriteLine("The house is built");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder();
            builder.Hammer = hammer;
            builder.Saw = saw;

            builder.BuildHouse();
            
            Console.Read();
        }
    }
}
