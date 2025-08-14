using System;

namespace Indexer
{


    public class MyCollection
    {

        private string[] data = new string[5]; 
        private string[] second= new string[10];
       
        public string this[int index]    // single indexer
        {
            get
            {
                if (index >= 0 && index < data.Length)
                {
                    return data[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < data.Length)
                {
                    data[index] = value;

                }
                else
                {
                    Console.WriteLine("Index out of bounds.Cannot set value"); 
                }
            }

        }

        public string this[int index, bool secondIndex]  // indexer with two parameters i.e overload
        {
            get
            { 
                if (index >= 0 && index < second.Length)
                {
                    return second[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < second.Length)
                {
                    second[index] = value;

                }
                else
                {
                    Console.WriteLine("Index out of bounds.Cannot set value");
                }
            }

        }
    }


    internal class Program
    {
        static void Main()
        {
            MyCollection mycollection = new MyCollection();

            mycollection[0] = "value at 0 index";
            mycollection[1] = "value at 0 index";

            mycollection[9] = "value at 9 index";
            mycollection[8,true] = "value at 8 index";

            Console.WriteLine(mycollection[0]);
            Console.WriteLine(mycollection[8,true]);
            Console.WriteLine(mycollection[9]);
            Console.WriteLine(mycollection[1]);
        }
    }
}
