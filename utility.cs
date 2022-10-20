using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    public static class utility
    {
        public static int Days(int m, int d, int y)
        {
            int y1 = y - ((14 - m) / 12);
            int x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);
            int m1 = m + (12 * ((14 - m) / 12)) - 2;
            int d1 = (d + x + ((31 * m1) / 12)) % 7;
            return d1;
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        public static double MonthlyPayment(double p, double y, double r)
        {
            double n = 12 * y;
            double result = r / (12 * 100);

            return (p * result) / (1 - Math.Pow(1 + r, -n));
        }
    
}
}
