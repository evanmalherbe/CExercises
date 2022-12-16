using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisesb
{
    public class ArraysDemo
    {
        public static void ArrayMethods()
        {
            // Arrays
            Console.WriteLine("Array methods: ");

            var numbers = new[] { 12, 34, 2, 5, 6, 7 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()

            var index = Array.IndexOf(numbers, 5);

            Console.WriteLine("Index of 5 is: " + index);

            // Clear
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");

            foreach (var num in numbers)
                Console.WriteLine(num);

            // Copy()
            var another = new int[3];

            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of copy");
            foreach (var n in another)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of sort method");
            foreach (var x in numbers)
                Console.WriteLine(x);

            Console.WriteLine("");
        }

        public static void ListMethods()
        {
            // Lists
            Console.WriteLine("List methods: ");

            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(7);

            foreach (var num in numbers)
                Console.WriteLine(num);

            numbers.AddRange(new int[3] { 3, 4, 5 });

            Console.WriteLine();
            foreach (var num2 in numbers)
                Console.WriteLine(num2);

            Console.WriteLine();
            Console.WriteLine("Index of 7: " + numbers.IndexOf(7));
            Console.WriteLine();
            Console.WriteLine("Last index of 4: " + numbers.LastIndexOf(4));
            Console.WriteLine("Count: " + numbers.Count);

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 4)
                    numbers.Remove(numbers[i]);
            }

            foreach (var number in numbers)
                Console.WriteLine(number);

            numbers.Clear();

            Console.WriteLine("Count: " + numbers.Count);
            Console.WriteLine("");
        }
    }
}
