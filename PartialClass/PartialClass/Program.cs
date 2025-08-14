using System;

namespace PartialClass
{
    public partial class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1 called");
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.Method2();
            myClass.Method1();  
           
        }
    }
}

