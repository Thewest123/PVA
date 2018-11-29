using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171110_Černý2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.CursorSize = 100;
            Console.Clear();

            int pocatek;
            startPocatek:
            Console.Write("Zadej počáteční hodnotu: ");
            try
            {
                pocatek = Convert.ToInt32(Console.ReadLine());
                Console.Write($"(Počáteční hodnota: {pocatek})\n----------------------------------------\n");
            } catch (SystemException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Musíte zadat číslo!\n");
                Console.ForegroundColor = ConsoleColor.Black;
                goto startPocatek;
            }

            int operace;
            startOperace:
            Console.Write("Zadej hodnotu pro operaci: ");
            try
            {
                operace = Convert.ToInt32(Console.ReadLine());
                Console.Write($"(Operační hodnota: {operace})\n----------------------------------------\n");
            }
            catch (SystemException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Musíte zadat číslo!\n");
                Console.ForegroundColor = ConsoleColor.Black;
                goto startOperace;
            }

            int a = pocatek;
            int b = pocatek;
            int c = pocatek;
            decimal d = pocatek;

            Console.CursorVisible = false;

            while (true)
            {

                Console.WriteLine($"Přičítání po 1: {a}");
                Console.WriteLine($"Odčítání po {operace}:  {b}");
                Console.WriteLine($"Násobení po {operace}:  {c}");
                Console.WriteLine($"Dělení po {operace}:    {d}");

                a++;
                b -= operace;
                c *= operace;
                d /= operace;

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Odenteruj!");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.ReadLine();
                Console.WriteLine("------------------------");
            }
        }
    }
}
