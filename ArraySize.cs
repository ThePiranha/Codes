using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);            
            list.Add(8);
            list.Add(9);
            list.Add(10);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);

            //list.Sort(); //uncomment this to sort item

            // Loop through List with foreach.
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Second item in list is: " + list[1]);

            Console.ReadLine();
        }
    }
}