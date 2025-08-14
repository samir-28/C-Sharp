using System;

namespace Task2
{
    public class Xenium
    {
        private string teacher;
        private string classmonitor;
        private string bestfriend;

        public string Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }

        public string ClassMonitor
        {
            get { return classmonitor; }
            set { classmonitor = value; }
        }

        public string BestFriend
        {
            get { return bestfriend; }
            set { bestfriend = value; }
        }

        public Xenium(string teacher1, string classmonitor1, string bestfriend1)
        {
            Teacher = teacher1;
            ClassMonitor = classmonitor1;
            BestFriend = bestfriend1;
        }

        public void Display()
        {
            Console.WriteLine($"Teacher Name:{teacher} ClassMonitor Name:{classmonitor} BestFriend Name:{bestfriend}");
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                Xenium xenium = new Xenium("Ram", "Samir", "Hari");
                xenium.Display();

                xenium.Teacher = "Shyam";
                xenium.ClassMonitor = "Sita";   
                xenium.BestFriend = "Gita";
                xenium.Display();   
            }
        }
    }
}
