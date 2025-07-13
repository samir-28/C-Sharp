using System;

namespace StringTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname = "Samir";
            string lname = "Bajgain";
            float amount = 1499.9f;
            Console.WriteLine($"Dear cutstomer,{fname} {lname} your account has been credited by Rs {amount}.Thank You!");
            Console.WriteLine($"Dear cutstomer,{fname+" "+lname} your account has been credited by Rs {amount}.Thank You!");


        }
    }
}
