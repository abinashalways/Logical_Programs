using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Swapping
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st Number : ");
            int a=Convert.ToInt32(Console.ReadLine());//10
            Console.Write("Enter the 2nd Number : ");
            int b=Convert.ToInt32(Console.ReadLine());//20
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("the value of a after swapping is "+a);
            Console.WriteLine("the value of b after swapping is " + b);
            Console.ReadLine();

        }
    }
}
