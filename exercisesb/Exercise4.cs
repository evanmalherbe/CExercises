using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisesb
{
    public class Exercise4
    {
        public static void Exercise_4()
        {
            Console.WriteLine("Please enter a number or type 'Quit' to finish: ");

            var numbers = new List<int>();

            while (true)
            {
                var usedBefore = false;
                 Console.Write("> ");
                var answer = Console.ReadLine();
                var num = 0;

                if (answer == "Quit" || answer == "quit")
                    break;
                else
                    num = Int32.Parse(answer);

                foreach (var n in numbers)
                {
                    if (n == num)
                    {
                        usedBefore = true;
                        break;
                    }
                }

                if (usedBefore == false)
                {
                    numbers.Add(num);
                }
        }

        Console.WriteLine("Thank you. After removing duplicates, your numbers were: ");
        foreach (var x in numbers)
            Console.WriteLine(x);
            Console.WriteLine();
        }
    }
}
