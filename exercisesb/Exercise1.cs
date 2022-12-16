using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisesb
{
    internal class Exercise1
    {
        public static void Exercise_1()
        {
            //Facebook exercise - Lists
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Please type a name or type 'x' to finish: ");
                var name = Console.ReadLine();

                if (name != "" && name != "x")
                {
                    names.Add(name);

                    continue;
                }
                break;
            }

            Console.WriteLine();

            switch (names.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.Write(names[0] + " likes your post. ");
                    break;
                case 2:
                    Console.Write(names[0] + " and " + names[1] + " like your post. ");
                    break;
                default:
                    var others = names.Count - 2;

                    Console.Write(names[0] + ", " + names[1] + " and " + others + " others like your post. ");
                    Console.WriteLine();
                    break;
            }
        }
    }

    
}
