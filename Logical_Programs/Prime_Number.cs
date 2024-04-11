using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region Prime Number
    //internal class Prime_Number
    //{
    //    static void Main()
    //    {
    //        Console.Write("Enter the Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine());
    //        int c = 0;
    //        for (int i = 1; i <= a; i++)
    //        {
    //            if (a % i == 0)
    //            {
    //                c++;
    //            }
    //        }
    //        if (c == 2)
    //        {
    //            Console.WriteLine("prime");
    //        }
    //        else
    //        {
    //            Console.WriteLine("not");
    //        }

    /* int i = 1;
     while (i <= a)
     {
         if (a % i == 0)
         {
             c++;
         }
         i++;
     }
     if (c == 2)
     {
         Console.WriteLine("prime");
     }
     else
     {
         Console.WriteLine("not");
     }
 } */

    // }
    #endregion

    #region Prime Number Range
    //internal class Prime_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter The 1st Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter The 2nd Number : ");
    //        int b = Convert.ToInt32(Console.ReadLine());  
    //        for (int i = a; i <= b; i++)
    //        {
    //            int c = 0;
    //            for (int j = 1; j <= i; j++)
    //            {
    //                if (i%j == 0)
    //                {
    //                    c++;
    //                }             
    //            }
    //            if (c == 2)
    //            {
    //                Console.WriteLine(i + " prime");
    //            }
    //            else
    //            {
    //                Console.WriteLine(i + " not");
    //            }
    //        }         
    //    }
    //}
    #endregion

    #region Prime Number Range Using Class Mechanism
    public class Prime
    {
        public bool IsPrime(int n) 
        {
            int c = 0;
            for (int i = 1;i<=n;i++)
            {
                if (n%i == 0)
                {
                    c++;
                }
            }
            //  Another Method
            /*    public int IsPrime(int n)
              {
                  int c = 0;
                  for (int i = 1; i <= n; i++)
                  {
                      if (n % i == 0)
                      {
                          c++;
                      }
                  }
              } */
            if (c == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    internal class Prime_Number
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The 1st Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The 2nd Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Prime P= new Prime();   
            for (int i = a; i<=b;i++)
            {
                if (P.IsPrime(i)) //  Another Method for this method  public int IsPrime(int n)    //   if (P.IsPrime(i)==2)
                {
                    Console.WriteLine(i+" Prime No.");
                }
                else
                {
                    Console.WriteLine(i + " Not");
                }
            }
        }
    }
    #endregion 
}
