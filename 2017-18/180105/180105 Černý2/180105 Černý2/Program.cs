using System;

namespace _180105_Černý2
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            while (true)
            {
                Console.Write("Zadej celé číslo: ");
                string vstup = Console.ReadLine();
                if (vstup.ToLower() == "k") break;
                int cislo;
                try
                {
                    cislo = Convert.ToInt32(vstup);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Chyba: " + e.Message);
                    Console.ReadLine();
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Zpracuj(cislo);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\n------------------------------");
            }
        }

        static void Zpracuj(int cislo)
        {
            if (cislo <= -10000) Console.WriteLine($"{cislo} >> Záporné pod -9999 >>  to je moc záporné!");
            else if (cislo >= -9999 && cislo <= -1000) VypisBarevne(cislo, 1000, 9999, "Záporné pod -1000");
            else if (cislo >= -999 && cislo <= -100) VypisBarevne(cislo, 100, 999, "Záporné pod -100");
            else if (cislo >= -99 && cislo <= -10) VypisBarevne(cislo, 10, 99, "Záporné pod -10");
            else if (cislo >= -9 && cislo <= -1) VypisBarevne(cislo, 1, 9, "Záporné pod -1");
            else if (cislo == 0) Console.WriteLine("0");
            else if (cislo >= 10000) Console.WriteLine($"{cislo} >> Kladné nad 9999 >>  to je moc kladné!");
            else if (cislo <= 9999 && cislo >= 1000) VypisBarevne(cislo, 1000, 9999, "Kladné nad 1000");
            else if (cislo <= 999 && cislo >= 100) VypisBarevne(cislo, 100, 999, "Kladné nad 100");
            else if (cislo <= 99 && cislo >= 10) VypisBarevne(cislo, 10, 99, "Kladné nad 10");
            else if (cislo <= 9 && cislo >= 1) VypisBarevne(cislo, 1, 9, "Kladné nad 1");
        }
        static void VypisBarevne(int cislo, int zacatek, int konec, string prefix)
        {
            Console.Write($"{cislo} >> {prefix} >> ");
            for (int i = zacatek; i <= zacatek + 2; i++)
            {
                if (Math.Abs(cislo) == i) Console.ForegroundColor = ConsoleColor.Red;
                if (cislo < 0) Console.Write("-");
                if (i != zacatek + 2)
                {
                    Console.Write(i);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(", ");
                }
                else Console.Write(i);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (Math.Abs(cislo) == konec - 3)
            {
                Console.Write(" ... ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(cislo);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", ");
            }
            else if (Math.Abs(cislo) == zacatek + 3)
            {
                Console.Write(", ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(cislo);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" ... ");
            }
            else if (Math.Abs(cislo) <= zacatek + 3 || Math.Abs(cislo) >= konec - 3) Console.Write(" ... ");
            else
            {
                Console.Write(" ... ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(cislo);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" ... ");
            }
            for (int i = konec - 2; i <= konec; i++)
            {
                if (Math.Abs(cislo) == i) Console.ForegroundColor = ConsoleColor.Red;
                if (cislo < 0) Console.Write("-");
                if (i != konec)
                {
                    Console.Write(i);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(", ");
                }
                else Console.Write(i);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}