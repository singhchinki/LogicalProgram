using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PerfectNumber
    {
        public void perfect()
        {
            Console.WriteLine("Enter the  number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, n;
            n = num;
            for (int i = 1; i < num; i++)
                if (num % i == 0)
                {
                    sum = sum + 1;
                }
            else if (sum == n )
                {
                    Console.WriteLine("\n Entered number is a perfect number");
                    Console.ReadLine();
                }
            else
                {
                    Console.WriteLine("\n Entered number is not a perfect number");
                    Console.ReadLine();
                }
        }
               
    }
}
