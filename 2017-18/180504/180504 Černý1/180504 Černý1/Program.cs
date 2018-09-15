using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180504_Černý1
{
    class Program
    {
        static int _pocatek = 0, _konec = 10;
        static void Main(string[] args)
        {
            Console.WindowWidth = Console.LargestWindowWidth;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.Write("Menu\nVýpis ASCII <");
                //Zvýratnění zadávaných hodnot
                Console.ForegroundColor = ConsoleColor.Red; Console.Write(_pocatek);
                Console.ForegroundColor = ConsoleColor.Gray; Console.Write("0,");
                Console.ForegroundColor = ConsoleColor.Red; Console.Write(_konec);
                Console.ForegroundColor = ConsoleColor.Gray; Console.Write($@"9>
--------------------------------------------
Z ~ Změna počátku
Shift + Z ~ Změna konce
--------------------------------------------
V ~ Výpis vodorovně
Shift + V ~ Výpis svisle
--------------------------------------------
Alt + V ~ Výpis vodorovně s hledáním
Alt + Shift + V ~ Výpis svisle s hledáním
--------------------------------------------
K ~ Konec
Co si přeješ: ");
                ConsoleKeyInfo cki = Console.ReadKey();
                Console.WriteLine();
                if (cki.Key == ConsoleKey.K && cki.Modifiers == 0) break;
                else if (cki.Key == ConsoleKey.Z && cki.Modifiers == 0) _pocatek = Změna(true);
                else if (cki.Key == ConsoleKey.Z && cki.Modifiers == ConsoleModifiers.Shift) _konec = Změna();
                else if (cki.Key == ConsoleKey.V && cki.Modifiers == 0) VypišPoŘádcích();
                else if (cki.Key == ConsoleKey.V && cki.Modifiers == ConsoleModifiers.Shift) VypišPoSloupcích();
                else if (cki.Key == ConsoleKey.V && cki.Modifiers == ConsoleModifiers.Alt) VypišPoŘádcíchZ();
                else if (cki.Key == ConsoleKey.V && cki.Modifiers == (ConsoleModifiers.Shift | ConsoleModifiers.Alt)) VypišPoSloupcíchZ();
                else Console.WriteLine("Neumím");
                //System.Threading.Thread.Sleep(500);
                Console.WriteLine("Odenteruj");
                Console.ReadLine();
            }
        }

        private static int Změna(bool b = false)
        {
            //b == true >> číslo pro počátek
            //b == false >> číslo pro konec
            Console.Write(b ? "Zadej číslo <0;99> pro počátek:" : "Zadej číslo <0;99> pro konec:");
            string vstup = Console.ReadLine();

            try
            {
                int vstupInt = Convert.ToInt32(vstup);

                if (vstupInt < 0 || vstupInt > 99)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{vstup} není číslo z <0;99>");
                }
                else if ((vstupInt > _konec && b) || (vstupInt < _pocatek && !b))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hodnota dolní a horní hranice je větší.");
                    Console.WriteLine("Zůstane původní hodnota!");
                }
                else if ((vstupInt == _konec && b) || (vstupInt == _pocatek && !b))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hodnota dolní a horní hranice je stejná.");
                    Console.WriteLine("Zůstane původní hodnota!");
                }
                else if ((vstupInt < _konec && b) || (vstupInt > _pocatek && !b)) return vstupInt;

                return b ? _pocatek : _konec;
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{vstup} není číslo z <0;99>");
                Console.WriteLine("Zůstane původní hodnota!");
                return b ? _pocatek : _konec;
            }
        }

        private static void VypišPoŘádcích(bool zvyraznitZnak = false, char znakKeZvyrazneni = '0')
        {
            //První 3 řádky
            Console.WriteLine("┌────┬─────────────────────┬─────────────────────────────────────────┐");
            Console.WriteLine("│    │ 0 1 2 3 4 5 6 7 8 9 │   0   1   2   3   4   5   6   7   8   9 │");
            Console.WriteLine("├────┼─────────────────────┼─────────────────────────────────────────┤");

            //Opakující se řádek
            for (int i = _pocatek; i <= _konec; i++)
            {
                //První sloupec (č. řádku)
                Console.Write($"│ {i,2} │ ");

                //Druhý sloupec (znaky)
                for (int j = 0; j <= 9; j++)
                {
                    char znak = (char)Convert.ToInt32(string.Concat(i, j));
                    if (znak == 7 || znak == 8 || znak == 9 || znak == 10 || znak == 11 || znak == 12 || znak == 13 || znak == 183)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("_ ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        //Zvýraznění znaku
                        if (zvyraznitZnak && znak == znakKeZvyrazneni)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{znak} ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.Write($"{znak} ");
                        }
                    }
                }

                //Třetí sloupec (čísla)
                Console.Write("│ ");
                for (int j = 0; j <= 9; j++)
                {
                    string cislo = string.Concat(i, j);
                    Console.Write($"{cislo,3} ");
                }
                Console.WriteLine("│");
            }

            //Poslední řádek
            Console.WriteLine($"└────┴─────────────────────┴─────────────────────────────────────────┘");
        }

        private static void VypišPoSloupcích(bool zvyraznitZnak = false, char znakKeZvyrazneni = '0')
        {
            //První řádek
            Console.Write("┌───┬─");
            for (int i = _pocatek; i <= _konec; i++)
            {
                Console.Write("────");
            }
            Console.WriteLine("┐");

            //x == 0 >> Výpis znaků
            //x == 1 >> Výpis čísel
            for (int x = 0; x <= 1; x++)
            {
                //Hlavička
                Console.Write("│   │");
                for (int i = _pocatek; i <= _konec; i++)
                {
                    Console.Write($" {i,3}");
                }

                Console.WriteLine(" │");

                //Řádek po hlavičce
                Console.Write("├───┼─");
                for (int i = _pocatek; i <= _konec; i++)
                {
                    Console.Write("────");
                }

                Console.WriteLine("┤");

                //Řádky znaků/čísel
                for (int i = 0; i <= 9; i++)
                {
                    //První sloupec (č. řádku)
                    Console.Write($"│ {i} │");

                    //Druhý sloupec (znaky/čísla)
                    for (int j = _pocatek; j <= _konec; j++)
                    {
                        if (x == 1)
                        {
                            //Výpis čísla
                            Console.Write($" {string.Concat(j, i),3}");
                        }
                        else
                        {
                            //Výpis znaku
                            char znak = (char)Convert.ToInt32(string.Concat(j, i));
                            if (znak == 7 || znak == 8 || znak == 9 || znak == 10 || znak == 11 || znak == 12 || znak == 13 || znak == 183)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("   _");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            else
                            {
                                //Zvýraznění znaku
                                if (zvyraznitZnak && znak == znakKeZvyrazneni)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($" {znak,3}");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                else
                                {
                                    Console.Write($" {znak,3}");
                                }
                            }
                        }
                    }

                    Console.WriteLine(" │");
                }

                //Řádek po znacích
                Console.Write(x == 1 ? "└───┴─" : "├───┼─");
                for (int i = _pocatek; i <= _konec; i++)
                {
                    Console.Write("────");
                }

                //Prostřední řádek >> ┤
                //Poslední řádek >> ┘
                Console.WriteLine(x == 1 ? "┘" : "┤");
            }
        }

        private static void VypišPoŘádcíchZ()
        {
            Console.Write("Zadej znak: ");
            char znak = Console.ReadKey().KeyChar;
            VypišPoŘádcích(true, znak);
        }

        private static void VypišPoSloupcíchZ()
        {
            Console.Write("Zadej znak: ");
            char znak = Console.ReadKey().KeyChar;
            VypišPoSloupcích(true, znak);
        }

    }
}