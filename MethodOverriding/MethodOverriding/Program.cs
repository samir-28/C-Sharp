using System;

namespace MethodOverriding
{
    public class Animal
    {
        public virtual void Speak() //Base class method
        {
            Console.WriteLine("Animal Speaks");

        }
    }

    public class Dog : Animal 
    {
        public override void Speak()  // override the base class method
        {
            Console.WriteLine("Dog Barks");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Animal animal = new Animal();
            animal.Speak();

            Animal mydog = new Dog();
            mydog.Speak(); // Dog barks(method overriding in action)

            Dog mydog2=new Dog();
            mydog2.Speak();
        }

    }
}
 