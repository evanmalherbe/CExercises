using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisesb
{
    internal class Exercise7
    {
        public static void Exercise_7()
        {
            // 7 - How many numbers are divisible by 3
            var count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
