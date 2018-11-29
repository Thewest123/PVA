using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180316_Černý2
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = @"Menu !!!Nastavte šířku hodně velikou, ať vám n4 nezalamuje!!!
N ~ násobilka <1,10> x <1,10>
n1 ~ násobilka <1,10> x zadané číslo
    zadané číslo <-100;100> /při chybě >> info a zadat 2
n2 ~ násobilka zadaný interval x zadané číslo
    zadané číslo <-100;100> /při chybě >> info a zadat 2
    zadaný interval:
        dolní mez ~ <-10;-1> /při chybě >> info a zadat -10
        horní mez ~ <1;10> /při chybě >> info a zadat 10
n3 ~ násobilka zadaný interval x zadané číslo
    zadané číslo <-100;100> /při chybě >> info a zadat 2
    zadaný interval:
        dolní/horní mez ~ <-100;100> /při chybě >> info a zadat -10/10
        dolní mez < horní mez /při chybě >> info a prohodit
n4 ~ násobilka zadaný interval1 x zadaný interval2
    zadaný interval1:
        dolní/horní mez ~ <-100;100> /při chybě >> info a zadat -10/10
        dolní mez < horní mez /při chybě >> info a prohodit
    zadaný interval2:
        dolní/horní mez ~ <-5;5> /při chybě >> info a zadat -5/5
        dolní mez < horní mez /při chybě >> info a prohodit
k ~ konec
Co si přeješ: ";

            Console.Title = "Násobilka";

            while (true)
            {
                Console.Write(menu);
                string odpoved = Console.ReadLine();

                if (odpoved == "N") VypisN();
                else if (odpoved == "n1") VypisN1();
                else if (odpoved == "n2") VypisN2();
                else if (odpoved == "n3") VypisN3();
                else if (odpoved == "n4") VypisN4();
                else if (odpoved == "k") break;
                else Console.WriteLine($"{odpoved} neumím!");
            }
        }

        private static void VypisN()
        {
            Console.WriteLine("Trošku jsem to upgradnul :P");
            int sirka = ZadejCislo("Zadej šířku tabulky", 1, 20, 10);
            int vyska = ZadejCislo("Zadej výšku tabulky", 1, 20, 10);

            //Výpis prvního řádku
            //--Linka
            Console.Write("┌───");
            for (int i = 1; i <= sirka; i++) Console.Write($"┬───");
            Console.WriteLine("┐");

            //--Čísla
            Console.Write("│   ");
            for (int i = 1; i <= sirka; i++) Console.Write($"│{i,3}");
            Console.WriteLine("│");

            //Výpis ostatních řádků čísel
            for (int i = 1; i <= vyska; i++)
            {
                //Výpis oddělovací linky
                Console.Write("├───");
                for (int j = 1; j <= sirka; j++) Console.Write($"┼───");
                Console.WriteLine("┤");

                //Výpis čísel
                Console.Write($"│{i,3}");
                for (int j = 1; j <= sirka; j++) Console.Write($"│{i * j,3}");
                Console.WriteLine("│");
            }

            //Výpis poslední linky
            Console.Write("└───");
            for (int y = 1; y <= sirka; y++) Console.Write($"┴───");
            Console.WriteLine("┘");

            Console.ReadLine();
        }

        private static void VypisN1()
        {
            int nasobek = ZadejCislo("Zadej číslo pro násobek", -100, 100, 2);
            Console.WriteLine($"Násobilka {nasobek}");
            for (int i = 1; i <= 10; i++) Console.WriteLine($"{i,3} x {nasobek} = {i*nasobek}");
        }

        private static void VypisN2()
        {
            int nasobek = ZadejCislo("Zadej číslo pro násobek", -100, 100, 2);
            int dolniMez = ZadejCislo("Zadej číslo pro dolní mez", -10, -1, -10);
            int horniMez = ZadejCislo("Zadej číslo pro horní mez", 1, 10, 10);

            Console.WriteLine($"Násobilka <{dolniMez};{horniMez}> {nasobek}");
            for (int i = dolniMez; i <= horniMez; i++) Console.WriteLine($"{i,3} x {nasobek} = {i * nasobek}");
        }

        private static void VypisN3()
        {
            int nasobek = ZadejCislo("Zadej číslo pro násobek", -100, 100, 2);
            int dolniMez = ZadejCislo("Zadej číslo pro dolní mez", -100, 100, -10);
            int horniMez = ZadejCislo("Zadej číslo pro horní mez", -100, 100, 10);

            if (dolniMez > horniMez)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{dolniMez} > {horniMez} >> prohozeno");
                Console.ForegroundColor = ConsoleColor.Gray;

                int temp = dolniMez;
                dolniMez = horniMez;
                horniMez = temp;
            }

            Console.WriteLine($"Násobilka <{dolniMez};{horniMez}> {nasobek}");
            for (int i = dolniMez; i <= horniMez; i++) Console.WriteLine($"{i,3} x {nasobek} = {i * nasobek}");
        }

        private static void VypisN4()
        {
            //Interval 1
            int nasobekDolniMez = ZadejCislo("Zadej dolní mez pro násobek", -5, 5, -5);
            int nasobekHorniMez = ZadejCislo("Zadej horní mez pro násobek", -5, 5, -5);

            if (nasobekDolniMez > nasobekHorniMez)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{nasobekDolniMez} > {nasobekHorniMez} >> prohozeno");
                Console.ForegroundColor = ConsoleColor.Gray;

                int temp = nasobekDolniMez;
                nasobekDolniMez = nasobekHorniMez;
                nasobekHorniMez = temp;
            }

            //Interval 2
            int dolniMez = ZadejCislo("Zadej dolní mez", -100, 100, -10);
            int horniMez = ZadejCislo("Zadej horní mez", -100, 100, 10);

            if (dolniMez > horniMez)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{dolniMez} > {horniMez} >> prohozeno");
                Console.ForegroundColor = ConsoleColor.Gray;

                int temp = dolniMez;
                dolniMez = horniMez;
                horniMez = temp;
            }

            //Výpis
            Console.WriteLine($"Násobilka <{dolniMez};{horniMez}> x <{nasobekDolniMez};{nasobekHorniMez}>");
            for (int i = dolniMez; i <= horniMez; i++)
            {
                for (int j = nasobekDolniMez; j <= nasobekHorniMez; j++) Console.Write($"{i,5} x {j} = {i*j,-5}");
                Console.WriteLine();
            }
        }

        private static int ZadejCislo(string veta, int a, int b, int priChybe)
        {
            Console.Write($"{veta} <{a};{b}>: ");
            string vstupString = Console.ReadLine();
            try
            {
                int vstup = Convert.ToInt32(vstupString);

                if (vstup < a || vstup > b)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{vstupString} Není číslo z <{a};{b}>! >> bude použito {priChybe}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return priChybe;
                }

                return vstup;
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{vstupString} Není číslo >> bude použito {priChybe}");
                Console.ForegroundColor = ConsoleColor.Gray;
                return priChybe;
            }
        }
    }
}