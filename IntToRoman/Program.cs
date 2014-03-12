using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}: {1}", "1990", IntToRoman(1990));
            Console.WriteLine("{0}: {1}", "2008", IntToRoman(2008));
            Console.WriteLine("{0}: {1}", "1666", IntToRoman(1666));

        }

        static string IntToRoman(int number)
        {
            string result = null;

            int[] numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] romanDigits = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (int i = 0; i < numbers.Length && number > 0; i++)
            {
                while (number >= numbers[i])
                {
                    number -= numbers[i];
                    result += romanDigits[i];
                }
            }

            return result;
        }
    }
}
