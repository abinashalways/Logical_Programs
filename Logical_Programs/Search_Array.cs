using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region Searching an Array for a Particular Number
    //internal class Search_Array
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the size of an array : ");
    //        int a=Convert.ToInt32(Console.ReadLine());
    //        int[] arr = new int[a];
    //        Console.WriteLine("Enter The Values - ");
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            arr[i]= Convert.ToInt32(Console.ReadLine());
    //        }
    //        Console.Write("The Values are : ");

    //        Console.WriteLine(string.Join(",", arr));

    //        Console.Write("Enter the Number you want to search : ");
    //        int n=Convert.ToInt32(Console.ReadLine());
    //        bool Found = false;

    //        for (int i = 0;i < arr.Length; i++)
    //        {
    //            if (n == arr[i])
    //            {
    //                Found = true;
    //            }

    //        }
    //        if(Found)
    //        {
    //            Console.WriteLine("Yes! The Number is Presented in the Array");
    //        }
    //        else
    //        {
    //            Console.WriteLine("NO! The Number is Not Presented in the Array");
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Searching an Array for a Particular Number at Index Position
    internal class Search_Array
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of an array : ");
            int a=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[a];
            Console.WriteLine("Enter The Values - ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",arr));

            Console.Write("Enter the Number you want to search : ");
            int n=Convert.ToInt32(Console.ReadLine());  
            int Found=-1;
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    Found = i;
                }
            }
            if (Found>=0) 
            {
                Console.WriteLine("Yes! The Number is Presented in the Array at the index no. : "+Found);
            }
            else
            {
                Console.WriteLine("NO! The Number is Not Presented in the Array");
            }
            Console.ReadLine();
        }
    }
    #endregion

}
