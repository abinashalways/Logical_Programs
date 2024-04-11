namespace Logical_Programs
{
    #region Even-Odd
    //internal class Even_Odd
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the Number : ");
    //        int a = Convert.ToInt32(Console.ReadLine());
    //        if (a % 2 == 0)
    //        {
    //            Console.WriteLine($"{a} is Even Number");
    //        }
    //        else
    //        {
    //            Console.WriteLine(a + " is Odd Number");

    //        }

    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Even-Odd Range
    //class Even_Odd
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the 1st Number : ");
    //        int a = Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter the 2nd Number : ");
    //        int b = Convert.ToInt32(Console.ReadLine());
    //        for (int i = a; i <= b; i++)
    //        {
    //            if (i % 2 == 0)
    //            {
    //                Console.WriteLine(i + " Even No.");
    //            }
    //            else
    //            {
    //                Console.WriteLine(i + " Odd No.");
    //            }
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Even-Odd Range Using Class Mechanism

    internal class Program
    {
        public int EvenOdd(int n)
        {
            //    Another Method   
            /* public bool EvenOdd(int n)
             {
                 if (n%2 == 0)
                 {
                     return true;
                 }
                 return false;
            } */

            return n % 2 ;       
        }
        
    }

    public class Even_Odd
    {
        static void Main(string[] args)
        {
            Program P=new Program();
            Console.Write("Enter 1st No. : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd No. : ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (P.EvenOdd(i)==0) //    Another Method    if (P.EvenOdd(i))   for this method public bool EvenOdd(int n)
                {
                    Console.WriteLine(i+" Even Number");
                }
                else
                {
                    Console.WriteLine(i + " Odd Number");

                }
            }
            Console.ReadLine();
        }
    }
    #endregion

}
