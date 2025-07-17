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

            /*
            Dog myDog = new Dog();
            myDog.MakeSound();

            Cat myCat = new Cat();
            myCat.MakeSound();
            */

            /*
            Employee joe = new Employee("Joe", 36);
            joe.DisplayPersonInfo();
            */

            /*
            Employee joe = new Employee("Joe", 36, "Sales Rep", 12345);
            joe.DisplayEmployeeInfo();
            */

            Manager carl = new Manager("Carl", 45, "Manager", 123123, 7);

            carl.DisplayManagerInfo();

            Console.WriteLine(carl.ToString());

            carl.BecomeOlder(5);

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
            // calling a method from a base class
            base.MakeSound();

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

    public class Person
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        // Base class constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine("Person constructor called");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age {Age}");
        }

        /// <summary>Makes our object older.</summary>
        /// <param name="years">The parameter that indicates the amount of years the object should age.</param>
        /// <returns>Returns new age after aging.</returns>
        public int BecomeOlder(int years)
        {
            Age = Age + years;
            return Age;
        }
    }

    public class Employee : Person
    {
        public string JobTitle { get; private set; }

        public int EmployeeId { get; private set; }

        // Derived class constructor
        public Employee(string name, int age, string jobTitle, int employeeId)
            : base(name, age)
        {
            JobTitle = jobTitle;
            EmployeeId = employeeId;
            Console.WriteLine("Employee (derived class) constructor called");
            JobTitle = jobTitle;
            EmployeeId = employeeId;
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Job Title: {JobTitle}, EmployeeID: {EmployeeId} ");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; private set; }

        public Manager(string name, int age, string jobTitle, int employeeId, int teamSize)
            : base(name, age, jobTitle, employeeId)
        {
            TeamSize = teamSize;
        }

        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Team size: {TeamSize}");
        }
    }
}
