using System;

namespace _180119_Černý1
{
    class Program
    {
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
k ~ konec
Co si přeješ: ");
                string rl = Console.ReadLine();
                if (rl == "k") break;
                else if (rl == "f1") VypišCyklusWhile1();
                else if (rl == "f2") VypišCyklusWhile2();
                else if (rl == "f3") VypišCyklusWhile3();
                else if (rl == "f4") VypišCyklusWhile4();
                else Console.Write($"{rl} <> to neumím!!!");
                System.Threading.Thread.Sleep(1000);
            }
            Konči();

        }

        private static void VypišCyklusWhile1()
        {
            int č1 = NačtiAZkontrolujInterval(-10,-5);
            int č2 = NačtiAZkontrolujInterval(5, 10);

            Console.WriteLine($"Výpis čísel od {č1} do {č2}");
            
            int i = č1;
            while (i <= č2)
            {
                Console.WriteLine("~ "+i);
                i++;
            }
        }
        private static void VypišCyklusWhile2()
        {
            int č1 = NačtiAZkontrolujInterval(-10, -5);
            int č2 = NačtiAZkontrolujInterval(5, 10);
            int č3 = NačtiAZkontrolujInterval(2, 5);
            
            Console.WriteLine($"Výpis čísel od {č1} do {č2} po {č3}");

            int i = č1;
            while (i <= č2)
            {
                Console.WriteLine("~ " + i);
                i+=č3;
            }
        }
        private static void VypišCyklusWhile3()
        {
            int č1 = NačtiAZkontrolujInterval(5, 10);
            int č2 = NačtiAZkontrolujInterval(-10, -5);

            Console.WriteLine($"Výpis čísel od {č1} do {č2}");

            int i = č1;
            while (i >= č2)
            {
                Console.WriteLine("~ " + i);
                i--;
            }
        }
        private static void VypišCyklusWhile4()
        {
            int č1 = NačtiAZkontrolujInterval(5, 10);
            int č2 = NačtiAZkontrolujInterval(-10, 5);
            int č3 = NačtiAZkontrolujInterval(2, 5);

            Console.WriteLine($"Výpis čísel od {č1} do {č2} po {č3}");

            int i = č1;
            while (i >= č2)
            {
                Console.WriteLine("~ " + i);
                i -= č3;
            }
        }

        private static int NačtiAZkontrolujInterval(int zacatek, int konec)
        {
            int c = 0;
            while (true)
            {
                Console.Write($@"Zadej číslo <{zacatek};{konec}>: ");
                string rl = Console.ReadLine();
                try
                {
                    c = Convert.ToInt32(rl);
                    if (c >= zacatek && c <= konec) break;
                }
                catch
                {
                    continue;
                }
            }

            return c;
        }

        private static void Konči()
        {
            Console.Write("Ahoj ");
            Console.Write(".");
            System.Threading.Thread.Sleep(200);
            Console.Write(".");
            System.Threading.Thread.Sleep(200);
            Console.Write(".");
            System.Threading.Thread.Sleep(200);
            Console.Write(".");
            System.Threading.Thread.Sleep(200);
            Console.Write(".");
            System.Threading.Thread.Sleep(200);
            Console.Write(".");
            System.Threading.Thread.Sleep(200);
            Console.Write(".");
            System.Threading.Thread.Sleep(200);
            Console.Write(".");
            System.Threading.Thread.Sleep(200);
            Console.Write(".");
            System.Threading.Thread.Sleep(200);
            Console.Write(".");
            System.Threading.Thread.Sleep(200);
        }
    }
}
