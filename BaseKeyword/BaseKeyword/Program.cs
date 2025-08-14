//using System;

//namespace BaseKeyword
//{
//    public class ParentClass
//    {
//        public string Message { get; set; }

//        public ParentClass(string message)
//        {
//            Message = message;
//        }   

//        public void DisplayMessage()

//        {
//            Console.WriteLine(Message);
//            Console.WriteLine("Message from the parent classs");
//        }

//        public virtual void Test()
//        {
//            Console.WriteLine("THis is message  in ParentClass");
//        }
//    }

//    public class ChildClass : ParentClass
//    {
//        public ChildClass(string message) : base(message)
//        {

//        }

//        public void DisplayChildMessaage()
//        {
//            base.DisplayMessage();
//            Console.WriteLine("Message from the child class");
//        }

//        public override void Test()
//        {
//            Console.WriteLine("This is message in ChildClass");
//        }
//    }


//    class Program
//    {
//        static void Main()
//        {
//            string message = "Hello from main";
//            ChildClass child = new ChildClass(message);

//            child.DisplayChildMessaage();
//            child.DisplayMessage();
//        }
//    }
//}

using System;

namespace BaseKeyword
{
    // Parent class
    public class ParentClass
    {
        public string Message { get; set; }

        public ParentClass(string message)
        {
            Message = message;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Parent says: " + Message);
            Console.WriteLine("This is from ParentClass");
        }

        public virtual void Test()
        {
            Console.WriteLine("Test method in ParentClass");
        }
    }

    // Child class
    public class ChildClass : ParentClass
    {
        public ChildClass(string message) : base(message)
        {
            // message is passed to ParentClass constructor
        }

        public void DisplayChildMessaage()
        {
            base.DisplayMessage(); // calling ParentClass method
            Console.WriteLine("This is from ChildClass");
        }

        public override void Test()
        {
            Console.WriteLine("Test method in ChildClass");
        }
    }

    class Program
    {
        static void Main()
        {
            string message = "Hello from Main";
            ChildClass child = new ChildClass(message);

            Console.WriteLine("Calling DisplayChildMessaage():");
            child.DisplayChildMessaage();

            Console.WriteLine("\nCalling DisplayMessage() directly:");
            child.DisplayMessage();

            child.Test(); // Calls the overridden method in ChildClass
        }
    }
}
