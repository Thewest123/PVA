using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _180316c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "";
            do
            {
                Console.Write($@"Menu 	
ch ~ char přehled	
chz ~ char zadej
chp ~ char přehled
chn ~ char náhodně (počet) <1;382>
key ~ načítání klávesy
k ~ konec	
Co si přeješ: ");
                string rl = Console.ReadLine();
                if (rl == "k") break;
                else if (rl == "ch") Znaky();
                else if (rl == "chz") ZadejZnak();
                else if (rl == "chp") CharPrehled(); //DÚ
                else if (rl == "chn") CharNahodne(); //DÚ
                else if (rl == "key") NacitaniKlavesy(); //DÚ
                else Console.Write($@"To neumím");
                System.Threading.Thread.Sleep(1000);
            } while (true);
        }

        private static void CharPrehled()
        {
            int zacatek = ZadejČíslo(char.MinValue, char.MaxValue);
            int konec = ZadejČíslo(char.MinValue, char.MaxValue);

            for (int i = zacatek; i <= konec; i++)
            {
                Console.WriteLine($"{i,10} ~ {(char)i} ~ {i,-10:x}");
            }

            Console.WriteLine("Odenteruj!");
            Console.ReadLine();
        }

        private static void CharNahodne()
        {
            int pocet = ZadejČíslo(10,20);
            var r = new Random();

            for (int i = 0; i <= pocet; i++)
            {
                int rn = r.Next(1, 382 + 1);
                Console.Write($"{i+")",5} ");
                Console.Write($"{rn,5} ~ ");
                Console.Write($"{(char)rn} ~ ");
                Console.Write($"{rn,-5:x}\n");
            }

            Console.WriteLine("Odenteruj!");
            Console.ReadLine();
        }

        private static void NacitaniKlavesy()
        {
            Console.WriteLine("Pokud zadáte \'h\' >> nápověda pro vytváření podmínek:");
            Console.Write("Zadejte znak: ");

            ConsoleKeyInfo cki = Console.ReadKey();

            if (cki.KeyChar == 'h') Console.WriteLine("\nNápověda není! :P");

            Console.WriteLine($"\n------------------------------");
            Console.WriteLine($"System.ConsoleKeyInfo cki = Console.ReadKey()");
            Console.WriteLine($"System.ConsoleKey x = cki.Key: {cki.Key}");
            Console.WriteLine($"System.Char x = cki.KeyChar: {cki.KeyChar}");
            Console.WriteLine($"System.ConsoleModifiers x = cki.Modifiers: {cki.Modifiers}");

            Console.WriteLine("Odenteruj!");
            Console.ReadLine();
        }

        private static void ZadejZnak()
        {
            Console.Write($@"Zadej znak: ");
string rl = Console.ReadLine();
            try
            {
                char z = Convert.ToChar(rl);
                Console.WriteLine($@"Zadaný znak: {z}
ASCII: {(int)z}
Hexadecimálně: {(int)z:x}

Odentruj!");
                Console.ReadLine();
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
        }

        private static void Znaky()
        {
            char z1 = 'a'; //znak ~ Char
            char z2 = (char)97; //celé číslo ~ Dec
            char z3 = '\x0061'; //hexadecimálně ~ Hx
            char z4 = '\x61'; //hexadecimálně ~ Hx
            Console.Write($@"Znaky char/Char
------------------------------------------
Char.MinValue: '{char.MinValue}' >> null (není to mezera >> ta je 32)
Char.MaxValue: '{char.MaxValue}'
(int)Char.MinValue: '{(int)char.MinValue}'
(int)Char.MaxValue: '{(int)char.MaxValue}'
------------------------------------------
char z1 = 'a'; //znak ~ Char
         z1: {z1}
    (int)z1: {(int)z1}

char z2 = (char)97; //celé číslo ~ Dec
         z2: {z2}
    (int)z2: {(int)z2}

char z3 = '\x0061'; //hexadecimálně ~ Hx
         z3: {z3}
    (int)z3: {(int)z3}

char z4 = '\x61'; //hexadecimálně ~ Hx
         z4: {z4}
    (int)z4: {(int)z4}

Odentruj!");
            Console.ReadLine();
        }
        private static int ZadejČíslo(int v1, int v2)
        {
            Console.Write($@"Zadej číslo <{v1};{v2}>: ");
            string rl = Console.ReadLine();
            try
            {
                //
                // Int16 není schopen pobrat char.MaxValue(); //
                //
                int ret = Convert.ToInt16(rl);
                if (ret < v1 || ret > v2)
                {
                    Console.WriteLine($@"{rl} není číslo <{v1};{v2}>, Bude zadána hodnota {v1}");
                    return v1;
                }
                else return ret;
            }
            catch (Exception er)
            {
                Console.WriteLine($@"{rl} není číslo, Bude zadána hodnota {v1}
{er.Message}");
                return v1;
            }
        }
    }
}
