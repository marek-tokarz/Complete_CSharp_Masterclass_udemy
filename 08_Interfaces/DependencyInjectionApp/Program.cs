namespace DependencyInjectionApp
{
    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }

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
    public class Builder : IToolUser
    {

        private Hammer _hammer;
        private Saw _saw;

        // Setters used with Setter DI
        /*
        public Hammer Hammer {get; set; }
        public Saw Saw { get; set; }
        */

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
            // Interface DI

            _hammer.Use();
            _saw.Use();

            /*
            Hammer.Use();
            Saw.Use();
            */
            Console.WriteLine("The house is built");
        }

        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder();

            /*
            // Setter DI
            builder.Hammer = hammer; // Inject dependencies via Setter
            builder.Saw = saw;       // Inject dependencies via Setter
            */

            // Interface DI
            builder.SetHammer(hammer);
            builder.SetSaw(saw);
            
            builder.BuildHouse();
            
            Console.Read();
        }
    }
}
