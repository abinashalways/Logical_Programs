using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region Automorphic Number
    //internal class Automorphic_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter a Number : ");
    //        int a = Convert.ToInt32(Console.ReadLine());
    //        int b = a * a;
    //        int c = 0;
    //        int temp = a;
    //        int number = 0;
    //        int Reversenumber = 0;
    //        int i = 1;
    //        while (temp>0)
    //        {
    //            c++;
    //            temp/= 10;
    //        }

    //            while (i<=c)
    //            {
    //                int r=b% 10;
    //                number = number * 10 + r;               
    //                b /= 10;
    //                i++;
    //            }
    //        while(number>0)
    //        {
    //            int r=number% 10;
    //            Reversenumber = Reversenumber * 10 + r;
    //            number/= 10;
    //        }
    //        if (Reversenumber == a)
    //        {
    //            Console.WriteLine(a +" Automorphic Number");
    //        }
    //        else
    //        {
    //            Console.WriteLine(a+" Not An Automorphic Number");
    //        }          
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Automorphic Number Range
    //public class Automorphic_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the 1st Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter the 2nd Number : ");
    //        int b = Convert.ToInt32(Console.ReadLine());
    //        for (int i = a; i <= b; i++)
    //        {
    //            int temp = i;
    //            int m = i * i;
    //            int c = 0;
    //            int number = 0;
    //            int Reversenumber = 0;
    //            int j = 1;
    //            while (temp>0)
    //            {
    //                c++;
    //                temp /= 10;
    //            }
    //            while (j <=c)
    //            {
    //                int r=m%10;
    //                number = number * 10 + r;
    //                m/=10;
    //                j++;
    //            }
    //            while(number>0)
    //            {
    //                int r=number%10;
    //                Reversenumber = Reversenumber * 10 + r;
    //                number/=10;
    //            }
    //            if (i == Reversenumber)
    //            {
    //                Console.WriteLine(i+ " Automorphic Number");
    //            }
    //            else
    //            {
    //                Console.WriteLine(i+" Not An Automorphic Number");
    //            }
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Automorphic Number Range Using Class Mechanism
    public class Automorphic
    {
        public int IsAutomorphic(int a)
        {
            int m = a * a;
            int temp = a;
            int c = 0;
            int number = 0;
            int i = 1;
            int Reversenumber = 0;
            while (temp>0)
            {
                c++;
                temp /= 10;
            }           
            while (i<=c)
            {
                int r=m%10;
                number = number * 10 + r;
                m/=10;
                i++;
            }
            while (number>0)
            {
                int r=number%10;
                Reversenumber = Reversenumber * 10+r;
                number/=10;
            }
            return Reversenumber;
        }        
    }
    internal class Automorphic_Number
    {
        static void Main()
        {
            Console.Write("Enter the 1st Number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Automorphic A=new Automorphic();
            for (int i = a; i <= b; i++)
            {
                if(A.IsAutomorphic(i)==i)
                {
                    Console.WriteLine(i+ " Automorphic Number");
                }
                else
                {
                    Console.WriteLine(i + " Not An Automorphic Number");
                }
            }
            Console.ReadLine();
        }
    }
    #endregion
}
