using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;

namespace _171215_Černý2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;            
            Console.Clear();
            Console.Title = "Dú";
            Console.CursorSize = 100;
            int celeCislo = 0;
            int maximalniMocnina;

            //Loop pro celý program
            while (true)
            {
                //Zadání celého čísla
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("===============================================");
                    Console.WriteLine("k >> konec:");
                    Console.WriteLine("Zadej celé číslo <-10;10>-{0;1}");
                    Console.WriteLine("(Z intervalu -deset až deset bez jedničky a nuly)");
                    Console.Write("Zadej: ");
                    string vstup = Console.ReadLine();

                    if (vstup.ToLower() == "k") {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ahoj!");
                        Sleep(1000);
                        //Vygoogleno:
                        Environment.Exit(0);
                    }

                    try
                    {
                        celeCislo = Convert.ToInt32(vstup);
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(e.Message);
                        continue;
                    }

                    if ((celeCislo >= -10) && (celeCislo <= 10) && (celeCislo != 1) && (celeCislo != 0))
                    {
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{celeCislo} není z intervalu <-10;10>-{{0;1}}");
                        continue;
                    }
                }

                //Zadání maximální mocniny
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen; //DarkGreen mi na bílém pozadí přijde čitelnější, než Green
                    Console.WriteLine("Zadej maximální mocninu");
                    Console.WriteLine("Zadej celé číslo <2;20>");
                    Console.Write("Zadej: ");

                    try
                    {
                        maximalniMocnina = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(e.Message);
                        continue;
                    }

                    if ((maximalniMocnina >= 2) && (maximalniMocnina <= 20))
                    {
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{maximalniMocnina} není z intervalu <2;20>");
                        continue;
                    }
                }

                //Výsledky mocnin
                #region
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"Mocnina {celeCislo} do {maximalniMocnina}");
                Console.WriteLine("------------------------------------------------");
                Console.CursorVisible = false;
                for (int i = 2; i <= maximalniMocnina; i++)
                {
                    double vysledekMocniny = Math.Pow(celeCislo, i);
                    Console.WriteLine($"{celeCislo} na {i} = {vysledekMocniny:n0}");
                    //Minuta je moc dlouhá :P
                    Sleep(250);
                }
                Console.CursorVisible = true;
                #endregion
            }
        }
    }
}