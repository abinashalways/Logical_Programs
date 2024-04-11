using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class LCM
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st Number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int Big, Small;
            if (a > b)
            {
                Big = a;
                Small = b;
            }
            else
            {
                Big = b;
                Small = a;
            }

            for (int i = 1; i <= Big; i++)
            {
                if(((Big*i)%Small) == 0)
                {
                    int LCM = Big * i;
                    Console.WriteLine("LCM is : "+LCM);break;
                }
            }
            Console.ReadLine();
        }
    }
}
