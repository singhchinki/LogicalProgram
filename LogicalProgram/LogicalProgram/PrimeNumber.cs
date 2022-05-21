using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PrimeNumber
    {
        public void primeNum()
        {
            Console.WriteLine("Enter the  number");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    n++;
                }
                else if (n == 2)
                { 
                    Console.WriteLine("Prime Number{0}" + a);
                }
                else
                {
                    Console.WriteLine("Not a Prime Number");
                }
                Console.ReadLine();
            }
        }
    }
}

