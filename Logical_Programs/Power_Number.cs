using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Power_Number
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int a=Convert.ToInt32(Console.ReadLine()); //4
            Console.Write("Enter the Power of a Number : ");
            int b = Convert.ToInt32(Console.ReadLine()); //3
            int Power=1;
            for (int i = 1; i <= b; i++)
            {               
                    Power = Power * a;               
            }
            Console.WriteLine("Power Of "+a+" is "+Power);
            Console.ReadLine();
        }
    }
}
