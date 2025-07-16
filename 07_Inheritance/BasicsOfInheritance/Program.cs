namespace BasicsOfInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Basics of inheritance
            /*
            Dog myDog = new Dog();
            myDog.Bark();
            myDog.Eat();
            */

            // Access modifiers
            /*
            BaseClass baseClass = new BaseClass();
            baseClass.ShowFields();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.AccesFields();
            derivedClass.ShowFields();
            */

            Dog myDog = new Dog();
            myDog.MakeSound();

            Cat myCat = new Cat();
            myCat.MakeSound();

            Console.ReadKey();
        }
    }

    // Base class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound");
        }
    }

    // Derived Class
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Barking...");
        }
    }

    // Two classes (Dog and Cat) derive from a base class (Animal)
    // This is hierarchical inheritance
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat is meowing");
        }
    }

    // Next level of inheritance:
    // Animal -> Dog -> Collie
    // This is a Multi Level Inheritance
    class Collie : Dog
    {
        public void GoingNuts()
        {
            Console.WriteLine("Collie going nuts");
        }
    }

    // Access modifiers and protected keyword
    class BaseClass
    {
        // access modifiers
        public int publicField;
        protected int protectedField;
        private int privateField;

        public void ShowFields()
        {
            Console.WriteLine(
                $"Public: {publicField}, "
                    + $"Protected: {protectedField} "
                    + $"Private {privateField}"
            );
        }
    }

    class DerivedClass : BaseClass
    {
        public void AccesFields()
        {
            publicField = 1;
            protectedField = 2;
            // CAUSES AN ERROR
            // privateField = 3;
        }
    }
}
