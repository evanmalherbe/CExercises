using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisesb
{
    internal class Exercise6
    {
        public static void Exercise_6()
        {
            // 6 - Add user entered numbers
            var number = 0;

            while (true)
            {
                Console.WriteLine("Enter 2 or more numbers and I will add them. Enter 'ok' to finish.");

                var input = Console.ReadLine();

                if (input != "ok")
                {
                    number += Int32.Parse(input);
                }
                else if (input == "ok")
                    break;
            }

            Console.WriteLine(number);
        }
    }
}
