using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180420_Černý2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            while (true)
            {
                Console.Clear();
                Console.Write(@"Jako písemka, ale s použitím jedné metody s návratem a nepovinným parametrem
Menu
------------------------------------------------------
PgUp ~ Zvětši velikost kurzoru
PgDown ~ Zmenši velikost kurzoru
AltGr + E ~ Konec programu
------------------------------------------------------
Co si přeješ: ");

                var cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.PageUp) Console.CursorSize = ZmenVelikost();
                else if (cki.Key == ConsoleKey.PageDown) Console.CursorSize = ZmenVelikost(false);
                else if (cki.Key == ConsoleKey.E && cki.Modifiers == (ConsoleModifiers.Alt | ConsoleModifiers.Control)) break;
                else Console.WriteLine($"{cki.Modifiers} + {cki.Key} ~ {cki.Key} >> To neumím!");

            }
        }

        private static int ZmenVelikost(bool b = true)
        {
            if (Console.CursorSize != 100 && b)
            {
                Console.CursorSize++;
                Console.WriteLine($"Zvětšení velikosti kurzoru o bod. Momentální velikost {Console.CursorSize}");
                Console.WriteLine("Odenteruj!");
                Console.ReadLine();
                return Console.CursorSize;
            }

            if (Console.CursorSize != 1 && !b)
            {
                Console.CursorSize--;
                Console.WriteLine($"Zmenšení velikosti kurzoru o bod. Momentální velikost {Console.CursorSize}");
                Console.WriteLine("Odenteruj!");
                Console.ReadLine();
                return Console.CursorSize;
            }

            Console.WriteLine($"Zvětšení kurzoru nejde! Už je {Console.CursorSize}");
            Console.WriteLine("Odenteruj!");
            Console.ReadLine();
            return Console.CursorSize;
        }
    }
}
