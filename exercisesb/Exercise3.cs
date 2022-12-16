using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace exercisesb
{
    internal class Exercise3
    {
        public static void Exercise_3()
        {
           // 3
            Console.WriteLine("Please enter 5 different numbers: ");

            var count = 1;
            var numbers = new List<int>();

            while (count <= 5)
            {
                var usedBefore = false;
                Console.Write("> ");
                var num = Int32.Parse(Console.ReadLine());

                foreach (var n in numbers)
                {
                    if (n == num)
                    {
                        Console.WriteLine("You've entered that number before. Please enter a different number. ");
                        usedBefore = true;
                        break;
                    }
                }

                if (usedBefore == false)
                {
                    count++;
                    numbers.Add(num);
                }
            }

            numbers.Sort();
            Console.WriteLine("Thank you. Your numbers were: ");
            foreach (var x in numbers)
                Console.Write(x);
            Console.WriteLine();
        }
    }
}
