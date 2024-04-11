using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Duplicate_Array
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter "+a+" array element : ");
            int[] arr = new int[50];
            
            for(int i = 0; i < a; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Content of the array - ");
            for(int i = 0;i < a;i++)
            {
                Console.Write(" "+arr[i]);
            }
            int[] arr2 = new int[50]; //1,2,3,4,2,3,6,5,8,5
            int Count = 0, j;
            for (int i = 0;i<a;i++)
            {
                for(j = 0; j < Count; j++)
                {
                    if (arr[i] == arr2[j])
                    {
                        break;
                    }
                }
                if (j == Count)
                {
                    arr2[Count] = arr[i];
                    Count++;
                }
            }

            Console.WriteLine("\nContent of the array after duplicate removal - ");
            for (int i = 0; i < Count; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.ReadLine();
        }
    }
}
