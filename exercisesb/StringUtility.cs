using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisesb
{
    public class StringUtility
    {
        public static void StringMethods()
        {
            // Strings
            // Strings are immutable. Methods return a new string.

            Console.WriteLine("String methods demo:");

            string fullName = "Evan Malherbe ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            int index = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0, index);
            Console.WriteLine("Firstname: " + firstName);
            string lastName = fullName.Substring(index + 1);
            Console.WriteLine("Lastname: " + lastName);

            // Or easier way
            string[] names = fullName.Split(' ');
            Console.WriteLine("Firstname: " + names[0]);
            Console.WriteLine("Lastname: " + names[1]);

            // Replace
            Console.WriteLine(fullName.Replace("Evan", "Evandren"));

            if (String.IsNullOrWhiteSpace("Bob "))
                Console.WriteLine("Invalid");

            // Convert methods
            string str = "25";
            int age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine("");
        }
        public static string SummariseText(string sentence, int maxLength = 20)
        {
            if (sentence.Length < maxLength)
                return sentence;

            string[] words = sentence.Split(' ');
            int totalChars = 0;
            List<string> summaryWords = new List<string>();

            foreach (string word in words)
            {
                summaryWords.Add(word);

                totalChars += word.Length + 1;

                if (totalChars > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}
