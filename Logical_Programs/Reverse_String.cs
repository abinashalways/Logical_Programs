using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Reverse_String
    {
        static void Main()
        {
            string str = "Abinash";
                Console.Write(str);
            string E = "";
            Console.WriteLine();
            foreach (char s in str)
            {
                Console.Write(s);
            }
            Console.WriteLine("\nAfter Reverse : 1st Method");
            for(int i = str.Length-1;i>=0 ; i--)
            {
                Console.Write(" " + str[i]);

            }
            Console.WriteLine("\nAfter Reverse : 2nd Method");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                E = E + str[i];

            }
            Console.WriteLine(E);
            Console.ReadLine();
        }
    }
}
