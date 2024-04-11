using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region Perfect Number
    //internal class Perfect_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter A Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine());
    //        int Sum=0;
    //        for (int i = 1; i < a; i++)
    //        {
    //            if(a%i == 0)
    //            {
    //                Sum = Sum +i;  
    //            }
    //        }
    //        if(Sum == a)
    //        {
    //            Console.Write("Perfect Number");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Not A Perfect Number");
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Perfect Number Range
    //public class Perfect_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the 1st Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter the 2nd Number : ");
    //        int b = Convert.ToInt32(Console.ReadLine());

    //        for (int i = a; i <= b; i++)
    //        {
    //            int c = i;
    //            int Sum = 0;
    //            for (int j = 1; j < i; j++)
    //            {
    //                if (i%j==0)
    //                {
    //                    Sum=Sum+j;  
    //                }
    //            }
    //            if (Sum == c)
    //            {
    //                Console.WriteLine(i+" Perfect Number");
    //            }
    //            else
    //            {
    //                Console.WriteLine(i+" Not Perfect Number");
    //            }
    //        }

    //    }
    //}
    #endregion

    #region Perfect Number Range Using Class Mechanism
    internal class Perfect
    {
        public int IsPerfect(int a)
        {
            int Sum = 0;
            for (int i = 1;i<a;i++)
            {
                if (a%i==0)
                {
                    Sum=Sum+i;
                }
            }
            return Sum;
        }
    }
    public class Perfect_Number
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st Number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Perfect P= new Perfect();
            for (int i = a; i <= b; i++)
            {
                //int c = i;
                if (P.IsPerfect(i)==i)
                {
                    Console.WriteLine(i+" Perfect Number");
                }
                else
                {
                    Console.WriteLine(i+" Not Perfect Number");
                }
            }
            Console.ReadLine();
        }
    }
    #endregion
}
