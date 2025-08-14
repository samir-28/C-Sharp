using System;


namespace ExceptionHandling
{
    public static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int result = Divide(10, 0);
                Console.WriteLine($"Result: {result}");
                int[] a = { 1, 2, 3, 4 };
                Console.WriteLine($"Array element: {a[6]}"); // This will throw an IndexOutOfRangeException
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error : Cannot divide by Zero");
            }
            catch (IndexOutOfRangeException ex)
            {
                throw ex;
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}"); //throw ex
            }
            finally
            {
                Console.WriteLine("Finally Execution completed.");
            }

            Console.WriteLine("Program continues after try-catch-finally block.");
        }

        static int Divide(int numerator, int dinominator)
        {
            if (dinominator == 0)
            {
                // manuallly throwing an exception
                throw new DivideByZeroException();
            }
            else
            {
                return numerator / dinominator;
            }
        }
    }
}
