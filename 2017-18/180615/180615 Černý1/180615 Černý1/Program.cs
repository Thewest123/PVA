using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180615_Černý1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Menu:");
                Console.WriteLine($"{"R <>",19} Načti ze souboru do pole a vypiš");
                Console.WriteLine($"{"Shift + R <>",19} Jako R, ale převede všechny malé krátké samohlásky (aeiyou) na velké");
                Console.WriteLine($"{"Shift + Alt + R <>",19} Jako R, ale převede všechny malé krátké samohlásky na velké a:");
                Console.WriteLine($"{"",19} zeptá se, jestli chcete původní soubor přepsat(A přepíše / Nic)");
                Console.WriteLine($"{"Ctrl + R <>",19} Jako R, ale při výpisu všechny malé krátké samohlásky přebarví::");
                Console.WriteLine($"{"",19} a - Red, e - Green, i - Blue, y - Cyan, o - Magenta, u - Yellow");
                Console.WriteLine($"{"AltGr + K <>",19} Konec programu");
                Console.Write($"Co si přeješ: ");

                var cki = Console.ReadKey();
                Console.WriteLine();

                if (cki.Key == ConsoleKey.K && cki.Modifiers == (ConsoleModifiers.Alt | ConsoleModifiers.Control)) break;
                if (cki.Key == ConsoleKey.R && cki.Modifiers == 0) NactiZeSouboru();
                else if (cki.Key == ConsoleKey.R && cki.Modifiers == ConsoleModifiers.Shift) NactiZeSouboruAPreved();
                else if (cki.Key == ConsoleKey.R && cki.Modifiers == (ConsoleModifiers.Shift | ConsoleModifiers.Alt)) NactiZeSouboruAPrevedAPrepis();
                else if (cki.Key == ConsoleKey.R && cki.Modifiers == ConsoleModifiers.Control) NactiZeSouboruAPrebarvi();
                else Console.WriteLine($"{cki.Modifiers} + {cki.Key} ~ {cki.KeyChar} <> Neumím!");

                //System.Threading.Thread.Sleep(1000);
                Console.ReadLine();
            }
        }

        private static void NactiZeSouboru()
        {
            string adresa = ZadejAdresu();
            string[] radky = File.ReadAllLines(adresa);

            Console.WriteLine($"Velikost: {radky.Length}");
            for (int i = 0; i < radky.Length; i++)
            {
                Console.WriteLine($"{i + 1,2}) {radky[i]}");
            }
        }

        private static void NactiZeSouboruAPreved()
        {
            string adresa = ZadejAdresu();
            string[] radky = File.ReadAllLines(adresa);

            Console.WriteLine($"Velikost: {radky.Length}");
            for (int i = 0; i < radky.Length; i++)
            {
                Console.WriteLine($"{i + 1,2}) {radky[i].Replace('a', 'A').Replace('e', 'E').Replace('i', 'I').Replace('y', 'Y').Replace('o', 'O').Replace('u', 'U')}");
            }
        }

        private static void NactiZeSouboruAPrevedAPrepis()
        {
            string adresa = ZadejAdresu();
            string[] radky = File.ReadAllLines(adresa);
            string[] zvetseneRadky = new string[radky.Length];

            Console.WriteLine($"Velikost: {radky.Length}");
            for (int i = 0; i < radky.Length; i++)
            {
                zvetseneRadky[i] = radky[i].Replace('a', 'A').Replace('e', 'E').Replace('i', 'I').Replace('y', 'Y').Replace('o', 'O').Replace('u', 'U');
                Console.WriteLine($"{i + 1,2}) {zvetseneRadky[i]}");
            }

            Console.Write("Chcete původní soubor přepsat? (y/N): ");
            var vstup = Console.ReadKey().Key;
            if (vstup == ConsoleKey.Y)
            {
                using (var sw = new StreamWriter(adresa, false))
                {
                    foreach (var radek in zvetseneRadky)
                    {
                        sw.WriteLine(radek);
                    }
                }
            }
        }

        private static void NactiZeSouboruAPrebarvi()
        {
            string adresa = ZadejAdresu();
            string[] radky = File.ReadAllLines(adresa);

            Console.WriteLine($"Velikost: {radky.Length}");
            for (int i = 0; i < radky.Length; i++)
            {
                Console.Write($"{i + 1,2}) ");

                foreach (char znak in radky[i])
                {
                    switch (znak)
                    {
                        case 'a':
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 'e':
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 'i':
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 'y':
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 'o':
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case 'u':
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                    }
                    Console.Write(znak);
                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }

        private static string ZadejAdresu()
        {
            string vstup;

            while (true)
            {
                Console.Write("Zadej aresu bez koncovky (test.txt): ");
                vstup = Console.ReadLine() + ".txt";

                if (vstup == "")
                {
                    Console.WriteLine($"Vstup \"{vstup}\" je nesmysl!");
                    continue;
                }

                if (!File.Exists(vstup))
                {
                    Console.WriteLine($"Soubor {vstup} NEexistuje a bude vytvořen!");
                    var fs = new FileStream(vstup, FileMode.Create);
                    fs.Close();
                }

                break;
            }

            return vstup;
        }
    }
}
