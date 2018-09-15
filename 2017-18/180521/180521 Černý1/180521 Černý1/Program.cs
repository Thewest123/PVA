using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180521_Černý1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("K ~ Konec");
                Console.WriteLine("X ~ Opakuje cyklus");
                Console.WriteLine("T ~ Vytržení a doplnění textu, dle zadaných hodnot");
                Console.WriteLine("S ~ Rozložení textu");
                Console.WriteLine("H ~ Hrátky s textem");
                Console.WriteLine("h ~ Hrátky s textem neopakovaně");
                Console.Write("Co chceš: ");

                string vstup = Console.ReadLine();

                if (vstup == "K") break;
                else if (vstup == "X") continue;
                else if (vstup == "T") Text1();
                else if (vstup == "S") Text2();
                else if (vstup == "H") Text3();
                else if (vstup == "h") Text4();
                else Console.WriteLine($"{vstup} >> To neumím!");

                Console.WriteLine();
                Console.WriteLine("Odenteruj!");
                Console.ReadLine();
            }
        }



        static void Text1()
        {
            string text = VstupTextu();
            int start;
            int pocet;
            int delka;

            for (;;)
            {
                start = VstupCisla("start", 0, 8);
                if (start < text.Length) break;
                Console.WriteLine($"Start ({start}) je delší nebo stejný jak řetězec ({text})!");
            }

            for (;;)
            {
                pocet = VstupCisla("počet", 1, 8);
                if (start + pocet < text.Length) break;
                Console.WriteLine($"Ke startu {start} nelze přidat tolik znaků ({pocet}), přesahují nebo jsou stejné jak velikost textu!");
            }

            for (;;)
            {
                delka = VstupCisla("délku", 3, 22);
                if (delka >= start + pocet + 1 && delka <= start + pocet + 20) break;
                Console.WriteLine($"Délka ({delka}) je kratší než vytržený řetězec+1, nebo delší o více než 20 znaků");
            }

            char znak = VstupZnaku(text);

            string levyText = text.Substring(0, start);
            string vytrzenyText = text.Substring(start, pocet);
            string pravyText = text.Substring(start + pocet);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(levyText);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(vytrzenyText);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(pravyText);

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\"Vytržení\" textu:");
            Console.WriteLine($"Od pozice: {start}");
            Console.WriteLine($"Počet znaků: {pocet}");
            Console.WriteLine($" >>{vytrzenyText}<< ");

            Console.WriteLine("---------------------------");

            Console.WriteLine("\"Doplnění\" textu:");
            Console.WriteLine($"Zleva: >>\"{vytrzenyText.PadLeft(delka, znak)}\"<<");
            Console.WriteLine($"Zprava: >>\"{vytrzenyText.PadRight(delka, znak)}\"<<");
        }

        private static void Text2()
        {
            string text = VstupTextu();
            char znak = VstupZnakuObsazeny(text);

            string[] slova =  text.Split(znak);

            for (int i = 0; i < slova.Length; i++)
            {
                Console.WriteLine($"{i} <> {slova[i]}");
            }
        }

        private static void Text3()
        {
            string text = VstupTextu();
            char znak = VstupZnakuObsazeny(text);

            string[] slova = text.Split(znak);

            var rand = new Random();
            for (int i = 0; i < slova.Length; i++)
            {
                Console.Write(slova[rand.Next(0,slova.Length)]+" ");
            }
        }

        private static void Text4()
        {
            string text = VstupTextu();
            char znak = VstupZnakuObsazeny(text);
            
            string[] slova = text.Split(znak);
            int[] pouziteIndexy = new int[slova.Length];

            var random = new Random();

            int index;
            pouziteIndexy[0] = random.Next(0, pouziteIndexy.Length);
            for (int i = 1; i < pouziteIndexy.Length-1; i++)
            {
                for (;;)
                {
                    index = random.Next(0, pouziteIndexy.Length);
                    if (!pouziteIndexy.Contains(index)) break;
                }
                pouziteIndexy[i] = index;
            }

            for (int i = 0; i < slova.Length; i++)
            {
                Console.Write(slova[pouziteIndexy[i]] + " ");
            }
        }

        static string VstupTextu()
        {
            for (;;)
            {
                Console.Write("Zadej text: ");
                string vstup = Console.ReadLine();

                if (vstup == "") Console.WriteLine("Prázdný nejde!");
                else return vstup;
            }
        }

        static int VstupCisla(string tema, int dolniMez, int horniMez)
        {
            for (;;)
            {
                Console.Write($"Zadej číslo pro {tema} <{dolniMez};{horniMez}>: ");
                try
                {
                    int vstup = Convert.ToInt32(Console.ReadLine());
                    if (vstup <= horniMez && vstup >= dolniMez) return vstup;
                    else Console.WriteLine($"Číslo není z intervalu <{dolniMez};{horniMez}>!");
                }
                catch
                {
                    Console.WriteLine("Vstup není číslo!");
                }
            }
        }

        static char VstupZnaku(string text)
        {
            for (;;)
            {
                Console.Write("Zadej znak: ");
                try
                {
                    char vstup = Convert.ToChar(Console.ReadLine());
                    if (text.Contains(vstup)) Console.WriteLine("Znak nesmí být obsažen v textu!");
                    else if ((int) vstup < 10 || (int) vstup > 255) Console.WriteLine("Znak musí být z intervalu <10;255>");
                    else return vstup;
                }
                catch
                {
                    Console.WriteLine("Vstup není znak!");
                }
            }
        }

        static char VstupZnakuObsazeny(string text)
        {
            for (; ; )
            {
                Console.Write("Rozkládací znak: ");
                try
                {
                    char vstup = Convert.ToChar(Console.ReadLine());
                    if (!text.Contains(vstup)) Console.WriteLine("Znak musí být obsažen v textu!");
                    else if ((int)vstup < 10 || (int)vstup > 255) Console.WriteLine("Znak musí být z intervalu <10;255>");
                    else return vstup;
                }
                catch
                {
                    Console.WriteLine("Vstup není znak!");
                }
            }
        }
    }
}