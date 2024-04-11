using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region Count Occurrence Of Number In Array
    //internal class Count_Array
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = [11, 11, 11, 44, 22, 11, 22, 88, 99, 11];
    //        Console.Write("Enter the number you want to search : ");
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        int Count = 0;
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            if (arr[i] == n)
    //            {
    //                Count++;
    //            }
    //        }
    //        Console.WriteLine("Content of the array : ");
    //        Console.WriteLine(string.Join(" ",arr));
    //        Console.WriteLine("Number of occurrence of " + n + " in the array is : " + Count);
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    class Count_Array
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 43, 5, 67, 44, 88, 77, 11, 3 };
            Console.WriteLine("Content of the array : ");
            Console.WriteLine(string.Join(" ", arr));
            int e = 0, o = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 == 0)
                {
                    e++;
                }
                else
                {
                    o++;
                }
            }
            Console.WriteLine("Total Even Number is : " + e);
            Console.WriteLine("Total Even Number is : " + o);

        }
    }
}
