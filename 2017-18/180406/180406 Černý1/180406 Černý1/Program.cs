using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _180406_Černý1
{
    class Program
    {
        private static ConsoleColor _sudaBarva = ConsoleColor.Cyan;
        private static ConsoleColor _lichaBarva = ConsoleColor.Blue;

        private static int _vertikalniHodnota = 10;
        private static int _horizontalniHodnota = 10;

        static void Main(string[] args)
        {
            Console.Title = "Použití metod";
            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.Write($@"Menu 
------------------------------------------------------	
    X/Z ~ Změň horizontální/vodorovnou hodnotu ({_horizontalniHodnota})
    Y/S ~ Změň vertikální/svislou hodnotu ({_vertikalniHodnota})
------------------------------------------------------
    A ~ Změň barvu pro sudé hodnoty ({_sudaBarva.ToString()})
    B ~ Změň barvu pro liché hodnoty ({_lichaBarva.ToString()})
------------------------------------------------------

    V ~ Vertikální  
    H ~ Horizontální  
    Shift + V ~ Vertikální x 10 
    Shift + H ~ Horizontální x 10 
    Shift + S ~ Šachovnice  
    Shift + D ~ Diagonála LH
    Control + D ~ Diagonála LD
    Shift + Control + D ~ Kříž

AltGr + K ~ Konec programu
------------------------------------------------------	 
Co si přeješ: ");

                var cki = Console.ReadKey();

                Console.WriteLine();

                if (cki.Key == ConsoleKey.V && cki.Modifiers == 0) Vertikalni();
                else if (cki.Key == ConsoleKey.H && cki.Modifiers == 0) Horizontalni();
                else if (cki.Key == ConsoleKey.V && cki.Modifiers == ConsoleModifiers.Shift) Vertikalni10();
                else if (cki.Key == ConsoleKey.H && cki.Modifiers == ConsoleModifiers.Shift) Horizontalni10();
                else if (cki.Key == ConsoleKey.S && cki.Modifiers == ConsoleModifiers.Shift) Sachovnice();
                else if (cki.Key == ConsoleKey.D && cki.Modifiers == ConsoleModifiers.Shift) DiagonalaLH();
                else if (cki.Key == ConsoleKey.D && cki.Modifiers == ConsoleModifiers.Control) DiagonalaLD();
                else if (cki.Key == ConsoleKey.D && cki.Modifiers == (ConsoleModifiers.Shift | ConsoleModifiers.Control)) Kriz();
                else if (cki.Key == ConsoleKey.K && cki.Modifiers == (ConsoleModifiers.Alt | ConsoleModifiers.Control)) break;
                else if ((cki.Key == ConsoleKey.Z || cki.Key == ConsoleKey.X) && cki.Modifiers == 0) _horizontalniHodnota = ZadejCislo();
                else if ((cki.Key == ConsoleKey.S || cki.Key == ConsoleKey.Y) && cki.Modifiers == 0) _vertikalniHodnota = ZadejCislo();
                else if (cki.Key == ConsoleKey.A && cki.Modifiers == 0) _sudaBarva = ZmenBarvu();
                else if (cki.Key == ConsoleKey.B && cki.Modifiers == 0) _lichaBarva = ZmenBarvu();
                else Console.WriteLine("Neumím!");

                Console.WriteLine();
                Console.Write($@"Odentruj!");
                Console.ReadLine();
            } while (true);
        }

        private static void Vertikalni()
        {
            for (int i = 1; i <= _vertikalniHodnota; i++)
            {
                if (i % 2 == 1) Console.BackgroundColor = _sudaBarva;
                else Console.BackgroundColor = _lichaBarva;
                Console.WriteLine("  ");
            }
            Console.BackgroundColor = ConsoleColor.White;
        }

        private static void Horizontalni()
        {
            for (int i = 1; i <= _horizontalniHodnota; i++)
            {
                if (i % 2 == 1) Console.BackgroundColor = _sudaBarva;
                else Console.BackgroundColor = _lichaBarva;
                Console.Write("  ");
            }
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;
        }

        private static void Vertikalni10()
        {

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 1) Console.BackgroundColor = _sudaBarva;
                else Console.BackgroundColor = _lichaBarva;
                for (int j = 1; j <= _vertikalniHodnota; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.White;
        }

        private static void Horizontalni10()
        {
            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= _horizontalniHodnota; i++)
                {
                    if (i % 2 == 1) Console.BackgroundColor = _sudaBarva;
                    else Console.BackgroundColor = _lichaBarva;
                    Console.Write("  ");
                }
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White;
            }
        }

        private static void Sachovnice()
        {
            for (int j = 1; j <= _vertikalniHodnota; j++)
            {
                for (int i = 1; i <= _horizontalniHodnota; i++)
                {
                    if ((i + j) % 2 == 1) Console.BackgroundColor = _sudaBarva;
                    else Console.BackgroundColor = _lichaBarva;
                    Console.Write("  ");
                }
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White;
            }
        }

        private static void DiagonalaLH()
        {
            for (int j = 1; j <= _vertikalniHodnota; j++)
            {
                for (int i = 1; i <= _horizontalniHodnota; i++)
                {
                    if (i == j) Console.BackgroundColor = _sudaBarva;
                    else Console.BackgroundColor = _lichaBarva;
                    Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.BackgroundColor = ConsoleColor.White;
        }

        private static void DiagonalaLD()
        {
            for (int j = _vertikalniHodnota; j >= 1; j--)
            {
                for (int i = 1; i <= _horizontalniHodnota; i++)
                {
                    if (i == j) Console.BackgroundColor = _sudaBarva;
                    else Console.BackgroundColor = _lichaBarva;
                    Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.BackgroundColor = ConsoleColor.White;
        }

        private static void Kriz()
        {
            for (int j = 1; j <= _vertikalniHodnota; j++)
            {
                for (int i = 1; i <= _horizontalniHodnota; i++)
                {
                    if (i == j || i == _horizontalniHodnota + 1 - j) Console.BackgroundColor = _sudaBarva;
                    else Console.BackgroundColor = _lichaBarva;
                    Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.BackgroundColor = ConsoleColor.White;
        }

        private static int ZadejCislo()
        {
            while (true)
            {
                Console.Write("Zadej hodnotu <2;120>: ");
                string vstup = Console.ReadLine();
                try
                {
                    int vstupInt = Convert.ToInt32(vstup);
                    if (vstupInt <= 120 && vstupInt >= 2)
                    {
                        Console.WriteLine($"Použit vstup {vstupInt}");
                        return vstupInt;
                    }
                    else
                    {
                        Console.WriteLine("Hodnota není ze zadaného intervalu");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Chyba: {e.Message}");
                }
            }
        }

        private static ConsoleColor ZmenBarvu()
        {
            while (true)
            {
                Console.Write($"Zadej barvu: ");
                string vstup = Console.ReadLine();
                try
                {
                    ConsoleColor barva = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), vstup, true);
                    Console.Write($"Použita barva ");
                    Console.BackgroundColor = barva;
                    Console.Write(barva.ToString());
                    Console.BackgroundColor = ConsoleColor.White;
                    return barva;
                }
                catch
                {
                    Console.WriteLine("Neznámý vstup! Zadejte barvu slovy nebo číslem 0-15");
                    Console.WriteLine();
                    Console.WriteLine($"{"Jméno",15} | {"#",-2} [---Barva---]");
                    Console.WriteLine($"-------------------------------------");
                    for (int i = 0; i <= 15; i++)
                    {
                        Console.Write($"{Enum.Parse(typeof(ConsoleColor), i.ToString()),15} | {i,-2} ");
                        Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), i.ToString());
                        Console.WriteLine($"[           ]");
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    continue;
                }
            }
        }
    }
}