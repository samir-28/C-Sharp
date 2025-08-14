using System;
using System.IO;

namespace FileHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = "C:\\FileHandling";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            //writing to a file
            string filePath = Path.Combine(directoryPath, "text.txt");
            string content = "Hello,File I/O in c#";

            File.WriteAllText(filePath, content);  //creates or overides the file
            Console.WriteLine("File written successfully.");


            //reading from a file
            if (File.Exists(filePath))
            {

                content = File.ReadAllText(filePath);
                Console.WriteLine("File content");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }

            //appending to a file
            string contentToAdd = "Adding apend content.";
            File.AppendAllText(filePath, Environment.NewLine + contentToAdd);
            Console.WriteLine("Content append Successfully");

            //writing to a file with stream writer
            using (StreamWriter writer = new StreamWriter(filePath, true)) //true to append  //fasle makes override ie remove previous content
            {
                writer.WriteLine("Line 1: Hello,StreamWriter.");
                writer.WriteLine("Line 2: writing using stream writer.");
            }

            //reading from a file with stream reader
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        //    if (File.Exists(filePath))
        //    {
        //        //deleting a file
        //        File.Delete(filePath);
        //        Console.WriteLine("File deleted successfully.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("File does not exist to delete.");
        //    }
        }


    }
}
