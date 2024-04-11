using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region Happy Number
    //internal class Happy_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter a Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine()); //23
    //        int num = a;
    //        int Sum = 0;
    //        while(Sum!=1&&Sum!=4)
    //        {
    //            Sum = 0;
    //            while (a > 0)
    //            {                  
    //                int b = a % 10;
    //                while (b > 0)
    //                {
    //                    Sum = Sum +( b * b);
    //                    b /= 10;
    //                }
    //                a /= 10;
    //            }
    //             a=Sum;
    //        }
    //        if(Sum==1)
    //        {
    //            Console.WriteLine(num+" Happy Number");
    //        }
    //        else
    //        {
    //            Console.WriteLine(num + " Not Happy Number");
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Happy Number Range
    internal class Happy_Number
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st Number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd Number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++) //23
            {
                int Sum = 0; int temp = i;
                while (Sum!=1&&Sum!=4)
                {
                      Sum = 0;
                    while (temp > 0)
                    {
                        int r = temp % 10; //3 //2
                        Sum += r*r; //3//2//9+4//13
                        temp /= 10;
                    }
                    temp = Sum;
                }

                if(Sum ==1)
                {
                    Console.WriteLine(i + " Happy Number");
                }
                else
                {
                    Console.WriteLine(i + " Not Happy Number");

                }
            }

            Console.ReadLine();
        }
    }
    #endregion
}
