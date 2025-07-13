using System;

namespace EncapsulationProperties
{

    public class Person
    {
        private string fullname; //private field

        //property to get and set the name  
        public string Name
        {
            get
            {
                if (fullname == "samir") 
                { 
                    return fullname; // return the value of private varibale
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // validate the input
                    fullname = value;  // Assign the value to the private variable
                else
                    Console.WriteLine("Name cannot be null.");


            }
        }

        // Auto implement property for Age
        public int Age { get; set; }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Encapsulation Properties");
            Console.WriteLine("");
            Person person = new Person();
            person.Name = "samir"; // Set the name using property

            //Getting the name using property
            Console.WriteLine($"Name: {person.Name}"); // Output: Name: null

            person.Age = 25; // Set the age using auto-implemented property
            Console.WriteLine($"Age: {person.Age}"); // Output: Age: 25 

            // Attempt to set an invalid name
            person.Name = "";// Output: Name cannot be null or empty.


        }
    }
}
