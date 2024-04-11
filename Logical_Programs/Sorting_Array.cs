using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region Sorting Array Increasing Order
    //internal class Sorting_Array
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter elements of the array : ");
    //        int[] arr=new int[5];
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            arr[i] = Convert.ToInt32(Console.ReadLine());
    //        }
    //        Console.WriteLine("Unsorted Order of the array : ");
    //        Console.WriteLine();

    //        Console.WriteLine("1st Method");
    //        for (int i = 0;i < arr.Length; i++)
    //        {
    //            Console.Write(arr[i]+" ");
    //        }
    //        Console.WriteLine();

    //        Console.WriteLine("\n2nd Method");
    //        Console.WriteLine(string.Join(" ", arr));
    //        Console.WriteLine();

    //        Console.WriteLine("3rd Method");
    //        foreach (int i in arr)
    //        {
    //            Console.Write(i+" ");
    //        }
    //        Console.WriteLine();
    //        Console.WriteLine("\nSorted Order of the array (Increasing Order) : ");

    //        for(int i = 0;i<arr.Length ; i++) // 1 ,2 ,3 ,4 ,5
    //        {
    //            for(int j = i+1;j<arr.Length ; j++)
    //            {
    //                if (arr[i] > arr[j]) //1>1 f // 2>1 t
    //                {
    //                    int temp = arr[i];
    //                    arr[i] = arr[j];
    //                    arr[j] = temp;
    //                }
    //            }
    //        }
    //        Console.WriteLine(string.Join(" ", arr));

    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Sorting Array Decreasing Order
    internal class Sorting_Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements of the array : ");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Unsorted order of the array : ");
            for (int i = 0;i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\nSorted Order of the array (Decreasing Order) : ");
            for(int i = 0;i<arr.Length; i++)
            {
                for (int j = i+1;j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.ReadLine();
        }
    }
    #endregion
}
