using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171208_Černý_c1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Podmínky";

            while (true)
            {
                Console.Clear();
                //--------------------------------------------------------------
                Console.WriteLine("Menu1:");
                Console.WriteLine("k ~ konec");
                Console.Write("Co chceš? ");
                string rl = Console.ReadLine();
                if (rl == "k")
                {
                    goto konec;
                }
                Console.WriteLine($"Zdal jsi {rl}");
                Console.WriteLine("----------------------------------------\n");
                //--------------------------------------------------------------
                Console.WriteLine("Menu2: (.ToLower())");
                Console.WriteLine("k|K ~ konec");
                Console.Write("Co chceš? ");
                rl = Console.ReadLine();
                if (rl.ToLower() == "k")
                {
                    goto konec;
                }
                Console.WriteLine($"Zdal jsi {rl}");
                Console.WriteLine("----------------------------------------\n");
                //--------------------------------------------------------------
                Console.WriteLine("Menu3: (složená podmínka)");
                Console.WriteLine("k|K ~ konec");
                Console.Write("Co chceš? ");
                rl = Console.ReadLine();
                if (rl == "k" || rl == "K")
                {
                    goto konec;
                }
                Console.WriteLine($"Zdal jsi {rl}");
                Console.WriteLine("----------------------------------------\n");
                //--------------------------------------------------------------
                Console.WriteLine("Menu4: (.ToLower(), .ToUpper() a složená podmínka)");
                Console.WriteLine("k|K|e|E ~ konec");
                Console.Write("Co chceš? ");
                rl = Console.ReadLine();
                if (rl.ToLower() == "k" || rl.ToUpper() == "E")
                {
                    goto konec;
                }
                Console.WriteLine($"Zdal jsi {rl}");
                Console.WriteLine("----------------------------------------\n");
                //--------------------------------------------------------------
                Console.WriteLine("Menu5: (.ToLower() a negace)");
                Console.WriteLine("k|K ~ konec");
                Console.Write("Co chceš? ");
                rl = Console.ReadLine();
                if (rl.ToLower() != "k")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nezadal jsi k|K");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (rl.ToLower() == "k")
                {
                    goto konec;
                }
                Console.WriteLine($"Zdal jsi {rl}");
                Console.WriteLine("----------------------------------------\n");
                //--------------------------------------------------------------
                Console.WriteLine("Menu6: (strukturovaný if)");
                Console.WriteLine("k|K ~ konec");
                Console.WriteLine("aeiou ~ krátké malé samohláásky");
                Console.WriteLine("AEIOU ~ krátké velké samohláásky");
                Console.Write("Co chceš? ");
                rl = Console.ReadLine();
                string[] maleSamohlasky = { "a", "e", "i", "o", "u" };
                string[] velkeSamohlasky = { "A", "E", "I", "O", "U" };
                if (maleSamohlasky.Contains(rl))
                //Nebo bez pole:
                //if (rl=="a" || rl=="e" || rl=="i" ||rl=="o" ||rl=="u")
                {
                    Console.WriteLine($"Zadal jsi krátkou malou samohlásku: {rl}");
                }
                else if (velkeSamohlasky.Contains(rl))
                //Nebo bez pole:
                //else if(rl=="A" || rl=="E" || rl=="I" ||rl=="O" ||rl=="U")
                {
                    Console.WriteLine($"Zadal jsi krátkou velkou samohlásku: {rl}");
                }
                else if (rl.ToLower() == "k")
                {
                    goto konec;
                }
                else
                {
                    Console.WriteLine("Zadal jsi něco jiného");
                }
                Console.WriteLine("----------------------------------------\n");
                Console.Write("Odenteruj!");
                Console.ReadLine();
            }

            konec:
                Console.WriteLine("Ahoj!");
                System.Threading.Thread.Sleep(1000);
        }
    }
}
