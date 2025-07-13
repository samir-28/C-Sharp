using System;

namespace Inheritance
{
    // This program demonstrates various types of inheritance in C#:
    // - Single Inheritance
    // - Multilevel Inheritance
    // - Interface-based Multiple Inheritance

    // Entry point of the program
    public static class Program // ✅ Fixed typo from "Progeam" to "Program"
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // Demonstrating Single Inheritance
            DerivedClass deriveClass = new DerivedClass();
            deriveClass.BaseMethod();       // Inherited from BaseClass
            deriveClass.DerivedMethod();    // Own method

            // Demonstrating Interface-based Multiple Inheritance
            MultipleInheritance multipleInheritance = new MultipleInheritance();
            multipleInheritance.FirstMethod();   // From IFirst
            multipleInheritance.SecondMethod();  // From ISecond
            multipleInheritance.ThirdMethod();   // From BaseClass3

            // Demonstrating Multilevel Inheritance
            DerivedClass1 derivedClass1 = new DerivedClass1();
            derivedClass1.BaseMethod();          // From BaseClass1
            derivedClass1.IntermediateMethod();  // From IntermediateClass
            derivedClass1.DerivedMethod();       // Own method

            // Demonstrating Interface-based Multiple Inheritance with another example
            DerivedClass2 derivedClass2 = new DerivedClass2();
            derivedClass2.BaseMethod();          // From BaseClass2
            derivedClass2.FirstMethod();         // From IFirst1
            derivedClass2.SecondMethod();        // From ISecond2
        }
    }

    // ---------------------- SINGLE INHERITANCE ----------------------

    // Base class
    class BaseClass
    {
        public void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }
    }

    // Derived class inheriting from BaseClass
    class DerivedClass : BaseClass
    {
        public void DerivedMethod()
        {
            Console.WriteLine("Derived Method from DerivedClass");
        }
    }

    // ---------------------- MULTIPLE INHERITANCE (USING INTERFACES) ----------------------

    // First interface
    public interface IFirst
    {
        void FirstMethod();
    }

    // Second interface
    public interface ISecond
    {
        void SecondMethod();
    }

    // Base class for shared behavior
    public class BaseClass3
    {
        public void ThirdMethod()
        {
            Console.WriteLine("Third  Method from BaseClass1");
        }
    }

    // Class implementing multiple interfaces and extending BaseClass3
    class MultipleInheritance : BaseClass3, IFirst, ISecond
    {
        public void FirstMethod()
        {
            Console.WriteLine("First Method");
        }

        public void SecondMethod()
        {
            Console.WriteLine("Second Method");
        }
    }

    // ---------------------- MULTILEVEL INHERITANCE ----------------------

    // Base class
    class BaseClass1
    {
        public void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }
    }

    // Intermediate class inheriting from BaseClass1
    class IntermediateClass : BaseClass1
    {
        public void IntermediateMethod()
        {
            Console.WriteLine("InterMediate Method");
        }
    }

    // Derived class inheriting from IntermediateClass (which inherits BaseClass1)
    class DerivedClass1 : IntermediateClass
    {
        public void DerivedMethod()
        {
            Console.WriteLine("Derived Method");
        }
    }

    // ---------------------- INTERFACE + INHERITANCE MIXED EXAMPLE [Hybrid]----------------------

    // First interface
    public interface IFirst1
    {
        void FirstMethod();
    }

    // Second interface
    public interface ISecond2
    {
        void SecondMethod();
    }

    // Base class
    public class BaseClass2
    {
        public void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }
    }

    // Class implementing interfaces and inheriting base class
    class DerivedClass2 : BaseClass2, IFirst1, ISecond2
    {
        public void FirstMethod()
        {
            Console.WriteLine("First Method");
        }

        public void SecondMethod()
        {
            Console.WriteLine("Second Method");
        }
    }
}
