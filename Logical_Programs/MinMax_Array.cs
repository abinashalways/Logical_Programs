using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class MinMax_Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements of the array : ");
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int Min,Max;
            Min = arr[0];
            Max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (Max < arr[i])
                {
                    Max = arr[i];
                }
                if (Min > arr[i])
                {
                    Min = arr[i];
                }
            }

            Console.Write("The largest element is of the array : "+Max);
            Console.Write("\nThe smallest element is of the array : " + Min);

            Console.ReadLine();
        }
    }
}
