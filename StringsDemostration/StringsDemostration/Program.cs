using System;

namespace StringsDemostration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            Console.WriteLine(s[0]);
            Console.WriteLine(s.Length); 
            Console.WriteLine(s.IndexOf('e'));
            Console.WriteLine(s.LastIndexOf('l'));
            Console.WriteLine(s.Contains("lo"));
            Console.WriteLine(s.StartsWith("He"));
            Console.WriteLine(s.EndsWith("lo"));
            Console.WriteLine(s.Substring(1,3));
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());



            string str1 = "Hello";
            string str2 = "world";
            string result = str1 + " " + str2;
            Console.WriteLine(result);


            string name = "Samir";
            string name1 = "Revey";
            int age = 30;
            int age1 = 20;
            double amount = 999.99;
            string message = $"My name is {name} and I am {age} years old";
            Console.WriteLine(message);
            string message1 = $"Dear {name}your account is deposited by:Rs{amount}";
            Console.WriteLine(message1);
            Console.WriteLine($"My name is {name1} and I am {age1} years old");
            Console.WriteLine($"Concatinated string is {result}.");

        }
    }
}
