using System;
using System.ComponentModel;

namespace Constructors
{
    public class Person
    {
        public string Name;
        public int Age;
        public static string Category;

        //Default constructor
        public Person()
        {
            Name = "Unknown";
            Age = 20;
            //Category = "Others";
        }

        // Parmaterized constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //copy constructor
        public Person(Person person)
        {
            Name = person.Name;
            Age = person.Age;
        }

        //static constructor
         static Person()
        {
            Category = "Human";
        }

        //Private constrctor (used within class only...)
        private Person(int age, string name)
        {
            Name = name;
            Age = age;
        }

        // Static constructor
        public static Person CreateSpecialPerson(int age, string name)
        {
            return new Person(age, name);
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}, Age:{Age},Category:{Category}");
        }

        //Destructor
        ~Person()
        {
            Console.WriteLine("Hello Bye");
        }

        public class Program
        {
            public static void Main()
            {
                //Default constructor
                Person p1 = new Person();
                p1.DisplayInfo();

                //Paramaterized constructor
                Person p2 = new Person("John", 30);
                p2.DisplayInfo();


                //Copy constructor
                Person p3 = new Person(p2);
                p3.DisplayInfo();

                //Static constructor (runs automatically before any static member object creation )
                Console.WriteLine($"Category from static constructor:{Person.Category}");

                //Def constructor
                Person p4 = Person.CreateSpecialPerson(100, "Special");
                p4.DisplayInfo();
            }
        }
        
    }
}
