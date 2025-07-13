using System;

namespace GoTostatement
{
     class Program
    {
        public static void Main()
        {
            Console.WriteLine("Starting Main method");
            Console.WriteLine("\nUsing goto statement");
            UseGoto();
            Console.WriteLine("\nUsing break statement");
            UseBreak();
            Console.WriteLine("\nUsing return statement");
            UseReturn();
            Console.WriteLine("Ending Main method");
        }


        public static void UseGoto()
        {

            int x = 5;
            if (x == 5)
            {
                goto skip;
            }
            Console.WriteLine("This will not print because x==5");
        skip:
            Console.WriteLine("Exited the conditional statement  with Goto -> Skip");

        }


        public static void UseBreak()
        {
            int y = 5;
            switch(y)
            {
               case 1:
                    Console.WriteLine("Y is 1");
                    break;
               case 2:
                    Console.WriteLine("Y is 2");
                    break;
               case 3:
                    Console.WriteLine("Y is 3");
                    break;
               case 4:
                    Console.WriteLine("Y is 4");
                    break;
               case 5:
                    Console.WriteLine("Y is 5");
                    break;
               default:
                    Console.WriteLine("Y is not 1 or 5");
                    break;
            }
            Console.WriteLine("Exited switch code block using break");


        }


        public static void UseReturn()
        {
            int z = 5;
            if (z == 5)
            {
                return;
            }
            Console.WriteLine("This will not print because z==5");
      
            Console.WriteLine("This line will never be recahed if z==5");

        }

    }
}
