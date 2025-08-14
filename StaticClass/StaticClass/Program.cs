using System;

namespace StaticClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum = MathUtilities.Add(3, 5);
            int factorial = MathUtilities.Factorial(5);
            Console.WriteLine($"sum:{sum}");
            Console.WriteLine($"Factorial of 5:{factorial}");
        }
    }

    //utility class
    public static class MathUtilities

    {   
        public static int Add(int a, int b) // a static method for adding two integers
        {
            return a + b;
        }
        public static int Factorial(int num)
        {
         
            if (num <=1) return 1;
            return num * Factorial(num-1);

        }

    }
}