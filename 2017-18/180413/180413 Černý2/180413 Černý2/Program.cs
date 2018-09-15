using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _180413_Černý2
{
    class Program
    {
        static int _x = 10;
        static int _y = 10;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowWidth = Console.LargestWindowWidth;
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Menu:");
                Console.WriteLine($"--------------------------------------------------------");
                Console.WriteLine($"N ~ Násobky");
                Console.WriteLine($"Shift + N ~ Změň násobky ({_x}x{_y})");
                Console.WriteLine($"--------------------------------------------------------");
                Console.WriteLine($"Ctrl + Alt + K ~ Konec programu");
                Console.WriteLine($"Shift + Ctrl + Alt + K ~ Konec programu s rouzloučením");
                Console.WriteLine($"--------------------------------------------------------");
                Console.Write($"Co chceš: ");

                var cki = Console.ReadKey();
                Console.WriteLine();

                if (cki.Key == ConsoleKey.N && cki.Modifiers == 0) Nasobky();
                else if (cki.Key == ConsoleKey.N && cki.Modifiers == ConsoleModifiers.Shift) ZmenNasobky();
                else if (cki.Key == ConsoleKey.K && cki.Modifiers == (ConsoleModifiers.Control | ConsoleModifiers.Alt)) break;
                else if (cki.Key == ConsoleKey.K && cki.Modifiers == (ConsoleModifiers.Shift | ConsoleModifiers.Control | ConsoleModifiers.Alt))
                {
                    Konec();
                    break;
                }
                else
                {
                    Console.WriteLine($"Neumím reagovat!");
                    Console.WriteLine($"Zadaný znak (System.Char): {cki.KeyChar}");
                    Console.WriteLine($"Zadaná modifikace (System.ConsoleModifiers): {cki.Modifiers}");
                    Console.WriteLine($"Zadaná klávesa (System.ConsoleKey): {cki.Key}");
                }

                Console.WriteLine();
                Console.WriteLine("Odenteruj!");
                Console.ReadLine();
            }
        }

        private static void ZmenNasobky()
        {
            try
            {
                Console.Write("Zadej hodnotu X: ");
                _x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Zadej hodnotu Y: ");
                _y = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Špatný vstup!");
            }

        }

        private static void Nasobky()
        {
            //Prvni radek
            Console.Write("┌");
            for (int i = 1; i <= _x; i++)
            {
                Console.Write("─────────────");
                if (i == _x) Console.Write("┐");
                else Console.Write("┬");
            }

            //Dalsi radky
            for (int i = 1; i <= _y; i++)
            {
                Console.WriteLine();
                Console.Write("│");
                for (int j = 1; j <= _x; j++)
                {
                    Console.Write($"{i,2} x {j,-2} = {i * j,-3}│");
                }
            }

            //Posledni radek
            Console.WriteLine();
            Console.Write("└");
            for (int i = 1; i <= _x; i++)
            {
                Console.Write("─────────────");
                if (i == _x) Console.Write("┘");
                else Console.Write("┴");
            }

        }

        private static void Konec()
        {
            Console.Write("Ahoj");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
