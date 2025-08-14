using System;

namespace AbstractClass
{
    // This is an abstract class named Animal.
    // we cannot instantiate it directly. 
    public abstract class Animal 
    {
        //Abstract method
        public abstract void MakeSound();   // This is a concrete method that can be used by derived classes.

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
         Console.WriteLine("Woof! Woof!");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Animal animal = new Dog();;
            dog.MakeSound();
            dog.Sleep();


        }
    }
}
