using System;
using System.Collections;

namespace Collections
{
    public class Program
    {

        static void Main(string[] args)
        {
            //queues
            Queue queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue(2);
            queue.Enqueue("Third");


            // Stacks
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("Two");
            stack.Push(3);

            //Arrays
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hello");
            arrayList.Add(21);
            arrayList.Add("Samir");




            Console.WriteLine("Queue contents:");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine("\nStack contents:");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine("\nArrayList contents:");
            foreach (var data in arrayList)
            {
                Console.WriteLine(data);
            }
        }
    }
}
