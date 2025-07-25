namespace BasicsOfInterfaces
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }
    
    public interface IAnimal
    {
        // no implementation of a method
        void MakeSound();

        void Eat(string food);
    }

    public class Dog : Animal // IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Dog ate " + food);
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal // IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Cat ate " + food);
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Eat("Treat");

            Cat cat = new Cat();
            cat.MakeSound();
            cat.Eat("Fish");
            */

            // Polymorphism
            Animal myDog = new Dog();
            myDog.MakeSound();

            Console.ReadKey();
        }
    }
}
