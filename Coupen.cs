using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    public static class Coupen
    {
        public static void CheckNumber()
        {
            int distinct = 0;
            int count = 0;

            Console.WriteLine("Enter the number of given distinct coupon:");
            int couponNo = Convert.ToInt32(Console.ReadLine());
            bool[] iscollected = new bool[couponNo];

            while (distinct < couponNo)
            {
                Random random = new Random();
                int newCoupon = (int)(random.NextDouble() * couponNo);
                count++;

                if (!iscollected[newCoupon])
                {
                    distinct++;
                    iscollected[newCoupon] = true;

                }
            }
            Console.WriteLine("Total random number needed to have all distinct coupon: " + count);
        }
    
}
}
