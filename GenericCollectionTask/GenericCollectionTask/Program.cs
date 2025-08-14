using System;
using System.Collections.Generic;

namespace GenericCollectionTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Lists
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            List<string> list1 = new List<string>();
            list1.Add("Samir");
            list1.Add("Bajgain");
            list1.Add("!");

            List<bool> list2 = new List<bool>();
            list2.Add(true);
            list2.Add(false);

            //Queues
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("Samir");
            queue1.Enqueue("Bajgain");
            queue1.Enqueue("!");

            Queue<bool> queue2 = new Queue<bool>();
            queue2.Enqueue(true);
            queue2.Enqueue(false);

            //stacks
            Stack<int> stack = new Stack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);

            Stack<string> stack1 = new Stack<string>();
            stack1.Push("!");
            stack1.Push("Bajgain");
            stack1.Push("Samir");
 
            Stack<bool> stack2 = new Stack<bool>();
            stack2.Push(true);
            stack2.Push(false);

            // Printing output 

            Console.WriteLine("List int");
            Console.WriteLine("No of items in List int: " + list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nList string");
            Console.WriteLine("No of items in List String: " + list1.Count);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nList bool");
            Console.WriteLine("No of items in List bool: " + list2.Count);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nQueue int");
            Console.WriteLine("Before Count: " + queue.Count);
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.WriteLine("After Count: " + queue.Count);

            Console.WriteLine("\nQueue string");
            Console.WriteLine("Before Count: " + queue1.Count);
            while (queue1.Count > 0)
            {
                Console.WriteLine(queue1.Dequeue());
            }
            Console.WriteLine("After Count: " + queue1.Count);

            Console.WriteLine("\nQueue bool");
            Console.WriteLine("Before Count: " + queue2.Count);
            while (queue2.Count > 0)
            {
                Console.WriteLine(queue2.Dequeue());
            }
            Console.WriteLine("After Count: " + queue2.Count);

            Console.WriteLine("\nStack int");
            Console.WriteLine("Before Count: " + stack.Count);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine("After Count: " + stack.Count);

            Console.WriteLine("\nStack string");
            Console.WriteLine("Before Count: " + stack1.Count);
            while (stack1.Count > 0)
            {
                Console.WriteLine(stack1.Pop());
            }
            Console.WriteLine("After Count: " + stack1.Count);

            Console.WriteLine("\nStack bool");
            Console.WriteLine("Before Count: " + stack2.Count);
            while (stack2.Count > 0)
            {
                Console.WriteLine(stack2.Pop());
            }
            Console.WriteLine("After Count: " + stack2.Count);
        }
    }
}
