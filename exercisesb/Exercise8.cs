using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisesb
{
    internal class Exercise8
    {
        public static void Exercise_8()
        {
            // 8
            Console.WriteLine("Enter a number and I will calculate the factorial of that number: ");
            var input = Int32.Parse(Console.ReadLine());
            var workInput = input;
            var answer = input;

            // e. 5 => 5 x 4 x 3 x 2 x 1 = 120
            while (workInput > 1)
            {
                answer *= (workInput - 1);
                Console.WriteLine(answer);

                workInput--;
            }

            Console.WriteLine(input + "! = " + answer);
        }
    }
}
