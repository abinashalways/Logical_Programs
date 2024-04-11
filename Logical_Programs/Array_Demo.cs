using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Logical_Programs
{
    #region Array Printing
    //internal class Array_Demo
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 10, 20, 30, 40, 50 };
    //        Console.WriteLine("Content of the array - ");
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            Console.WriteLine("Value of "+i+" is : "+arr[i]);
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Array Printing All User Input Values
    //class Array_Demo
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter the size of an array : ");
    //        int a=Convert.ToInt32(Console.ReadLine());
    //        int[] arr = new int[a];
    //        for (int i=0;i<arr.Length;i++)
    //        {
    //            Console.Write("Enter the value of arr["+i+"] : ");
    //            arr[i]= Convert.ToInt32(Console.ReadLine());
    //        }
    //        Console.WriteLine("Content of the array - ");

    //        foreach (int i in arr)
    //        {
    //            Console.WriteLine("Values are "+ i );    // OR
    //        }


    //        Console.WriteLine(string.Join(" ",arr));     // OR



    //        for (int i=0;i<arr.Length; i++)
    //        {
    //            Console.WriteLine("Value at arr["+i+"] is : " + arr[i]);  // OR
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Percentage Of An Array
    internal class Array_Demo
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the size of an array : ");
            int a=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[a];
            int Total =0;
            double Percentage;
            Console.WriteLine("Enter marks for "+a+" subjects : ");
            for (int i=0; i<arr.Length; i++)
            {
                Console.Write("Enter marks for subject ["+(i+1)+"] : ");
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<arr.Length;i++)
            {
                Total += arr[i];
            }
            Percentage=(double)Total/a;
            Console.Write("\nPercentage : "+ Percentage);
            Console.ReadLine();
        }
    }
    #endregion
}
