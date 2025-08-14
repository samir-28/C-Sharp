using System;

namespace Enumeration_Enum_
{   
    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum Status
    {
        Created=1,
        Modified=2,
        HardDeleted=3,
        SoftDeleted=4
    }


    public static class Program
    {
        static void Main()
        {   

            DaysOfWeek today= DaysOfWeek.Thursday;  
            Console.WriteLine($"Day of the week Today: {today}");
            Console.WriteLine($"Day of the week Today (Int): {(int)today}");


            var status = Status.HardDeleted;    
            Console.WriteLine($"Status: {status}");
            Console.WriteLine($"Status Today (Int): {(int)status}");
        }
    }
}
