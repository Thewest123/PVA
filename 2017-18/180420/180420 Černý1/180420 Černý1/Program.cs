using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180420_Černý1
{
    class Program
    {
        static Random nc = new Random();
        static void Main(string[] args)
        {
            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.Write($@"Menu 
------------------------------------------------------	
N ~ Generování celých čísel <0;10>, dokud není vygenerována 0 (do ... while)
Shift + N ~ Generování celých čísel <0;10>, dokud není vygenerována 0 (for)
D ~ Generování desetinných čísel, dokud není vygenerované číslo < 0.2 (do ... while)
Shift + D ~ Generování desetinných čísel, dokud není vygenerované číslo < 0.2 (for)
Z ~ Generování desetinných čísel, se zaokrouhlením <1;10> (do ... while)
Shift + Z ~ Generování desetinných čísel, se zaokrouhlením <1;10> (for)
H ~ Hledání dělitelnosti náhodné 
Shift + H ~ Hledání dělitelnosti se zadáním 
AltGr + K ~ Konec programu
------------------------------------------------------	 
Co si přeješ: ");
                ConsoleKeyInfo cki = Console.ReadKey();
                Console.WriteLine("");
                if (cki.Modifiers == (ConsoleModifiers.Control | ConsoleModifiers.Alt) && cki.Key == ConsoleKey.K) break;
                else if (cki.Modifiers == 0 && cki.Key == ConsoleKey.N) GenerujČíslaDo();
                else if (cki.Modifiers == ConsoleModifiers.Shift && cki.Key == ConsoleKey.N) GenerujČíslaFor();
                else if (cki.Modifiers == 0 && cki.Key == ConsoleKey.D) GenerujDČíslaDo();
                else if (cki.Modifiers == ConsoleModifiers.Shift && cki.Key == ConsoleKey.D) GenerujDČíslaFor();
                else if (cki.Modifiers == 0 && cki.Key == ConsoleKey.Z) GenerujDzČíslaDo();
                else if (cki.Modifiers == ConsoleModifiers.Shift && cki.Key == ConsoleKey.Z) GenerujDzČíslaFor();
                else if (cki.Modifiers == 0 && cki.Key == ConsoleKey.H) HledejDělitelnost();
                else if (cki.Modifiers == ConsoleModifiers.Shift && cki.Key == ConsoleKey.H) HledejDělitelnost(true);
                else Console.WriteLine($@"{cki.Modifiers} + {cki.Key} ~ {cki.KeyChar} >> to neumím!");
                Console.WriteLine($@"Odentruj!");
                Console.ReadLine();
            } while (true);
        }

        private static void GenerujČíslaDo()
        {
            Console.WriteLine("Generování celých čísel <0;10>, dokud není vygenerována 0");
            int i = 1;
            while (true)
            {
                int cislo = nc.Next(0, 11);
                Console.WriteLine($"{i,5} >> {cislo}");
                i++;
                if (cislo == 0) break;
                System.Threading.Thread.Sleep(200);
            }
        }

        private static void GenerujČíslaFor()
        {
            Console.WriteLine("Generování celých čísel <0;10>, dokud není vygenerována 0");
            int cislo = 1;
            for (int i = 1; cislo != 0; i++)
            {
                cislo = nc.Next(0, 11);
                Console.WriteLine($"{i,5} >> {cislo}");
                System.Threading.Thread.Sleep(200);
            }
        }

        private static void GenerujDČíslaDo()
        {
            Console.WriteLine("Generování desetinných čísel, dokud není vygenerované číslo < 0.2");
            int i = 1;
            while (true)
            {
                double cislo = nc.NextDouble();
                Console.WriteLine($"{i,5} >> {cislo}");
                i++;
                if (cislo < 0.2) break;
                System.Threading.Thread.Sleep(200);
            }
        }

        private static void GenerujDČíslaFor()
        {
            Console.WriteLine("Generování desetinných čísel, dokud není vygenerované číslo < 0.2");
            double cislo = 1.0;
            for (int i = 1; cislo >= 0.2; i++)
            {
                cislo = nc.NextDouble();
                Console.WriteLine($"{i,5} >> {cislo}");
                System.Threading.Thread.Sleep(200);
            }
        }

        private static void GenerujDzČíslaDo()
        {
            Console.WriteLine("Generování desetinných čísel, se zaokrouhlením <1;10>");
            int i = 1;
            while (true)
            {
                double cislo = nc.NextDouble();
                Console.WriteLine($"{i,5} >> {Math.Round(cislo, i)}");
                i++;
                if (i > 10) break;
                System.Threading.Thread.Sleep(200);
            }
        }

        private static void GenerujDzČíslaFor()
        {
            Console.WriteLine("Generování desetinných čísel, se zaokrouhlením <1;10>");
            for (int i = 1; i <= 10; i++)
            {
                double cislo = nc.NextDouble();
                Console.WriteLine($"{i,5} >> {Math.Round(cislo, i)}");
                System.Threading.Thread.Sleep(200);
            }
        }

        private static void HledejDělitelnost()
        {
            int dolniHranice = nc.Next(-50, -19);
            int horniHranice = nc.Next(20, 51);
            int hledanaDelitelnost = nc.Next(2, 11);

            Console.WriteLine("Hledání dělitelnosti: ");
            Console.WriteLine($"Dolní hranice <-50;20>: {dolniHranice}");
            Console.WriteLine($"Horní hranice <20;50>: {horniHranice}");
            Console.WriteLine($"Hledaná dělitelnost <2;10>: {hledanaDelitelnost}");

            Console.WriteLine();

            for (int i = dolniHranice; i <= horniHranice; i++)
            {
                if (i % hledanaDelitelnost == 0) Console.ForegroundColor = ConsoleColor.Green;
                else Console.ForegroundColor = ConsoleColor.Black;

                Console.Write($"{i,3} ");
                System.Threading.Thread.Sleep(200);
            }

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void HledejDělitelnost(bool v)
        {
            int dolniHranice = ZadejCislo(-50, -20);
            int horniHranice = ZadejCislo(20, 50);
            int hledanaDelitelnost = ZadejCislo(2, 10);

            Console.WriteLine("Hledání dělitelnosti: ");
            Console.WriteLine($"Dolní hranice <-50;20>: {dolniHranice}");
            Console.WriteLine($"Horní hranice <20;50>: {horniHranice}");
            Console.WriteLine($"Hledaná dělitelnost <2;10>: {hledanaDelitelnost}");

            Console.WriteLine();

            for (int i = dolniHranice; i <= horniHranice; i++)
            {
                if (i % hledanaDelitelnost == 0) Console.ForegroundColor = ConsoleColor.Green;
                else Console.ForegroundColor = ConsoleColor.Black;

                Console.Write($"{i,3} ");
                System.Threading.Thread.Sleep(200);
            }

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine();
        }

        private static int ZadejCislo(int dolniHranice, int horniHranice)
        {
            while (true)
            {
                Console.Write($"Zadej číslo <{dolniHranice},{horniHranice}>: ");
                string vstup = Console.ReadLine();
                bool konverze = int.TryParse(vstup, out int cislo);

                if (cislo >= dolniHranice && cislo <= horniHranice && konverze) return cislo;

                Console.WriteLine($"{vstup} není číslo nebo není z rozmezí <{dolniHranice};{horniHranice}>, vrátím {dolniHranice}");
                Console.WriteLine("Nebo chceš opakovat zadání? {a}");
                if (Console.ReadLine() != "a") return dolniHranice;
            }
        }
    }
}
