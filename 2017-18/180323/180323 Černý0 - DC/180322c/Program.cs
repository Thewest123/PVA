using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180322c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "";
            do
            {
                Console.Write($@"Menu 	
znak t ~ Výpis řetězce po znacích cyklus For	(Length, Substring(č,č))
Alt + T ~ HELP Výpis řetězce po znacích cyklus For
znak T ~ Výpis řetězce po znacích cyklus Foreach	
Ctrl + Alt + T ~ HELP Výpis řetězce po znacích cyklus Foreach	
klávesa R ~ Rozbor znaků	
Alt + K ~ konec	
Co si přeješ: ");

                ConsoleKeyInfo cki = Console.ReadKey();
                Console.WriteLine();

                if (cki.Modifiers == 0 && cki.KeyChar == 't') Console.WriteLine(VypišStringFor());
                else if (cki.Modifiers == ConsoleModifiers.Alt && cki.Key == ConsoleKey.T) Console.WriteLine(VypišStringForHelp());
                else if (cki.Modifiers == 0 && cki.KeyChar == 'T') Console.WriteLine(VypišStringForeach());
                else if (cki.Modifiers == (ConsoleModifiers.Alt | ConsoleModifiers.Control) && cki.Key == ConsoleKey.T) Console.WriteLine(VypišStringForeachHelp());
                else if (cki.Modifiers == 0 && cki.Key == ConsoleKey.R) Console.WriteLine(RozborZnaků());
                else if (cki.Modifiers == ConsoleModifiers.Alt && cki.Key == ConsoleKey.K) break;
                else Console.WriteLine($"Neplatný vstup!");

                Console.WriteLine($@"Odentruj!");
                Console.ReadLine();
            } while (true);
        }

        private static string VypišStringFor()
        {
            string ret = @"------------------------------------
Výpis řetězce po znacích cyklus For
------------------------------------";
            Console.Write("Zadej text: ");
            string rl = Console.ReadLine();

            for (int i = 0; i < rl.Length; i++)
            {
                char znak = Convert.ToChar(rl.Substring(i, 1));
                ret+=$"\n{i+1} ~ {znak} ({(int)znak})";
            }

            return ret;
        }
        private static string VypišStringForHelp()
        {
            string ret = @"         private static string VypišStringFor()
        {
            string ret = @""------------------------------------
Výpis řetězce po znacích cyklus For
------------------------------------"";
            Console.Write(""Zadej text: "");
            string rl = Console.ReadLine();

            for (int i = 0; i < rl.Length; i++)
            {
                char znak = Convert.ToChar(rl.Substring(i, 1));
                ret+=$""\n{i+1} ~ {znak} ({(int)znak})"";
            }

            return ret;
        }";
            return ret;
        }
        private static string VypišStringForeach()
        {
            string ret = @"---------------------------------------
Výpis řetězce po znacích cyklus Foreach
---------------------------------------";
            Console.Write("Zadej text: ");
            string rl = Console.ReadLine();
            int i = 1;

            foreach (char znak in rl)
            {
                ret +=$"\n{i++} ~ {znak} ({(int)znak})";
            }

            return ret;
        }
        private static string VypišStringForeachHelp()
        {
            string ret = @"private static string VypišStringForeach()
        {
            string ret = @""---------------------------------------
Výpis řetězce po znacích cyklus Foreach
---------------------------------------"";
            Console.Write(""Zadej text: "");
            string rl = Console.ReadLine();
            int i = 1;

            foreach (char znak in rl)
            {
                ret+=$""\n{i++} ~ {znak} ({(int)znak})"";
            }

            return ret;
        }";
            return ret;
        }
        private static string RozborZnaků()
        {
            Console.Write("Zadej text: ");
            string rl = Console.ReadLine();

            string ret = $@"------------------------------------
Rozbor znaků
------------------------------------
Délka řetězce: {rl.Length}
------------------------------------";

            int samohláskaKM = 0;
            int samohláskaKV = 0;
            int samohláskaDM = 0;
            int samohláskaDV = 0;
            int souhláskaTM = 0;
            int souhláskaTV = 0;
            int souhláskaMM = 0;
            int souhláskaMV = 0;
            int souhláskaOM = 0;
            int souhláskaOV = 0;
            int čísla = 0;
            int ostatní = 0;
            
            foreach (char znak in rl)
            {
                switch (znak)
                {
                    case 'a':
                    case 'e':
                    case 'ě':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':
                        samohláskaKM++;
                        break;

                    case 'A':
                    case 'E':
                    case 'Ě':
                    case 'I':
                    case 'O':
                    case 'U':
                    case 'Y':
                        samohláskaKV++;
                        break;

                    case 'á':
                    case 'é':
                    case 'í':
                    case 'ó':
                    case 'ú':
                    case 'ů':
                    case 'ý':
                        samohláskaDM++;
                        break;

                    case 'Á':
                    case 'É':
                    case 'Í':
                    case 'Ó':
                    case 'Ú':
                    case 'Ů':
                    case 'Ý':
                        samohláskaDV++;
                        break;

                    case 'h':
                    case 'k':
                    case 'r':
                    case 'd':
                    case 't':
                    case 'n':
                        souhláskaTM++;
                        break;

                    case 'H':
                    case 'K':
                    case 'R':
                    case 'D':
                    case 'T':
                    case 'N':
                        souhláskaTV++;
                        break;

                    case 'ž':
                    case 'š':
                    case 'c':
                    case 'č':
                    case 'ř':
                    case 'j':
                    case 'ď':
                    case 'ň':
                        souhláskaMM++;
                        break;

                    case 'Ž':
                    case 'Š':
                    case 'C':
                    case 'Č':
                    case 'Ř':
                    case 'J':
                    case 'Ď':
                    case 'Ň':
                        souhláskaMV++;
                        break;

                    case 'b':
                    case 'f':
                    case 'l':
                    case 'm':
                    case 'p':
                    case 's':
                    case 'v':
                    case 'z':
                        souhláskaOM++;
                        break;

                    case 'B':
                    case 'F':
                    case 'L':
                    case 'M':
                    case 'P':
                    case 'S':
                    case 'V':
                    case 'Z':
                        souhláskaOV++;
                        break;

                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        čísla++;
                        break;

                    default:
                        ostatní++;
                        break;
                }
            }

            ret += $@"
samohláska krátká malá: {samohláskaKM}
samohláska krátká velká: {samohláskaKV}
samohláska dlouhá malá: {samohláskaDM}
samohláska dlouhá velká: {samohláskaDV}
souhláska tvrdá malá: {souhláskaTM}
souhláska tvrdá velká: {souhláskaTV}
souhláska měkká malá: {souhláskaMM}
souhláska měkká velká: {souhláskaMV}
souhláska obojetná malá: {souhláskaOM}
souhláska obojetná velká: {souhláskaOV}
čísla: {čísla}
ostatní: {ostatní}
";
            return ret;
        }
    }
}
