using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class Mother
{
    static async Task Main(string[] args)
    {
        // Synchronous 
        Stopwatch requestStopwatch = Stopwatch.StartNew();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Synchronous Method Start");
        var first = FirstChild();
        var second = SecondChild();
        var third = LastChild();
        Console.WriteLine($"{first}\n{second}\n{third}");
        Console.WriteLine();
        requestStopwatch.Stop();
        Console.WriteLine($"Requests handled in {requestStopwatch.Elapsed.TotalSeconds} second. \n");

        // Asynchronous with Task
        Stopwatch requestStopwatch2 = Stopwatch.StartNew();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Asynchronous Method start");
        Task task1 = Task.Run(() => { Console.WriteLine(FirstChild()); });
        Task task2 = Task.Run(() => { Console.WriteLine(SecondChild()); });
        Task task3 = Task.Run(() => { Console.WriteLine(LastChild()); });
        Task.WaitAll(task1, task2, task3);
        Console.WriteLine($"Requests handled in {requestStopwatch2.Elapsed.TotalSeconds} second.\n");

        // Async/Await
        Stopwatch requestStopwatch3 = Stopwatch.StartNew();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Asynchronous Method with async/await Stop");
        await Task.Run(() => { Console.WriteLine(FirstChild()); });
        Task t2 = Task.Run(() => { Console.WriteLine(SecondChild()); });
        Task t3 = Task.Run(() => { Console.WriteLine(LastChild()); });
        Task.WaitAll(t2, t3);
        Console.WriteLine("Asynchronous Method async/await Stop");
        Console.WriteLine($"Requests handled in {requestStopwatch3.Elapsed.TotalSeconds} second.\n");

        Console.ReadKey();
    }

    public static string FirstChild()
    {
        Console.WriteLine("Start First Child");
        Thread.Sleep(6000); 
        Console.WriteLine("Stop First Child");
        return "Bringing rice";
    }

    public static string SecondChild()
    {
        Console.WriteLine("Start Second Child");
        Thread.Sleep(8000); 
        Console.WriteLine("Stop Second Child");
        return "Bringing water";
    }

    public static string LastChild()
    {
        Console.WriteLine("Start Last Child");
        Thread.Sleep(10000);
        Console.WriteLine("Stop Last Child");
        return "Bringing utensils";
    }
}
