using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class CouponNumber
    {
        public void coupon()
        {
            int i;
            int randomCount = 0;
            int ran = 0;
            Console.WriteLine("Please enter your no of distinct coupon numbers you want to add");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intDistinct = new int[n];
            for (i = 0; i < n; i++)
            {
                intDistinct[i] = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    randomCount++;
                    Random random = new Random();
                    ran = random.Next(0, 11);
                    if (ran == intDistinct[i])
                    {
                        Console.WriteLine("Random count:" + randomCount);
                        break;

                    }
                }
            }
            
        }  
    }
}
