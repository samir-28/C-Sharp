using System;

namespace Project3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello Its me samir");


            TestClass testClass = new TestClass();
            int c = testClass.a;
            int v = testClass.b;
            testClass.TestFun();
            int result = testClass.Add(c, v);
            Console.WriteLine("Sum of a and b is: " + result);
        }
    }


    public class TestClass
    {
        public int a = 10;
        public int b = 20;
        public void TestFun()
        {
            Console.WriteLine("Value of a: " + a);
            Console.WriteLine("Value of b: " + b);
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

    }

}


