using System;

namespace Delegates
{   
    public delegate void Contractor(string message);

    public class Workers
    {
        public void WallBuilder(string task)
        {
            Console.WriteLine("Building Walls:"+ task);
        }

        public void Painter(string task) 
        {
            Console.WriteLine("Painting Walls:" + task);
        } 

        public void Electrician(string task)
        {
            Console.WriteLine("Installing Electricity:" + task);
        }
        public void Plumbing(string task)
        {
            Console.WriteLine("Plumbing Walls:" + task);
        }

        public void Cleaning(string task)
        {
            Console.WriteLine("Cleaning Tiles:" + task);
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
         
             
            Workers workers = new Workers();

            // create a delegate instance and assign it to the method
            Contractor contractor = new Contractor(workers.WallBuilder);

            // invoke the delegate
            contractor("Bed_Room");

            //add more methods to the delegate (Multicast delegates)
            contractor += workers.Painter;
            contractor += workers.Electrician;
            //contractor -= workers.Painter;

            // invoke the delegate again
            contractor("Living Room");

            contractor += workers.Plumbing;
            contractor += workers.Cleaning;

            contractor("Kitchen");
        }
    }
}
