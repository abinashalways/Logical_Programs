using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Reverse_Number
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            int temp = a;//string S = "";
            int S=0;
            while (temp > 0)
            {
                int r = temp % 10;
               // S += r;  OR
               S=S*10+ r;
                temp /= 10;
            }

            //                   OR                  //

            /* for(int i = a;i>0;)
             {
                 int r = i % 10;
                 S=S+r;
                 i/=10;
             } */
            Console.WriteLine("Reverse Number Of "+a+" is "+S);   
            Console.ReadLine();
        }
    }
}
