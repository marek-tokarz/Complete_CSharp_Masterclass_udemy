namespace BasicsOfInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Dog myDog = new Dog();
            myDog.Bark();
            myDog.Eat();
            */

            BaseClass baseClass = new BaseClass();
            baseClass.ShowFields();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.AccesFields();
            derivedClass.ShowFields();

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
    }

    // Derived Class
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    // Two classes (Dog and Cat) derive from a base class (Animal)
    // This is hierarchical inheritance
    class Cat : Animal
    {
        public void Meaow()
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
