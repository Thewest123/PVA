using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180323d2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Použití metod";
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($@"Menu 
---------------------------------------------------	
za text metoda doplňte: jméno, návrat, parametry
---------------------------------------------------	
'0' ~ metoda MBNn(), string, žádné
'1' ~ metoda MBNn(), string, ConsoleColor
'2' ~ metoda MBNn(), string, ConsoleColor + ConsoleColor
'3' ~ metoda MBNn(), string, ConsoleColor + ConsoleColor + int
'4' ~ metoda MBNn(), string, ConsoleColor + ConsoleColor + int + decimal
'5' ~ metoda MBN(), žádný, ConsoleColor + ConsoleColor + int + decimal + int
'6' ~ metoda MBN(), žádný, ConsoleColor + ConsoleColor + int + decimal + int + decimal
'7' ~ metoda MBN(), žádný, ConsoleColor + ConsoleColor + int + decimal + int + decimal + decimal
'8' ~ metoda MBN(), žádný, ConsoleColor + ConsoleColor + int + decimal + int + decimal + decimal + ConsoleKeyInfo
'9' ~ metoda MBN(), žádný, ConsoleColor + ConsoleColor + int + decimal + int + decimal + decimal + ConsoleKeyInfo + string
Ctrl + Alt + N ~ metoda MBNn(), string, žádné
Ctrl + Alt + J ~ metoda MBNn(), string, ConsoleColor
Ctrl + Alt + D ~ metoda MBNn(), string, ConsoleColor + ConsoleColor
Ctrl + Alt + T ~ metoda MBNn(), string, ConsoleColor + ConsoleColor + int
Ctrl + Alt + C ~ metoda MBNn(), string, ConsoleColor + ConsoleColor + int + decimal
Alt + K ~ konec	
Co si přeješ: ");

                ConsoleKeyInfo cki = Console.ReadKey();
                Console.WriteLine($@"{cki.Key} {cki.KeyChar}");
                //po vytvoření metod >> zrušte komentáře
                if (cki.Modifiers == ConsoleModifiers.Alt && cki.Key == ConsoleKey.K) break;
                else if (cki.KeyChar == '0') Console.WriteLine(MBNn());
                else if (cki.KeyChar == '1') Console.WriteLine(MBNn(ConsoleColor.Red));
                else if (cki.KeyChar == '2') Console.WriteLine(MBNn(ConsoleColor.Green, ConsoleColor.Blue));
                else if (cki.KeyChar == '3') Console.WriteLine(MBNn(ConsoleColor.Blue, ConsoleColor.Cyan, 100));
                else if (cki.KeyChar == '4') Console.WriteLine(MBNn(ConsoleColor.Cyan, ConsoleColor.Magenta, 1, 123.456789m));
                else if (cki.KeyChar == '5') MBN(ConsoleColor.Magenta, ConsoleColor.Yellow, 1, 123.456789m, 2);
                else if (cki.KeyChar == '6') MBN(ConsoleColor.Yellow, ConsoleColor.DarkRed, 1, 123.456789m, 3, 987.654321m);
                else if (cki.KeyChar == '7') MBN(ConsoleColor.DarkRed, ConsoleColor.DarkGreen, 1, 123.456789m, 3, 987.654321m, 22.22m);
                else if (cki.KeyChar == '8') MBN(ConsoleColor.DarkGreen, ConsoleColor.DarkBlue, 1, 123.456789m, 3, 987.654321m, 22.22m, cki);
                else if (cki.KeyChar == '9') MBN(ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, 1, 123.456789m, 3, 987.654321m, 22.22m, cki, "AHOJ");
                else if (cki.Key == ConsoleKey.N && cki.Modifiers == (ConsoleModifiers.Control | ConsoleModifiers.Alt)) Console.WriteLine(MBNn());
                else if (cki.Key == ConsoleKey.J && cki.Modifiers == (ConsoleModifiers.Control | ConsoleModifiers.Alt)) Console.WriteLine(MBNn(ConsoleColor.DarkCyan));
                else if (cki.Key == ConsoleKey.D && cki.Modifiers == (ConsoleModifiers.Control | ConsoleModifiers.Alt)) Console.WriteLine(MBNn(ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow));
                else if (cki.Key == ConsoleKey.T && cki.Modifiers == (ConsoleModifiers.Control | ConsoleModifiers.Alt)) Console.WriteLine(MBNn(ConsoleColor.DarkYellow, ConsoleColor.DarkGray, 100));
                else if (cki.Key == ConsoleKey.C && cki.Modifiers == (ConsoleModifiers.Control | ConsoleModifiers.Alt)) Console.WriteLine(MBNn(ConsoleColor.DarkGray, ConsoleColor.Black, 1, 123.456789m));
                Console.WriteLine($@"Odentruj!");
                Console.ReadLine();
            } while (true);
        }

        private static void MBN(ConsoleColor bb, ConsoleColor bf, int cs, decimal d1, int i)
        {
            Console.BackgroundColor = bb;
            Console.ForegroundColor = bf;
            Console.CursorSize = cs;
            Console.WriteLine($@"metoda MBN, bez návratu, se dvěma parametry (barva pozadí ({bb}) a písma ({bf})).
Zaslané číslo: {d1} zaokrouhlené na {i} = {Math.Round(d1, i)}");
        }

        #region hotové metody
        private static void MBN(ConsoleColor bb, ConsoleColor bf, int cs, decimal d1, int i, decimal d2)
        {
            Console.BackgroundColor = bb;
            Console.ForegroundColor = bf;
            Console.CursorSize = cs;
            Console.WriteLine($@"metoda MBN, bez návratu, se dvěma parametry (barva pozadí ({bb}) a písma ({bf})).
Zaslaná čísla: {d1} + {d2} zaokrouhlené na {i} = {Math.Round(d1 + d2, i)}");
        }
        private static void MBN(ConsoleColor bb, ConsoleColor bf, int cs, decimal d1, int i, decimal d2, decimal d3)
        {
            Console.BackgroundColor = bb;
            Console.ForegroundColor = bf;
            Console.CursorSize = cs;
            Console.WriteLine($@"metoda MBN, bez návratu, se dvěma parametry (barva pozadí ({bb}) a písma ({bf})).
Zaslaná čísla: ({d1} + {d2})/{d3} zaokrouhlené na {i} = {Math.Round((d1 + d2) / d3, i)}");
        }
        private static void MBN(ConsoleColor bb, ConsoleColor bf, int cs, decimal d1, int i, decimal d2, decimal d3, ConsoleKeyInfo cki)
        {
            Console.BackgroundColor = bb;
            Console.ForegroundColor = bf;
            Console.CursorSize = cs;
            Console.WriteLine($@"metoda MBN, bez návratu, se dvěma parametry (barva pozadí ({bb}) a písma ({bf})).
Zaslaná čísla: ({d1} + {d2})/{d3} zaokrouhlené na {i} = {Math.Round((d1 + d2) / d3, i)}
Metoda byla vyvolána při stisku: {cki.Modifiers} + {cki.Key} >> '{cki.KeyChar}'");
        }
        private static void MBN(ConsoleColor bb, ConsoleColor bf, int cs, decimal d1, int i, decimal d2, decimal d3, ConsoleKeyInfo cki, string t)
        {
            Console.BackgroundColor = bb;
            Console.ForegroundColor = bf;
            Console.CursorSize = cs;
            Console.WriteLine($@"metoda MBN, bez návratu, se dvěma parametry (barva pozadí ({bb}) a písma ({bf})).
Zaslaná čísla: ({d1} + {d2})/{d3} zaokrouhlené na {i} = {Math.Round((d1 + d2) / d3, i)}
Metoda byla vyvolána při stisku: {cki.Modifiers} + {cki.Key} >> '{cki.KeyChar}'
{t}");
        }


        private static string MBNn()
        {
            return $@"metoda MBN, bez návratu, bez parametrů.";
        }
        private static string MBNn(ConsoleColor bb)
        {
            Console.BackgroundColor = bb;
            return $@"metoda MBN, bez návratu, s jedním parametrem (barva pozadí ({bb})).";
        }
        private static string MBNn(ConsoleColor bb, ConsoleColor bf)
        {
            Console.BackgroundColor = bb;
            Console.ForegroundColor = bf;
            return $@"metoda MBN, bez návratu, se dvěma parametry (barva pozadí ({bb}) a písma ({bf})).";
        }
        private static string MBNn(ConsoleColor bb, ConsoleColor bf, int cs)
        {
            Console.BackgroundColor = bb;
            Console.ForegroundColor = bf;
            Console.CursorSize = cs;
            return $@"metoda MBN, bez návratu, se dvěma parametry (barva pozadí ({bb}) a písma ({bf})).";
        }
        private static string MBNn(ConsoleColor bb, ConsoleColor bf, int cs, decimal d)
        {
            Console.BackgroundColor = bb;
            Console.ForegroundColor = bf;
            Console.CursorSize = cs;
            return $@"metoda MBN, bez návratu, se dvěma parametry (barva pozadí ({bb}) a písma ({bf})).
Zaslané číslo: {d}";
        }
        #endregion
    }
}
