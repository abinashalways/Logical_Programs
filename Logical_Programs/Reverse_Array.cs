using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Reverse_Array
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of an array : ");
            int a=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[a];
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter the elements of an array arr["+i+"] : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Content Of the array - ");

            Console.WriteLine(string.Join(" ",arr));

            Console.WriteLine("Content Of the array in reverse order - ");

            for(int i = arr.Length-1;i>=0 ;i--)
            {
                Console.Write(" "+arr[i]);
            }
            Console.WriteLine();
            
            Console.ReadLine();
        }
    }
}
