using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region Factorial 
    //internal class Factorial
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the Number : ");
    //        int a = Convert.ToInt32(Console.ReadLine());
    //        int f = 1;
    //        for (int i = 1; i <= a; i++)
    //        {
    //            f = f * i;
    //        }
    //        Console.WriteLine("Factorial Of " + a + " is " + f);
    //        Console.ReadLine();
    //    }
    //}
    #endregion 

    #region Factorial Range
    //public class Factorial
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the 1st Number : ");
    //        int a = Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter the 2nd Number : ");
    //        int b = Convert.ToInt32(Console.ReadLine());

    //        for (int i = a; i <= b; i++)
    //        {
    //            int f = 1;
    //            for (int j = 1; j <= i; j++)
    //            {
    //                f = f * j;
    //            }
    //            Console.WriteLine("Numbers are : " + f);
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion 

    #region Factorial Range Using Class Mechanism
    internal class Program1
    {
        public int Factorial(int j)
        {
            int f = 1;
            for (int i = 1; i <= j; i++)
            {
                f = f * i;
            }
            return f;
        }
    }

    public class Factorial
    {
        static void Main(string[] args)
        {
            Program1 P = new Program1();
            Console.Write("Enter the 1st Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                P.Factorial(i);
                Console.WriteLine("Numbers Are : " + P.Factorial(i));
            }

        }
    }
    #endregion






}
