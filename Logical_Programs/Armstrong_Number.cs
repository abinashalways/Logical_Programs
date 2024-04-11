using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region Armstrong Number
    //internal class Armstrong_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter a Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine());        
    //        int b, Sum=0;
    //        int c = a;
    //        while(a>0)
    //        {                
    //            b = a % 10;              
    //            while(b>0)
    //            {                  
    //                Sum = Sum + b * b * b;

    //                b/= 10;
    //            }              
    //            a /= 10;              
    //        }
    //        if (Sum == c)
    //        {
    //            Console.Write(c+" Armstrong Number");
    //        }
    //        else
    //        {
    //            Console.Write(c+ " is Not Armstrong Number");
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Armstrong Number Range
    //public class Armstrong_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the 1st Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter the 2nd Number : ");
    //        int b = Convert.ToInt32(Console.ReadLine());
    //        for(int i = a; i <= b; i++)
    //        {
    //            int c,Sum=0,d=i,temp=i;
    //            while(temp > 0)
    //            {
    //                c = temp % 10;
    //                while(c>0)
    //                {
    //                    Sum=Sum+c*c*c;
    //                    c/=10;
    //                }
    //                temp /=10;
    //            }
    //            if(Sum==d)
    //            {
    //                Console.WriteLine(d+" Armstrong Number");
    //            }
    //            else
    //            {
    //                Console.WriteLine(d+ " Not an Armstrong_Number");
    //            }
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Armstrong Number Range Using Class Mechanism
    public class Armstrong
    {
        public int IsArmstrong(int a)
        {
            int b,Sum=0;
            while (a>0)
            {
                b = a % 10;
                while (b>0)
                {
                    Sum=Sum+b*b*b;
                    b/=10;
                }
                a /= 10;
            }
            return Sum;
        }
    }
    internal class Armstrong_Number
    {
        static void Main()
        {
            Console.Write("Enter the 1st Number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Armstrong A = new Armstrong();
            for (int i = a; i <= b; i++)
            {
                //int c = i;
                if (A.IsArmstrong(i) == i)
                {
                    Console.WriteLine(i+" Armstrong Number");
                }
                else
                {
                    Console.WriteLine(i + " Not An Armstrong Number");
                }
            }
            Console.ReadLine();
        }
    }
    #endregion
}
