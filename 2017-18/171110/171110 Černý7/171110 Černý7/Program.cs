using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171110_Černý7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorSize = 100;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            while (true)
            {
                Console.CursorVisible = true;
                Console.Write("Zadej znak: ");
                char vstup = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Převod znaku na číslo\n------------------------------------------------");

                Console.WriteLine($"Převáděný znak: {vstup}");
                int cislo = Convert.ToInt32(vstup);
                Console.WriteLine($"Odpovídající CHAR znak: {cislo}\n");
                Console.CursorVisible = false;
                Console.Write("Odenteruj!");
                Console.ReadLine();
                Console.WriteLine("---------------------");
            }
        }
    }
}
