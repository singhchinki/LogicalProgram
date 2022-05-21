using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Fibonicseries
    {
        public void fibonic()
        {
            Console.WriteLine("Enter the first number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int Third = Convert.ToInt32(Console.ReadLine());
            Console.Write(Second + " "+ Third + " ");
            int counter = 0, sum;
            while (counter < First - 2)
            {
                sum = Second + Third;
                Console.Write(sum + " ");
                Second = Third ;
                Third = sum;
                counter++;
            }
        }
    }
}
