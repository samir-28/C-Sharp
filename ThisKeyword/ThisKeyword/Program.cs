using System;

namespace ThisKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person = new Person("samir", 20);
            person.DisplayInfo();

            People people = new People();
            people.DisplayPeopleInfo();
        }
    }
      
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {this.name}, Age: {this.age}");
        }
    }
    public class People
    {
        private string name;
        private int age;
        // Calling another constructor (constructor chaining)

        public People() : this("unknown:", 0)
        {
        }

        public People(string name, int age)
        {
            this.name = "Default Name";
            this.age = 0;
        }

        public void DisplayPeopleInfo()
        {
            Console.WriteLine($"Name: {this.name}, Age: {this.age}");
        }

    }
}




