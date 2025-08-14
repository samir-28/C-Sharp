using System;

namespace SealedClass
{   

    public sealed class MySealedClass
    {

        private readonly string message = "Hello ,I am a sealed class";
        public void DisplayMessage()
        {
            Console.WriteLine($"Message from sealed class:{message}");
        }
    }
     
    public static class Program
    {
        static void Main()
        {   
            MySealedClass sealedInstance = new MySealedClass();
            sealedInstance.DisplayMessage();
        }
    }
}
