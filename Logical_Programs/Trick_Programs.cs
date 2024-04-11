using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region +, - and * Operation
    //internal class Trick_Programs
    //{
    //static void Main(string[] args)
    //{
    //     Console.Write("Enter 2 Numbers : ");
    //     int a=Convert.ToInt32(Console.ReadLine());
    //     int b=Convert.ToInt32(Console.ReadLine());         
    //     Console.Write("Addition is : "+(a-(-b))); 
    //     Console.Write($"\nSubtraction of {a} - {b} is : " + (a + (~b+1)));
    //     int Sum = 0;
    //     if (b < 0)
    //     {
    //         b = -b;
    //         a = -a;
    //     }
    //     for (int i = 1; i <= b; i++)
    //     {
    //         Sum += a;
    //     }
    //     Console.Write("\nMultiplication is : " + Sum); 
    //    Console.ReadLine();
    //}
    //}
    #endregion

    #region '/' Operation Using User Defined Method
    //internal class Trick_Programs
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter Numerator : ");
    //        double a=Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter Denominator : ");
    //        double b =Convert.ToInt32(Console.ReadLine());
    //        double Quotient = 0;

    //        bool isNegative; 
    //        // Another Method
    //       // bool isNegative; = (a < 0) ^ (b < 0);
    //        if ( b==0)
    //        {
    //            Console.WriteLine("Can not divide by zero"); 
    //            return;
    //        }
    //        if(a<0&&b<0)
    //        {
    //            isNegative = false;
    //        }
    //        else if (a >= 0 && b > 0)
    //        {
    //            isNegative = false;
    //        }
    //        else 
    //        {
    //            isNegative = true;
    //        }

    //        if (b < 0)
    //        {
    //            b = -b;

    //        }

    //        if (a < 0)
    //        {
    //            a = -a;
    //        }
    //        while (a>=b)
    //        {
    //            a = a - b;
    //            Quotient++;
    //        }

    //        if (isNegative)
    //            Quotient = -Quotient;

    //        Console.WriteLine("Quotient is : "+Quotient);
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region '/' & '%' Operation Using Pre Defined Method
    //internal class Trick_Programs
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the dividend : ");
    //        int a=Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter the divisor : ");
    //        int b = Convert.ToInt32(Console.ReadLine());
    //        if(b == 0)
    //        {
    //            Console.WriteLine("Can't divide by zero"); return;
    //        }
    //        int Quotient=Math.DivRem(a,b,out int Remainder);
    //        Console.WriteLine("Quotient is : "+ Quotient);
    //        Console.WriteLine("Remainder is : " + Remainder);
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region '%' Operation Using User Defined Method

    internal class Trick_Programs
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numerator : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the denominator : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a;
            int d = b;
            if (b == 0)
            {
                Console.WriteLine("Can't divide by zero"); Console.ReadLine(); return;
            }
            int Quotient = 0;
            bool IsNegative;

            if (a < 0 && b < 0)
            {
                IsNegative = false;
            }
            else if (b > 0 && a >= 0)
            {
                IsNegative = false;
            }
            else
            {
                IsNegative = true;
            }

            if (b < 0)
            {
                b = -b;
            }
            if (a < 0)
            {
                a = -a;
            }
            while (a >= b)
            {
                a = a - b;
                Quotient++;
            }
            if (IsNegative)
            {
                Quotient = -Quotient;
            }
            Console.WriteLine("Quotient is : " + Quotient);
            int Remainder = c - (Quotient * d);
            Console.WriteLine("Remainder is : " + Remainder);
            Console.ReadLine();
        }
    }
    #endregion


}

