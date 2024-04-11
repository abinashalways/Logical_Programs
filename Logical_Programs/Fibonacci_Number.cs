using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region Fibonacci Number
    //internal class Fibonacci_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the Number : ");
    //        int n=Convert.ToInt32(Console.ReadLine());
    //        int a = 0, b = 1;
    //        for (int i = 1; i <= n; i++)
    //        {
    //            Console.Write(a+" ");              
    //            int t = a;                
    //            a = b;  
    //            b = t + b;  
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Fibonacci Number Range
    //public class Fibonacci_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the 1st Number : ");
    //        int m=Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter the 2nd Number : ");
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine();
    //        for (int i = m; i <= n; i++)
    //        {
    //            int a = 0, b = 1;
    //            Console.Write("Fibonacci Series for " + i + " : ");
    //            for (int j = 1; j <= i; j++)
    //            {
    //                Console.Write(a+" " );
    //                int t = a;
    //                a=b;
    //                b = t + b;
    //            }
    //            Console.WriteLine();
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Fibonacci Number Range Using Class Mechanism
    public class Fibonacci
    {
        public void IsFibonacci(int m)
        {
            int a = 0, b = 1;
            
            for (int i = 1;i<=m;i++)
            {
                Console.Write(a+" ");
                int t = a;
                a = b;
                b = t + b;
            }
            Console.WriteLine();

        }
    }
    class Fibonacci_Number
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st Number : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Fibonacci F=new Fibonacci();
            for (int i = m; i <= n; i++)
            {
                Console.Write("Fibonacci Series for " + i + " : ");
                F.IsFibonacci(i);
            } 
            Console.ReadLine();
        } 
    }
    #endregion
}
