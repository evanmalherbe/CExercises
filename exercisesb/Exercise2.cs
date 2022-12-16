using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace exercisesb
{
    internal class Exercise2
    {
        public static void Exercise_2()
        {
            // Reverse characters of user entered string

            Console.WriteLine("Please enter a name: ");
            var name = Console.ReadLine();
            Console.Write("Name: ");

            var count = name.Length;

            while (count > 0)
            {
                Console.Write(name[count - 1]);
                count--;
            }

            Console.WriteLine();
        }
    }
}
