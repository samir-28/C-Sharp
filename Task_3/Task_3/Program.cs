
//A base class Animal with a private field, a property , a method and a constructor .
//A derived class Dog that uses the base keyword and  a new field , and overload a method.
//in main(),create an object and call both version of the method.



using System;


namespace Task_3
{
    public class Animal
    {
        private string name;

        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    Console.WriteLine("Name cannot be empty");
            }
        }


        public Animal(string a_name)
        {
            Name = a_name;
        }

        public void DisplayAnimalInfo()
        {
            Console.WriteLine($"Animal Name: {Name}");
        }
    }

    public class Dog : Animal
    {
        private string color;

        public Dog(string a_name, string d_color) : base(a_name)
        {
            color = d_color;
        }

        public void DisplayDogInfo()
        {
            base.DisplayAnimalInfo();
            Console.WriteLine($"Animal Color:{color}");
        }
        public void DisplayAnimalInfo(string color)
        {
            base.DisplayAnimalInfo();
            Console.WriteLine($"Animal Color: {color}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before overloading :");
            Dog dog = new Dog("Kaley","Black");
            Console.WriteLine("");
            Console.WriteLine("Before overloading Dog name and Color:");
            dog.DisplayDogInfo();

            Console.WriteLine("");
            Console.WriteLine("After overloading Dog name and Color:");
            dog.DisplayAnimalInfo("Brown");

        }
    }
}
