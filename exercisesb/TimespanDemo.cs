using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace exercisesb
{
    public class TimespanDemo
    {
        public static void TimeMethods()
        {
            // Timespan - creating

            // hours, minutes, seconds
            Console.WriteLine("Timespan methods: ");

            TimeSpan timeSpan = new TimeSpan(1, 2, 3);
            TimeSpan timeSpan1 = new TimeSpan(1, 0, 0);

            // Easier to read - add 1 hour
            TimeSpan timeSpan2 = TimeSpan.FromHours(1);

            // Subtracting 2 datetimes results in a timespan
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMinutes(2);
            TimeSpan duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // Properties
            // Timespan objects are immutable
            // How many minutes in the "timeSpan" object created above
            Console.WriteLine("Minutes: " + timeSpan.Minutes);

            // Total minutes in timeSpan object above
            Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes);

            // Since timespan is immutable, need method to change
            // Add
            Console.WriteLine("Add example: " + timeSpan.Add(new TimeSpan(0, 1, 0)));

            // Subtract
            Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString
            Console.WriteLine("ToString: " + timeSpan.ToString());
            // but Console.WriteLine automatically applies toString to anything you pass to it

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

            Console.WriteLine("");
        }
        
    }
}
