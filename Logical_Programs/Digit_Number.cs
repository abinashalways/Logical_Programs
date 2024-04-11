using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Digit_Number
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            int C = 0;
            while(a>0)
            {              
                C++;
                a/=10;
            }
            Console.WriteLine("Total Digit is : "+C);
        }
    }
}
