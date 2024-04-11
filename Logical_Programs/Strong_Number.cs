using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region Strong Number
    //internal class Strong_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter a Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine());
    //        int b,Sum=0;
    //        int c = a;
    //        while (a > 0)
    //        {
    //            b = a % 10;
    //            while (b > 0)
    //            {
    //                int f = 1;
    //                for (int i = 1; i <= b; i++)
    //                {
    //                    f = f * i;

    //                }
    //                b /= 10;
    //                Sum = Sum + f;

    //            }              
    //            a /= 10;

    //        }
    //        if (Sum == c)
    //        {
    //            Console.WriteLine(c+" is a Strong Number");
    //        }
    //        else
    //        {
    //            Console.WriteLine(c+ " is not a Strong Number");
    //        }            
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Strong Number Range
    //internal class Strong_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the 1st Number : ");
    //        int a = Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter the 2nd Number : ");
    //        int b = Convert.ToInt32(Console.ReadLine());
    //        int c,  temp;
    //        for (int i = a; i <= b; i++)
    //        {
    //            temp = i; int Sum = 0;
    //            while (temp > 0)
    //            {
    //                c = temp % 10;
    //                while (c != 0)
    //                {
    //                    int f = 1;
    //                    for (int j = 1; j <= c; j++)
    //                    {
    //                        f = f * j;
    //                    }

    //                    Sum += f;
    //                    c /= 10;
    //                }
    //                temp /= 10;
    //            }
    //            if (Sum == i)
    //            {
    //                Console.WriteLine(i + " Strong Number");
    //            }
    //            else
    //            {
    //                Console.WriteLine(i + " Not Strong Number");
    //            }
    //        }

    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Strong Number Range Using Class Mechanism 
    internal class Strong
    {
        public int IsStrong(int a)
        {
            int  b,Sum=0;
            while (a != 0)
            {
                b= a%10;
                while(b != 0)
                {
                    int f = 1;
                    for (int i = 1; i <= b; i++)
                    {
                        f = f * i;
                    }
                    Sum=Sum + f;
                    b/= 10;
                }
                a /=10;
            }
            return Sum;
        }
    }
    public class Strong_Number
    {
        static void Main()
        {
            Console.Write("Enter the 1st Number : ");
            int a=Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Enter the 2nd Number : ");
            int b = Convert.ToInt32(Console.ReadLine()); 
            var S = new Strong();
            for (int i = a; i <= b; i++)
            {
                if (S.IsStrong(i) == i)
                {
                    Console.WriteLine(i+" Strong Number");
                }
                else
                {
                    Console.WriteLine(i+" Not Strong Number");
                }
            }
            Console.ReadLine();
        }
    }
    #endregion
}
