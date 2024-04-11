using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region Spy Number
    //internal class Spy_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter a Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine()); //1124
    //        int temp = a;
    //        int Mul = 1, Sum = 0;
    //        while (temp > 0)
    //        {
    //          int  b = temp % 10;
    //            Sum += b;
    //            Mul *= b;
    //            temp /= 10;
    //        }
    //        if (Sum==Mul)
    //        {
    //            Console.WriteLine(a+" Spy Number");
    //        }
    //        else
    //        {
    //            Console.WriteLine(a+" Not a Spy Number");
    //        }

    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Spy Number Range
    public class Spy_Number
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st Number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd Number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                int temp = i;int Sum = 0, Mul = 1;
                while (temp>0)
                {
                    int r = temp % 10;
                    Sum = Sum + r;
                    Mul = Mul * r;
                    temp /= 10;
                }
                if (Sum == Mul)
                {
                    Console.WriteLine(i + " Spy Number");
                }
                else
                {
                    Console.WriteLine(i + " Not a Spy Number");
                }             
            }
            Console.ReadLine();
        }
    }
    #endregion
}
