using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _180413_Černý1
{
    class Program
    {
        private static ConsoleKeyInfo _cki;
        private static int _velikost = 10;
        private static Random _random = new Random();

        private static ConsoleColor _sudaBarva;
        private static ConsoleColor _lichaBarva;

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            
            while (true)
            {
                Console.Clear();

                do
                {
                    _sudaBarva = (ConsoleColor) _random.Next(0, 16);
                    _lichaBarva = (ConsoleColor) _random.Next(0, 16);
                } while (_sudaBarva == _lichaBarva);

                Console.Write($@"Menu
------------------------------------------------------
    V ~ Změň velikost <10;{Console.WindowWidth})
------------------------------------------------------
    ?:
    L ~ diagonála (LH/PD)
    D ~ diagonála (PH/LD)
    K ~ kříž
------------------------------------------------------
    ? ~ Kresli <{_velikost};{_velikost}> po 2
    Shift + ? ~ Kresli <{_velikost};{_velikost}> po 3
    Ctrl + ? ~ Kresli <{_velikost};{_velikost}> po 4
    Alt + ? ~ Kresli <{_velikost};{_velikost}> po 5
    Shift + Ctrl + ? ~ Kresli <{_velikost};{_velikost}> po 6
    Shift + Alt + ? ~ Kresli <{_velikost};{_velikost}> po 7
    Ctrl + Alt + ? ~ Kresli <{_velikost};{_velikost}> po 8
    Shift + Ctrl + Alt + ? ~ Kresli <{_velikost};{_velikost}> po 9
AltGr + E ~ Konec programu
------------------------------------------------------
Co si přeješ: ");

                _cki = Console.ReadKey();
                Console.WriteLine();

                if (_cki.Key == ConsoleKey.E && _cki.Modifiers == (ConsoleModifiers.Control | ConsoleModifiers.Alt)) break;

                if (_cki.Key == ConsoleKey.V && _cki.Modifiers == 0) _velikost = ZmenVelikost(_velikost);
                else if (_cki.Modifiers == 0) Preved(2);
                else if (_cki.Modifiers == ConsoleModifiers.Shift) Preved(3);
                else if (_cki.Modifiers == ConsoleModifiers.Control) Preved(4);
                else if (_cki.Modifiers == ConsoleModifiers.Alt) Preved(5);
                else if (_cki.Modifiers == (ConsoleModifiers.Shift | ConsoleModifiers.Control)) Preved(6);
                else if (_cki.Modifiers == (ConsoleModifiers.Shift | ConsoleModifiers.Alt)) Preved(7);
                else if (_cki.Modifiers == (ConsoleModifiers.Control | ConsoleModifiers.Alt)) Preved(8);
                else if (_cki.Modifiers == (ConsoleModifiers.Shift | ConsoleModifiers.Control | ConsoleModifiers.Alt)) Preved(9);
                else
                {
                    Console.WriteLine($"{_cki.Key} + {_cki.Modifiers} ~ {_cki.KeyChar} >> to neumím");
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("Odenteruj!");
                Console.ReadLine();
            }
        }

        private static int ZmenVelikost(int puvodniVelikost)
        {
            Console.Write($"Zadej velikost <10;{Console.WindowWidth}): ");
            string vstup = Console.ReadLine();

            try
            {
                int novaVelikost = Convert.ToInt32(vstup);
                if (novaVelikost >= 10 && novaVelikost < Console.WindowWidth) return novaVelikost;
                else return puvodniVelikost;
            }
            catch
            {
                return puvodniVelikost;
            }
        }

        private static void Preved(int krok)
        {
            Console.WriteLine($"Kreslení diagonál");
            Console.WriteLine($"Barva1: {_sudaBarva}");
            Console.WriteLine($"Barva2: {_lichaBarva}");
            Console.WriteLine($"Velikost {_velikost}x{_velikost}");
            Console.WriteLine($"Krok: {krok}");

            if (_cki.Key == ConsoleKey.L) DiagonalaL(krok);
            else if (_cki.Key == ConsoleKey.D) DiagonalaD(krok);
            else if (_cki.Key == ConsoleKey.K) Kriz(krok);
        }

        private static void DiagonalaL(int krok)
        {
            for (int i = 0; i < _velikost; i++)
            {
                for (int j = 0; j < _velikost; j++)
                {
                    if ((i-j) % krok == 0) Console.BackgroundColor = _sudaBarva;
                    else Console.BackgroundColor = _lichaBarva;

                    Console.Write(" ");
                }

                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.White;
        }

        private static void DiagonalaD(int krok)
        {
            for (int i = 0; i < _velikost; i++)
            {
                for (int j = 0; j < _velikost; j++)
                {
                    if ((i + j) % krok == 0) Console.BackgroundColor = _sudaBarva;
                    else Console.BackgroundColor = _lichaBarva;

                    Console.Write(" ");
                }

                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.White;
        }

        private static void Kriz(int krok)
        {
            for (int i = 0; i < _velikost; i++)
            {
                for (int j = 0; j < _velikost; j++)
                {
                    if (((i + j) % krok == 0) || ((i - j) % krok == 0)) Console.BackgroundColor = _sudaBarva;
                    else Console.BackgroundColor = _lichaBarva;

                    Console.Write(" ");
                }

                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}