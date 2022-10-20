using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    public static class vendingMachine
    {
        public static void Calculate()
        {
            int money = 2022;
            int[] denominations = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int note = 0;

            while (money > 0)
            {

                int count = 0;

                Console.WriteLine("Remaining money: " + money);

                while (money >= denominations[note])
                {

                    money = money - denominations[note];

                    count++;

                }

                Console.WriteLine(denominations[note] + " X " + count);

                note++;



            }
        }
    }
}
