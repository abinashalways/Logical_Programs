using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class HCF
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st Number : ");
            int a=Convert.ToInt32(Console.ReadLine()); //9
            Console.Write("Enter the 2nd Number : ");
            int b = Convert.ToInt32(Console.ReadLine()); //27

            while (b != 0) //27(T)  //9(T)
            {
                int temp = b;//temp=27  //temp=9
                b = a % b;// 9%27 => b=9   //27%9=0 b=0           
                a= temp;//a=27 //a=9
            }
            Console.WriteLine("HCF is : "+a);
        }
    }
}
