using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    #region Frequency String
    //internal class Frequency_String
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter a String : ");
    //        string? str = Console.ReadLine()?.ToLower();
    //        Console.Write("Enter a character to find the frequency : ");
    //        char ch =Convert.ToChar(Console.Read());
    //        int Count = 0;
    //        for (int i = 0;i<str!.Length;i++)
    //        {
    //            if (str[i] == ch)
    //            {
    //                Count++;
    //            }
    //        }
    //        Console.WriteLine("Frequency is : "+Count);
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Frequency String Total Count 
    //internal class Frequency_String
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter a String : ");
    //        string? str = Console.ReadLine()?.ToLower();
    //        Dictionary<char, int> FrecuencyCount = new Dictionary<char, int>();
    //        foreach (char s in str!)
    //        {


    //            if (FrecuencyCount.ContainsKey(s))
    //            {
    //                FrecuencyCount[s]++;
    //            }
    //            else
    //            {
    //                FrecuencyCount[s] = 1;
    //            }


    //        }
    //        foreach (var v in FrecuencyCount)
    //        {
    //            Console.WriteLine(v.Key + " is " + v.Value);
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Frequency Integer Total Count
    //internal class Frequency_String
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter a Number : ");
    //        int a=Convert.ToInt32(Console.ReadLine());
    //        string s=a.ToString();
    //        Dictionary <int,int> map = new Dictionary<int,int>();
    //        foreach (int i in s)
    //        {
    //            int digit = i - '0';
    //            if(map.ContainsKey(digit)) 
    //            {
    //                map[digit]++;
    //            }
    //            else
    //            {
    //                map[digit] = 1;
    //            }
    //        }
    //        foreach (var i in map)
    //        {
    //            Console.WriteLine(i.Key+" is "+i.Value);
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    internal class Frequency_String
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string? str = Console.ReadLine();

            Dictionary<char, char> value = new Dictionary<char, char>();
          
            foreach (var v in str!)
            {
                if (!value.ContainsKey(v))
                {
                    value[v] = v;
                }

            }
            Console.Write("After removal of duplicate values : ");
            foreach (var v in value!)
            {
                Console.Write(v.Key);
            }

            Console.Write("\nSorting Of string is : ");

            Console.WriteLine(value.Keys.OrderBy(s => s).ToArray());
            Console.WriteLine(string.Join("", value.Keys.OrderBy(s => s))); //OR
            Console.WriteLine(string.Join("", value.Keys.OrderBy(s => s).ToArray())); //OR



            Console.ReadLine();
        }
    }



    //                      OR                  //



    //internal class Frequency_String
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter a String : ");
    //        string? str = Console.ReadLine();
    //        string[] strings = new string[50];

    //        int Count = 0,j=0;
    //        for (int i = 0;i<str!.Length;i++)
    //        {       
    //            for ( j = 0;j < Count;j++)
    //            {

    //                if ( str[i].ToString()== strings[j])
    //                {
    //                    break;
    //                }
    //            }
    //            if (j == Count)
    //            {
    //                strings[Count] = str[i].ToString(); 
    //                Count++;
    //            }
    //        }
    //        Console.Write("After removal of duplicate values : ");        
    //        for (j = 0;j < Count; j++)
    //        {
    //            Console.Write(" " + strings[j]);
    //        }
    //        Console.Write("\nSorting Of string is : ");
    //        for (int i= 0;i < Count; ++i)
    //        {
    //            for(j = i+1;j < Count; ++j)
    //            {
    //                if (string.Compare(strings[i], strings[j])>0)
    //                {
    //                    string temp = strings[i];
    //                    strings[i] = strings[j];
    //                    strings[j] = temp;
    //                }
    //            }
    //        }
    //        Console.WriteLine(string.Join(" ",strings));
    //    }
    //}


}
