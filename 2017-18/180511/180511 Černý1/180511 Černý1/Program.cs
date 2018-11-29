using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180511_Černý1
{
    class Program
    {
        private static string[]  _poleStrings  = new string[10];
        private static byte[]    _poleBytes    = new byte[10];
        private static sbyte[]   _poleSbytes   = new sbyte[10];
        private static short[]   _poleShorts   = new short[10];
        private static ushort[]  _poleUshorts  = new ushort[10];
        private static int[]     _poleInts     = new int[10];
        private static uint[]    _poleUints    = new uint[10];
        private static long[]    _poleLongs    = new long[10];
        private static ulong[]   _poleUlongs   = new ulong[10];
        private static float[]   _poleFloats   = new float[10];
        private static double[]  _poleDoubles  = new double[10];
        private static decimal[] _poleDecimals = new decimal[10];
        private static char[]    _poleChars    = new char[10];

        private static int _index;

        static void Main(string[] args)
        {
            Console.WindowWidth = Console.LargestWindowWidth;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("p ~ přidej číslo");
                Console.WriteLine("v ~ vypiš čísla");
                Console.WriteLine("c ~ vymaž čísla");
                Console.WriteLine("k ~ konec");
                Console.Write("Co si přeješ: ");

                var cki = Console.ReadKey();

                Console.WriteLine();

                if (cki.Key == ConsoleKey.P) PridejCislo();
                else if (cki.Key == ConsoleKey.V) VypisCisla();
                else if (cki.Key == ConsoleKey.C) VymazCisla();
                else if (cki.Key == ConsoleKey.K) break;
                else Console.WriteLine("To neumím!");

                Console.WriteLine("Odenteruj!");
                Console.ReadLine();
            }
        }

        private static void PridejCislo()
        {
            if (_index < 10)
            {
                Console.Write("Zadej číslo: ");
                string vstup = Console.ReadLine();

                _poleStrings[_index] = vstup;

                if (!byte.TryParse(vstup, out _poleBytes[_index])) Console.WriteLine($"{vstup} není číslo byte!");
                if (!sbyte.TryParse(vstup, out _poleSbytes[_index])) Console.WriteLine($"{vstup} není číslo sbyte!");
                if (!short.TryParse(vstup, out _poleShorts[_index])) Console.WriteLine($"{vstup} není číslo short!");
                if (!ushort.TryParse(vstup, out _poleUshorts[_index])) Console.WriteLine($"{vstup} není číslo ushort!");
                if (!int.TryParse(vstup, out _poleInts[_index])) Console.WriteLine($"{vstup} není číslo int!");
                if (!uint.TryParse(vstup, out _poleUints[_index])) Console.WriteLine($"{vstup} není číslo uint!");
                if (!long.TryParse(vstup, out _poleLongs[_index])) Console.WriteLine($"{vstup} není číslo long!");
                if (!ulong.TryParse(vstup, out _poleUlongs[_index])) Console.WriteLine($"{vstup} není číslo ulong!");
                if (!float.TryParse(vstup, out _poleFloats[_index])) Console.WriteLine($"{vstup} není číslo float!");
                if (!double.TryParse(vstup, out _poleDoubles[_index])) Console.WriteLine($"{vstup} není číslo double!");
                if (!decimal.TryParse(vstup, out _poleDecimals[_index])) Console.WriteLine($"{vstup} není číslo decimal!");
                try
                {
                    _poleChars[_index] = (char) _poleLongs[_index];
                }
                catch
                {
                    Console.WriteLine($"{vstup} není číslo char!");
                }

                _index++;
            }
            else
            {
                Console.WriteLine("Pole už jsou plná!");
            }
        }

        private static void VypisCisla()
        {
            Console.WriteLine($"┌─────────────────┬─────────────┬─────────────┬─────────────┬─────────────┬─────────────┬─────────────┬─────────────┬─────────────┬─────────────┬─────────────┐");
            Console.WriteLine($"│                 │      0      │      1      │      2      │      3      │      4      │      5      │      6      │      7      │      8      │      9      │");
            Console.WriteLine($"├─────────────────┼─────────────┼─────────────┼─────────────┼─────────────┼─────────────┼─────────────┼─────────────┼─────────────┼─────────────┼─────────────┤");
            NapisRadek("String string", _poleStrings);
            NapisRadek("Byte byte", _poleBytes);
            NapisRadek("Sbyte sbyte", _poleSbytes);
            NapisRadek("Int16 short", _poleUshorts);
            NapisRadek("UInt16 ushort", _poleUshorts);
            NapisRadek("Int32 int", _poleInts);
            NapisRadek("UInt32 uint", _poleUints);
            NapisRadek("Int64 long", _poleLongs);
            NapisRadek("UInt64 ulong", _poleUlongs);
            NapisRadek("Single float", _poleFloats);
            NapisRadek("Double double", _poleDoubles);
            NapisRadek("Decimal decimal", _poleDecimals);
            NapisRadek("Char char", _poleChars);
            Console.WriteLine($"└─────────────────┴─────────────┴─────────────┴─────────────┴─────────────┴─────────────┴─────────────┴─────────────┴─────────────┴─────────────┴─────────────┘");
            Console.WriteLine();
        }

        private static void VymazCisla()
        {
            Array.Clear(_poleStrings, 0, 10);
            Array.Clear(_poleBytes, 0, 10);
            Array.Clear(_poleSbytes, 0, 10);
            Array.Clear(_poleShorts, 0, 10);
            Array.Clear(_poleUshorts, 0, 10);
            Array.Clear(_poleInts, 0, 10);
            Array.Clear(_poleUints, 0, 10);
            Array.Clear(_poleLongs, 0, 10);
            Array.Clear(_poleUlongs, 0, 10);
            Array.Clear(_poleFloats, 0, 10);
            Array.Clear(_poleDoubles, 0, 10);
            Array.Clear(_poleDecimals, 0, 10);
            Array.Clear(_poleChars, 0, 10);
            Console.WriteLine("Pole smazána!");
            _index = 0;
        }

        private static void NapisRadek(string jmenoRadku, Array poleKVypsani)
        {
            Console.Write($"│ {jmenoRadku,-16}");
            for (int i = 0; i < poleKVypsani.Length; i++)
            {
                Console.Write($"│{poleKVypsani.GetValue(i),13}");
            }
            Console.WriteLine("│");
        }
    }
}
