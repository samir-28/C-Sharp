using System;

namespace HirerchicalInheritance 
{
    
    class BaseClass
    {
        public void BaseMethod()
        {
            Console.WriteLine("This is base method");
        }
    }

    class DerivedClass1 : BaseClass
    {
        public void DerivedMethod1()
        {
            Console.WriteLine("This Is Derived Method-1");
        }
    }

    
    class DerivedClass2 : BaseClass
    {
        public void DerivedMethod2()
        {
            Console.WriteLine("This Is Derived Method-2");
        }
    }

 
    class DerivedClass3 : BaseClass
    {
        public void DerivedMethod3()
        {
            Console.WriteLine("This Is Derived Method-3");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hierarchical Inheritance\n");

           
            DerivedClass1 derived1 = new DerivedClass1();
            derived1.BaseMethod();           
            derived1.DerivedMethod1();      
            Console.WriteLine(); 

            
            DerivedClass2 derived2 = new DerivedClass2();
            derived2.BaseMethod();           
            derived2.DerivedMethod2();       

            Console.WriteLine(); 

            
            DerivedClass3 derived3 = new DerivedClass3();
            derived3.BaseMethod();          
            derived3.DerivedMethod3();     
        }
    }
}
