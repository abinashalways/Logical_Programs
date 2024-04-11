using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Insert_Array
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in array : ");
            int a=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[50];
            Console.WriteLine("Enter the "+a+" elements ");
            for (int i = 0; i < a; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Content of the array - ");
            for(int i = 0;i<a; i++)
            {
                Console.Write(" " + arr[i]);
            }

            Console.Write("\nEnter the position where you want to insert a new element : ");
            int Position=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value : ");
            int Value=Convert.ToInt32(Console.ReadLine());
           
            for(int i = a-1;i >= Position-1;i--) //a=5-1=4 ; 4>=3-1=2 ; 3>=2  ; 2>=2  //10,20,40,50,60
            {
                arr[i+1] = arr[i];  //arr[4+1=5] = 60  // arr[3+1=4] = 50 // arr[3] = 40
                // arr=10,20,40,40,50,60
            }
           
            arr[Position-1]=Value;

            Console.WriteLine("Array after inserting of the new element : ");

            for (int i = 0; i <= a; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.ReadLine();
        }
    }
}
