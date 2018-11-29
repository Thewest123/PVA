using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _180126cs
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.Title = "Cykly";
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                Console.Write($@"Menu
f1 ~ cyklus od <-10;-5> do <5;10>
f2 ~ cyklus od <-10;-5> do <5;10> po <2;5>
f3 ~ cyklus od <5;10> do <-10;-5>
f4 ~ cyklus od <5;10> do <-10;-5> po <2;5>
f5n ~ cyklus nahoru od <-10;10> do <-10;10> opakovat
f5d ~ cyklus dolů od <-10;10> do <-10;10> opakovat
f6n ~ cyklus nahoru od <-10;10> do <-10;10> prohodit 
f6d ~ cyklus dolů od <-10;10> do <-10;10> prohodit 
f56 ~ cyklus nahoru/dolů (dle rozdílu) od <-10;10> do <-10;10> 
f7 ~ cyklus od <-10;-5> do <5;10> po <2;5> náhodně / kód v inicializaci
f8 ~ cyklus od <-10;-5> do <5;10> po <2;5> náhodně / kód v iteraci
f9 ~ cyklus inicializace i=č1; podmínka i <= j; iterace i++, j-- / č1 z <-10;-5> j z <5;10>
k ~ konec
Co si přeješ: ");
                string rl = Console.ReadLine();
                if (rl == "k") break;
                else if (rl == "f1") VypišCyklusFor1();
                else if (rl == "f2") VypišCyklusFor2();
                else if (rl == "f3") VypišCyklusFor3();
                else if (rl == "f4") VypišCyklusFor4();
                else if (rl == "f5n") VypišCyklusFor5n();
                else if (rl == "f5d") VypišCyklusFor5d();
                else if (rl == "f6n") VypišCyklusFor6n();
                else if (rl == "f6d") VypišCyklusFor6d();
                else if (rl == "f56") VypišCyklusFor56();
                else if (rl == "f7") VypišCyklusFor7();
                else if (rl == "f8") VypišCyklusFor8();
                else if (rl == "f9") VypišCyklusFor9();
                else Console.Write($"{rl} <> to neumím!!!");
                System.Threading.Thread.Sleep(1000);
            }
            Konči();
        }

        private static void VypišCyklusFor1()
        {
            int č1 = ZadejČíslo(-10, -5);
            int č2 = ZadejČíslo(5, 10);
            Console.WriteLine($"Výpis čísel nahoru od {č1} do {č2}");

            for (int i = č1; i <= č2; i++)
            {
                Console.WriteLine("~ " + i);
            }
        }
        private static void VypišCyklusFor2()
        {
            int č1 = ZadejČíslo(-10, -5);
            int č2 = ZadejČíslo(5, 10);
            int krok = ZadejČíslo(2, 5);
            Console.WriteLine($"Výpis čísel nahoru od {č1} do {č2} po {krok}");

            for (int i = č1; i <= č2; i+=krok)
            {
                Console.WriteLine("~ " + i);
            }
        }
        private static void VypišCyklusFor3()
        {
            int č1 = ZadejČíslo(5, 10);
            int č2 = ZadejČíslo(-10, -5);
            Console.WriteLine($"Výpis čísel dolů od {č1} do {č2}");

            for (int i = č1; i >= č2; i--)
            {
                Console.WriteLine("~ " + i);
            }
        }
        private static void VypišCyklusFor4()
        {
            int č1 = ZadejČíslo(5, 10);
            int č2 = ZadejČíslo(-10, -5);
            int krok = ZadejČíslo(2, 5);
            Console.WriteLine($"Výpis čísel dolů od {č1} do {č2} po {krok}");

            for (int i = č1; i >= č2; i -= krok)
            {
                Console.WriteLine("~ " + i);
            }
        }
        private static void VypišCyklusFor5n()
        {
            int č1;
            int č2;
            while (true)
            {
                č1 = ZadejČíslo(-10, 10);
                č2 = ZadejČíslo(-10, 10);
                if (č1 >= č2) Console.WriteLine($"Výpis čísel nahoru od {č1} do {č2} nejde!");
                else break;
            }
            Console.WriteLine($"Výpis čísel nahoru od {č1} do {č2}");
            for (int i = č1; i <= č2; i++) Console.WriteLine("~ " + i);
        }
        private static void VypišCyklusFor5d()
        {
            int č1;
            int č2;
            while (true)
            {
                č1 = ZadejČíslo(-10, 10);
                č2 = ZadejČíslo(-10, 10);
                if (č1 <= č2) Console.WriteLine($"Výpis čísel dolů od {č1} do {č2} nejde!");
                else break;
            }
            Console.WriteLine($"Výpis čísel dolů od {č1} do {č2}");
            for (int i = č1; i >= č2; i--) Console.WriteLine("~ " + i);
        }
        private static void VypišCyklusFor6n()
        {
            int č1;
            int č2;
            while (true)
            {
                č1 = ZadejČíslo(-10, 10);
                č2 = ZadejČíslo(-10, 10);
                if (č1 > č2)
                {
                    int swap = č1;
                    č1 = č2;
                    č2 = swap;
                    break;
                }
                if (č1 == č2) Console.WriteLine("Výpis stejných čísel nahoru nejde!");
                else break;
            }
            Console.WriteLine($"Výpis čísel nahoru od {č1} do {č2}");
            for (int i = č1; i <= č2; i++) Console.WriteLine("~ " + i);
        }
        private static void VypišCyklusFor6d()
        {
            int č1;
            int č2;
            while (true)
            {
                č1 = ZadejČíslo(-10, 10);
                č2 = ZadejČíslo(-10, 10);
                if (č1 < č2)
                {
                    int swap = č1;
                    č1 = č2;
                    č2 = swap;
                    break;
                }
                if (č1 == č2) Console.WriteLine("Výpis stejných čísel dolů nejde!");
                else break;
            }
            Console.WriteLine($"Výpis čísel dolů od {č1} do {č2}");
            for (int i = č1; i >= č2; i--) Console.WriteLine("~ " + i);
        }
        private static void VypišCyklusFor56()
        {
            while (true)
            {
                int č1 = ZadejČíslo(-10, 10);
                int č2 = ZadejČíslo(-10, 10);
                if (č1 < č2)
                {
                    Console.WriteLine($"Výpis čísel nahoru od {č1} do {č2}");
                    for (int i = č1; i <= č2; i++) Console.WriteLine("~ " + i);
                    break;
                }
                if (č1 > č2)
                {
                    Console.WriteLine($"Výpis čísel dolů od {č1} do {č2}");
                    for (int i = č1; i >= č2; i--) Console.WriteLine("~ " + i);
                    break;
                }
                if (č1 == č2) Console.WriteLine("Výpis stejných čísel nejde!");
            }
            
        }
        private static void VypišCyklusFor7()
        {
            int č1 = random.Next(-10, -4);
            int č2 = random.Next(5, 11);
            int krok = random.Next(2, 6);
            Console.WriteLine($"Výpis čísel nahoru od {č1} do {č2} po {krok}");
            int i;
            for (i = č1,
                Console.ForegroundColor = ConsoleColor.Red,
                Console.WriteLine($"Oddíl inicializace: i = {č1}"),
                Console.ForegroundColor = ConsoleColor.White;
                i <= č2;
                i += krok)
            {
                Console.WriteLine("~ " + i);
            }
        }
        private static void VypišCyklusFor8()
        {
            int č1 = random.Next(-10, -4);
            int č2 = random.Next(5, 11);
            int krok = random.Next(2, 6);
            Console.WriteLine($"Výpis čísel nahoru od {č1} do {č2} po {krok}");
            for (int i = č1;
                i <= č2;
                i += krok,
                Console.ForegroundColor = ConsoleColor.Green,
                Console.WriteLine($"Oddíl iterace: Přičítám {krok}"),
                Console.ForegroundColor = ConsoleColor.White)
            {
                Console.WriteLine("~ " + i);
            }
        }
        private static void VypišCyklusFor9()
        {
            int č1 = ZadejČíslo(-10, -5);
            int j = ZadejČíslo(5, 10);
            Console.WriteLine($"Výpis čísel nahoru od {č1} do {j}");
            int i;
            for (i = č1,
                Console.ForegroundColor = ConsoleColor.Red,
                Console.WriteLine($"Oddíl inicializace: i = {č1}"),
                Console.ForegroundColor = ConsoleColor.White;
                i <= j;
                i++, j--,
                Console.ForegroundColor = ConsoleColor.Green,
                Console.WriteLine($"Oddíl iterace: i = {i}, j = {j}"),
                Console.ForegroundColor = ConsoleColor.White)
            {
                Console.WriteLine($"Tělo cyklu: {i} <> {j}");
            }
        }
        private static int ZadejČíslo(int c1, int c2)
        {
            int ret = 0;
            while (true)
            {
                Console.Write($@"Zadej číslo <{c1};{c2}>: ");
                string rl = Console.ReadLine();
                try
                {
                    ret = Convert.ToInt32(rl);
                    if (ret >= c1 && ret <= c2) break;
                }
                catch { }
            }
            return ret;
        }

        private static void Konči()
        {
            Console.Write("Ahoj ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(200);
            }
        }
    }
}
