using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171110_Černý3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Console.Clear();

            char[] znaky = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };

            foreach (char znak in znaky)
            {
                string hexadecimalne = Convert.ToByte(znak).ToString("x2");
                string cislem = Convert.ToByte(znak).ToString("");
                string unikod = Convert.ToByte(znak).ToString("x4"); ;

                Console.WriteLine($"{znak} {cislem}");

                Console.WriteLine($"znakem = '{znak}'; <> {znak}");
                Console.WriteLine($"hexadecimalne = '\\x00{hexadecimalne}'; <> {znak}");
                Console.WriteLine($"cislem = (char){cislem}; <> {znak}");
                Console.WriteLine($"unikod = '\\u{unikod}'; <> {znak}\n\n");

            }

            Console.Write("Odenteruj!");
            Console.ReadLine();
        }

    }
}
