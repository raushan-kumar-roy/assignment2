using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    public static class daysOfWeek
    {
        public static void Days(int month, int day, int year)
        {



            string[] days = { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };

            int dayIndex = Utility.Days(month, day, year);

            Console.WriteLine("days= " + days[dayIndex]);
        }

    
}
}
