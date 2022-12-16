using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisesb
{
    public class Exercise5
    {
        // 5
        public static void Exercise_5()
        {
            while (true)
                {
                    Console.WriteLine("Please enter a comma-separated list of numbers (5 or more numbers): ");

                    var numberArray = new List<int>();
                    string answer = Console.ReadLine();
                string[] answer2 = answer.Split('\u002C');
                int length = answer.Length;


                    if (answer == "" || length< 10)
                    {
                        Console.WriteLine("Invalid list. Please try again: ");
                        continue;
                    }
                    else
                    {
                        //Console.WriteLine(length);

                        foreach (string str in answer2)
                            numberArray.Add(int.Parse(str));

                       numberArray.Sort();
                        //int length2 = numbers.Count;
                        // Console.Write(length2);

                        foreach (int n in numberArray)
                            Console.Write(n);

                        Console.WriteLine();
                    }

                    break;
                }
        }
        
    }
}
