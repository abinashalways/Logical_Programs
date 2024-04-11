using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region  Neon Number
    //internal class Neon_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter a Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine()); // 9 is a Neon_Number cause 9*9=81 8+1=9
    //        int b = a * a,c,Sum=0;
    //        while (b != 0) //81
    //        {
    //            c = b % 10;
    //            while (c != 0)
    //            {
    //                Sum=Sum + c;
    //                c/=10;
    //            }
    //            b /= 10;
    //        }
    //        if (Sum == a)
    //        {
    //            Console.WriteLine(a + " is Neon Number");
    //        }
    //        else
    //        {
    //            Console.WriteLine(a + " is Not Neon Number");
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Neon Number Range
    //internal class Neon_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the 1st Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter the 2nd Number : ");
    //        int b = Convert.ToInt32(Console.ReadLine());
    //        for (int i = a; i <= b; i++)
    //        {
    //            int s = i * i;
    //            int c,Sum=0;
    //            while (s>0)
    //            {
    //                c = s % 10;
    //                while (c>0)
    //                {
    //                    Sum=Sum+c;
    //                    c/= 10;
    //                }
    //                s /=10;
    //            }
    //            if (Sum==i)
    //            {
    //                Console.WriteLine(i + " Neon Number");
    //            }
    //            else
    //            {
    //                Console.WriteLine(i+ " Not Neon Number");
    //            }
    //        }

    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Neon Number Range Using Class Mechanism
    internal class Neon
    {
        public int IsNeon(int a)
        {
            int b = a * a;int c,Sum=0;
            while (b > 0)
            {
                c = b % 10;
                while (c > 0)
                {
                    Sum=Sum + c;
                    c/= 10;
                }
                b /= 10;
            }
            return Sum;
        }
    }
    public class Neon_Number
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st Number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Neon N= new Neon();
            for (int i = a; i <= b; i++)
            {
                if (N.IsNeon(i)==i)
                {
                    Console.WriteLine(i+" Neon Number");
                }
                else
                {
                    Console.WriteLine(i+ " is Not Neon Number");
                }
            }
            Console.ReadLine();
        }
    }
    #endregion
}
