using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisesb
{
    public class DateDemos
    {
        public static void DateMethods()
        {
            // Date / Time
            // Datetime objects are immutable
            Console.WriteLine("Date Methods demo:");
            
            DateTime dateT = new DateTime(2015, 1, 1);
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;

            // To change, use method (since datetime objects are immutable
            DateTime addHour = dateT.AddHours(1);
            Console.WriteLine("Date time plus one hour: " + addHour);

            Console.WriteLine("Date time: " + dateT);
            Console.WriteLine("Now: " + now.Hour + " " + now.Minute);
            Console.WriteLine("Today: " + today);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("dd-MM-yyyy"));

            Console.WriteLine("");
        }
        
    }
}
