using System;
using System.Collections.Generic;

namespace GenericCollections
{
    //Generic class
    class Box<T>
    {
        public T value;
        public void show()
        {
            Console.WriteLine($"Value:{value}");
        }

        //Generic method
        public void Print<T>(T data)
        {
            Console.WriteLine($"Extra:{data}");

        }

        public T PrintSecond<T>(T data)
        {
            Console.WriteLine($"Extra Second:{data}");
            return (T)data;

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Box<string> box1 = new Box<string>();
            box1.value = "samir";
            box1.show();
            box1.Print<int>(100);

            Box<int> box2 = new Box<int>();
            box2.value = 99;
            box2.show();
            box2.Print<string>("Bajgain");

            Box<float> box3 = new Box<float>();
            box3.value = 1.1f;
            box3.show();
            box3.PrintSecond<float>(9.9f);

            List<int> ints = new List<int>();
            Queue<int> queue = new Queue<int>();
            Stack<int> stack = new Stack<int>();  


        }
    }
}
