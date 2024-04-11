using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region Palindrome Number
    //internal class Palindrome_Number
    //{
    //    static void Main()
    //    {
    //        Console.Write("Enter the Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine()); //121 is palindrome number
    //        int d = a;
    //        int c=0;
    //        int b;
    //        while (a>0) //121  //12  //1 //F
    //        {
    //             b=a%10; //1  //2  //1
    //            c=c*10+b; //0*10+1=1  //1*10+2=12   //12*10+1=121
    //            a/=10;//12 //1  //0

    //        }
    //       if (c==d)
    //        {
    //            Console.WriteLine(d+ " is palindrome number");
    //        }
    //      else
    //        {
    //            Console.WriteLine(d+ " is not palindrome number");
    //        }

    //       Console.ReadLine();
    //    }
    //}
    #endregion Palindrome Number

    #region Palindrome Number Range
    //internal class Palindrome_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the 1st Number : ");
    //        int a = Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter the 2nd Number : ");
    //        int b = Convert.ToInt32(Console.ReadLine());

    //        for (int i = a; i <= b; i++)
    //        {
    //            int originalNumber = i;
    //            int reversedNumber = 0;
    //            int temp = i;

    //            while (temp > 0)
    //            {
    //                int remainder = temp % 10;
    //                reversedNumber = reversedNumber * 10 + remainder;
    //                temp /= 10;
    //            }

    //            if (originalNumber == reversedNumber)
    //            {
    //                Console.WriteLine(originalNumber + " is a Palindrome");
    //            }
    //            else
    //            {
    //                Console.WriteLine(originalNumber + " is Not a Palindrome");
    //            }
    //        }
    //    }
    //}
    #endregion

    #region Palindrome Number Range Using Class Mechanism
    //public class Palindrome
    //{
    //    public int IsPalindrome(int a)
    //    {
    //        int ReverseNumber = 0,b;
    //        while (a>0)
    //        {
    //            b = a % 10;
    //            ReverseNumber = ReverseNumber * 10 + b;
    //            a/=10;
    //        }
    //        return ReverseNumber;
    //    }
    //}
    //internal class Palindrome_Number
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the 1st Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Enter the 2nd Number : ");
    //        int b = Convert.ToInt32(Console.ReadLine());
    //        Palindrome P= new Palindrome();
    //        for (int i = a; i <=b; i++)
    //        {
    //            int OriginalNumber = i;

    //            int temp = i;
    //            if (P.IsPalindrome(temp)==OriginalNumber)
    //            {
    //                Console.WriteLine(OriginalNumber+" Palindrome Number");
    //            }
    //            else
    //            {
    //                Console.WriteLine(OriginalNumber + "Not A Palindrome Number");

    //            }
    //        }
    //    }
    //}
    #endregion

    #region Palindrome String
    class Palindrome_Number
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Letter : ");
            string?  S=Console.ReadLine(); 
            string E = "";
            for (int i = S!.Length-1;i>=0;i--)
            {
                E =E+ S[i];
            }
           if (E ==S)
            {
                Console.WriteLine("Palindrome");
            }
           else
            {
                Console.WriteLine("Not");
            }

            Console.ReadLine();
        }
    }
    #endregion

}
