//using System;
//using System.IO;

//namespace FileHandlingTask
//{
//    public static class Program
//    {
//        static void Main(string[] args)
//        {
//            string directoryPath = "C:\\Test1";
//            if (!Directory.Exists(directoryPath))
//            {
//                Directory.CreateDirectory(directoryPath);
//            }

//            //writing to a file
//            string filePath = Path.Combine(directoryPath, "test1.txt");
//            string content = "This a file from test1 folder";

//            File.WriteAllText(filePath, content);  //creates or overides the file
//            Console.WriteLine("File written successfully.");


//            //reading from a file
//            if (File.Exists(filePath))
//            {

//                content = File.ReadAllText(filePath);
//                Console.WriteLine("File content from Test1");
//                Console.WriteLine(content);
//            }
//            else
//            {
//                Console.WriteLine("File does not exist.");
//            }

//            string directoryPathSecond = "C:\\Test2";
//            if (!Directory.Exists(directoryPathSecond))
//            {
//                Directory.CreateDirectory(directoryPathSecond);
//            }

//            //writing to a file
//            string filePathSecond = Path.Combine(directoryPathSecond, "test2.txt");
//            string content2 = File.ReadAllText(filePath);


//            File.WriteAllText(filePathSecond, content2);  //creates or overides the file
//            Console.WriteLine("File written successfully in Test2.");

//            if (File.Exists(filePath))
//            {
//                //deleting a file
//                File.Delete(filePath);
//                Console.WriteLine("File deleted successfully.");
//            }
//            else
//            {
//                Console.WriteLine("File does not exist to delete.");
//            }

//        }
//    }
//}


using System;
using System.IO;

namespace FileHandlingTask
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = "C:\\Test1";
            string filePath = Path.Combine(directoryPath, "test1.txt");
            string content = "This a file from test1 folder";

            // Create Test1 directory and write to file
            Directory.CreateDirectory(directoryPath);
            File.WriteAllText(filePath, content);
            Console.WriteLine("File written successfully in Test1.");

            // Read content and display
            if (File.Exists(filePath))
            {
                content = File.ReadAllText(filePath);
                Console.WriteLine("File content from Test1:");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File does not exist.");
                return;
            }

            // Create Test2 directory and copy content
            string directoryPathSecond = "C:\\Test2";
            string filePathSecond = Path.Combine(directoryPathSecond, "test2.txt");

            Directory.CreateDirectory(directoryPathSecond);
            File.WriteAllText(filePathSecond, content);
            Console.WriteLine("File written successfully in Test2.");

            // Delete original file
            File.Delete(filePath);
            Console.WriteLine("File deleted successfully from Test1.");
        }
    }
}

