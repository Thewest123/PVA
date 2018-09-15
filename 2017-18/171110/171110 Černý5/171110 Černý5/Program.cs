using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171110_Černý5
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
                int prvni;
                int druhe;
                zacatek_prvni:
                try
                {
                    Console.Write("Zadej první číslo: ");
                    prvni = Convert.ToInt32(Console.ReadLine());
                } catch (SystemException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Musíte zadat číslo!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    goto zacatek_prvni;
                }

                zacatek_druhe:
                try
                {
                    Console.Write("Zadej druhé číslo: ");
                    druhe = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Výpočty:\n           ------------------------------------------\n");
                }
                catch (SystemException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Musíte zadat číslo!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    goto zacatek_druhe;
                }

                int plus = prvni + druhe;
                int minus = prvni - druhe;
                int krat = prvni * druhe;

                //Bylo potřeba trošku pogooglit, než jsem zjistil že dělení dvou intů dá jako výsledek taky int.
                    decimal d_prvni = Convert.ToDecimal(prvni);
                    decimal d_druhe = Convert.ToDecimal(druhe);

                decimal deleno = d_prvni / d_druhe;
                int vejdeSeKolikrat = prvni % druhe;


                Console.WriteLine($"{prvni} + {druhe} = {plus}");
                Console.WriteLine($"{prvni} - {druhe} = {minus}");
                Console.WriteLine($"{prvni} * {druhe} = {krat}");
                Console.WriteLine($"{prvni} / {druhe} = {deleno}");
                Console.WriteLine($"{prvni} % {druhe} = {vejdeSeKolikrat}");

                Console.WriteLine("\nOdenteruj!");
                Console.ReadLine();
                Console.WriteLine("----------------------");
            }

        }
    }
}
