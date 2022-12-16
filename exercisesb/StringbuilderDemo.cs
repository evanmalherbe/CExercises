using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisesb
{
    public class StringbuilderDemo
    {
        public static void StringBuilderMethods()
        {
            // Strings are immutable, so can use StringBuilder to modify strings instead. StringBuilder is mutable.
            // Can chain methods, since each method returns a new stringbuilder

            StringBuilder builder = new StringBuilder()
            .Append('-', 10)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-', 10)
            .Replace('-', '+')
            .Remove(0, 9)
            .Insert(0, new string('>', 10));
            Console.WriteLine(builder);

            Console.WriteLine("First char: " + builder[0]);
            
        }
    }
}
