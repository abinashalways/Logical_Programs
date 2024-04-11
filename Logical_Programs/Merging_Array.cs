using System;

namespace Logical_Programs
{
    internal class Merging_Array
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int[] arr2 = new int[] { 2, 4, 6, 8, 10, 0 };
            Console.WriteLine("Elements of 1st array : ");

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine("\nElements of 2nd array : ");

            foreach (int i in arr2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nElements of Merged array : ");

            int size = arr1.Length + arr2.Length;
            int[] arr3 = new int[size];
            int Index = 0;
            for(int i=0; i<arr1.Length; i++)
            {
                arr3[Index] = arr1[i];
                Index++;
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[Index] = arr2[i];
                Index++;
            }
            foreach (int i in arr3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sorting Of Merged Array : ");
            for (int i=0;i<arr3.Length; i++)
            {
                for(int j=i+1; j<arr3.Length; j++)
                {
                    if (arr3[i] > arr3[j])
                    {
                        int temp = arr3[i];
                        arr3[i] = arr3[j];
                        arr3[j] = temp;
                    }
                }
            }
            foreach (int i in arr3)
            {
                Console.Write(i + " ");
            }
        }
    }
}
