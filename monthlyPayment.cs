using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    public static class monthlyPayment
    {
        public static void Payment(string argument1, string argument2, string argument3)
        {
            double principalLoan = Convert.ToDouble(argument1);
            double year = Convert.ToDouble(argument2);
            double percentInterest = Convert.ToDouble(argument3);
            Console.WriteLine("Monthly Payments: " + Utility.MonthlyPayment(principalLoan, year, percentInterest));
        }
        }
    }
}
