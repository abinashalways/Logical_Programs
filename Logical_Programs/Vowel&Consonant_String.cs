using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Vowel_Consonant_String
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string? str = Console.ReadLine();
            int Vowel = 0,Consonant=0,Digit=0,Space=0, Special_Char=0;
            for (int i = 0;i<str!.Length;i++)
            {
                if (char.ToLower(str[i]) == 'a' ||char.ToLower( str[i]) == 'e' || char.ToLower(str[i]) == 'i' || char.ToLower(str[i]) == 'o' || char.ToLower(str[i]) == 'u')
                {
                    Vowel++;
                }
                else if (str[i] >='a' && str[i] <= 'z')
                {
                    Consonant++;
                }
                else if (char.ToLower(str[i]) >= '0' && char.ToLower(str[i]) <= '9')
                {
                    Digit++;
                }
                else if (str[i] == ' ')
                {
                    Space++;
                }  
                else
                {
                    Special_Char++;
                }
            }
            Console.Write("Vowels : " + Vowel);
            Console.Write("\nConsonants : " + Consonant);
            Console.Write("\nDigits : " + Digit);
            Console.Write("\nSpaces : " + Space);
            Console.Write("\nSpecial Char : " + Special_Char);


            Console.ReadLine();
        }
    }
}
