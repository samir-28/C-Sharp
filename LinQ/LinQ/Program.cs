using System;
using System.Collections.Generic;
using System.Linq;



namespace LinQ
{
    public class Program
    {
        static void Main()
        {
            Student student = new Student();
            student.Address = "Lalitpur";
            student.StudentId = 1;
            student.Name = "Samir";
            student.College = "NSC";

            Student student2 = new Student();
            student2.Address = "Kavre";
            student2.StudentId = 2;
            student2.Name = "Aajay";
            student2.College = "Baylor";


            Student student3 = new Student();
            student3.Address = "Kathmandu";
            student3.StudentId = 3;
            student3.Name = "Rohan";
            student3.College = "Patan";


            Student student4 = new Student();
            student4.Address = "Bhaktapur";
            student4.StudentId = 4;
            student4.Name = "Sumit";
            student4.College = "Liverpool";

            Student student5 = new Student();
            student5.Address = "Lalitpur";
            student5.StudentId = 5;
            student5.Name = "Shyam";
            student5.College = "NSC";


            List<Student> students = new List<Student>();
            students.Add(new Student { Address = "Lalitpur", StudentId = 0, Name = "John", College = "NSC" });
            students.Add(student);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);  
            students.Add(student5);


            var result = from s in students
                         where s.College == "NSC" && s.Address == "Lalitpur"
                         select s;

            foreach (var data in result)
            {
                Console.WriteLine($"Name: {data.Name} lives in {data.Address} and studied at {data.College}");
            }


            //Linq to array
            int[] numbers1 = { 1, 2, 3, 4, 5 };

            var query1 = from n in numbers1
                         where n % 2 == 0
                         select n;
            Console.WriteLine("\n Even numbers in the array:");
            foreach (var num in query1)
            {
                Console.WriteLine(num);
            }


            //Linq to List
            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5 };

            //LinQ query  syntax
            var query2 = from num in numbers2
                         where num > 3
                         select num;

            Console.WriteLine("\n Numbers greater than 3 in the list:");
            foreach (var n in query2)
            {
                Console.WriteLine(n);
            }

            //LinQ method

            var evenNumbers = numbers2.Where(n => n % 2 == 0);
            var greaterThanThree = numbers2.Where(n => n > 3);

            Console.WriteLine(" \n Even numbers in the list:");
            foreach (var num in greaterThanThree)
            {
                Console.WriteLine(num);
            }




        }


        public class Student
        {
            public string Address { get; set; }
            public int StudentId { get; set; }
            public string Name { get; set; }
            public string College { get; set; }
        }
    }
}
