namespace Logical_Programs
{
    #region Delete Array By Value
    //internal class Delete_Array
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter number of elements in array : ");
    //        int a=Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("Enter "+a+" elements - ");
    //        int[] arr = new int[50];
    //        for (int i = 0; i < a; i++)
    //        {
    //            arr[i] = Convert.ToInt32(Console.ReadLine());

    //        }
    //        Console.WriteLine("Content of the array - ");
    //        for (int i = 0;i < a; i++)
    //        {
    //            Console.Write(" "+arr[i]);
    //        }

    //        Console.Write("\nEnter the element to be deleted : ");
    //        int element = Convert.ToInt32(Console.ReadLine());

    //        bool Found = false;
    //        int Position = 0;
    //        for(int i = 0;i< a; i++)
    //        {
    //            if (arr[i] == element)
    //            {
    //                Found = true;
    //                Position = i;               
    //            }
    //        }

    //        if (Found)  //10,20,30,40,50    //pos=2
    //        {
    //            for (int i = Position; i < a-1; i++)
    //            {
    //                arr[i] = arr[i + 1]; 
    //            }
    //        }

    //        else
    //        {
    //            Console.WriteLine("Element " + element + " is not found in the array");
    //            Console.ReadLine();
    //            return;
    //        }
    //        Console.WriteLine("Array after deletion of the element : ");

    //       for(int i = 0;i<a-1 ; i++)
    //        {
    //            Console.Write(" "+arr[i]);
    //        }

    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Delete Array By Position
    class Delete_Array
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements in array : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter "+a+" elements - ");
            int[] arr = new int[50];
            for (int i = 0; i < a; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Content of the arrray - ");
            for (int i = 0;i < a;i++)
            {
                Console.Write(" "+arr[i]);
            }
            Console.Write("\nEnter the position where you want to delete the element : ");
            int Position=Convert.ToInt32(Console.ReadLine());

            for (int i = Position-1; i < a-1; i++) //2,4,6,5,8
            {
                arr[i] = arr[i+1]; 
            }


            Console.WriteLine("Array after deletion of the element : ");
            for (int i = 0; i < a-1; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.ReadLine();
        }
    }
    #endregion
}
