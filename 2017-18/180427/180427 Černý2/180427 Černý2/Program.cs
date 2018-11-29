using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180427_Černý2
{
    class Program
    {
        //pole platné v metodě Main
        static byte[] _p1 = new byte[10];
        static byte[] _p2 = new byte[10];
        static byte _počet = 10;
        static Random _nc = new Random();
        static void Main(string[] args)
        {

            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.Write($@"Menu 
------------------------------------------------------	
Z ~ Změna velikosti polí {_počet} <2;20>
N ~ Naplň první pole Byte náhodně
Shift + N ~ Naplň první pole Byte sám
Alt + N ~ Naplň druhé pole Byte náhodně
Alt + Shift + N ~ Naplň druhé pole Byte sám

V ~ Vypiš první pole
Alt + V ~ Vypiš druhé pole
S ~ Vypiš součet polí
R ~ Vypiš rozdíl polí
Shift + S ~ Vypiš součet polí obráceně
Shift + R ~ Vypiš rozdíl polí obráceně
K ~ Konec programu
------------------------------------------------------	 
Co si přeješ: ");
                ConsoleKeyInfo cki = Console.ReadKey();
                Console.WriteLine("");
                if (cki.Key == ConsoleKey.K && cki.Modifiers == 0) break;
                else if (cki.Key == ConsoleKey.Z && cki.Modifiers == 0) _počet = ZadejHodnotu(2, 20);//Z ~ Změna velikosti polí {počet} <2;20>

                else if (cki.Key == ConsoleKey.N && cki.Modifiers == 0) Generuj(_p1);//N ~ Naplň první pole Byte náhodně
                else if (cki.Key == ConsoleKey.N && cki.Modifiers == ConsoleModifiers.Shift) Naplň(_p1); //Shift + N ~ Naplň první pole Byte sám
                else if (cki.Key == ConsoleKey.N && cki.Modifiers == ConsoleModifiers.Alt) Generuj(_p2); //Alt + N ~Naplň druhé pole Byte náhodně
                else if (cki.Key == ConsoleKey.N && cki.Modifiers == (ConsoleModifiers.Shift | ConsoleModifiers.Alt)) Naplň(_p2); //Alt + Shift + N ~Naplň druhé pole Byte sám

                else if (cki.Key == ConsoleKey.V && cki.Modifiers == 0) Vypiš(_p1);//V ~Vypiš první pole
                else if (cki.Key == ConsoleKey.V && cki.Modifiers == ConsoleModifiers.Alt) Vypiš(_p2); //Alt + V ~Vypiš druhé pole
                else if (cki.Key == ConsoleKey.S && cki.Modifiers == 0) VypišS();//S ~Vypiš součet polí
                else if (cki.Key == ConsoleKey.R && cki.Modifiers == 0) VypišR();//R ~Vypiš rozdíl polí
                else if (cki.Key == ConsoleKey.S && cki.Modifiers == ConsoleModifiers.Shift) VypišS(true); //Shift + S ~Vypiš součet polí obráceně
                else if (cki.Key == ConsoleKey.R && cki.Modifiers == ConsoleModifiers.Shift) VypišR(true); //Shift + R ~Vypiš rozdíl polí obráceně

                else Console.WriteLine($@"{cki.Modifiers} + {cki.Key} >> to neumím!");
                Console.WriteLine($@"Odentruj!");
                Console.ReadLine();
            } while (true);
        }

        private static byte ZadejHodnotu(int dolniHranice, int horniHranice)
        {
            while (true)
            {
                Console.Write($"Zadej číslo byte <{dolniHranice};{horniHranice}>: ");
                bool parsovani = byte.TryParse(Console.ReadLine(), out byte velikostPole);

                if (parsovani && velikostPole >= 2 && velikostPole <= 20)
                {
                    _p1 = new byte[velikostPole];
                    _p2 = new byte[velikostPole];
                    return velikostPole;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Špatně zadáno, zadej znovu!");
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        private static byte ZadejByte(int i)
        {
            while (true)
            {
                Console.Write($"Zadej hodnotu byte <0;255> pro pole[{i}]: ");

                bool parsovani = byte.TryParse(Console.ReadLine(), out byte vstup);
                if (parsovani) return vstup;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Špatně zadáno, zadej znovu!");
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        private static void Generuj(byte[] pole)
        {
            for (int i = 0; i < _počet; i++) pole[i] = (byte)_nc.Next(byte.MinValue, byte.MaxValue + 1);
        }

        private static void Naplň(byte[] pole)
        {
            for (int i = 0; i < _počet; i++) pole[i] = ZadejByte(i);
        }

        private static void Vypiš(byte[] pole)
        {
            for (int i = 0; i < _počet; i++) Console.WriteLine($"pole[{i,2}] <> {pole[i]}");
        }

        private static void VypišS(bool b = false)
        {
            for (int i = 0; i < _počet; i++)
            {
                if (b) Console.WriteLine($"p1[{i,2}] + p2[{_počet - i - 1,2}] <> {_p1[i],3} + {_p2[_počet - i - 1],-3} = {_p1[i] + _p2[_počet - i - 1]}");
                else Console.WriteLine($"p1[{i,2}] + p2[{i,2}] <> {_p1[i],3} + {_p2[i],-3} = {_p1[i] + _p2[i]}");
            }
        }

        private static void VypišR(bool b = false)
        {
            for (int i = 0; i < _počet; i++)
            {
                if (b) Console.WriteLine($"p1[{i,2}] - p2[{_počet - i - 1,2}] <> {_p1[i],3} - {_p2[_počet - i - 1],-3} = {_p1[i] - _p2[_počet - i - 1]}");
                else Console.WriteLine($"p1[{i,2}] - p2[{i,2}] <> {_p1[i],3} - {_p2[i],-3} = {_p1[i] - _p2[i]}");
            }
        }
    }
}