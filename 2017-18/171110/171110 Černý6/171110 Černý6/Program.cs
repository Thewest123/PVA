using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171110_Černý6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorSize = 100;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            while (true)
            {
                Console.CursorVisible = true;
                int vstup;
                zacatek:
                try
                {
                    Console.Write("Zadej číslo: ");
                    vstup = Convert.ToInt32(Console.ReadLine());
                } catch (SystemException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Musíte zadat číslo!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    goto zacatek;
                }
                Console.WriteLine("Převod na znak\n------------------------------------------------");

                Console.WriteLine($"Převáděné číslo: {vstup}");
                char znak = (char)vstup;
                Console.WriteLine($"Odpovídající CHAR znak: {znak}\n");
                Console.CursorVisible = false;
                Console.Write("Odenteruj!");
                Console.ReadLine();
                Console.WriteLine("---------------------");
            }

        }
    }
}
