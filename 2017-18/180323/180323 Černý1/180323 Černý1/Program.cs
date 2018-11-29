using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _180323_Černý1
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = @"Menu
i ~ Výpis celočíselných proměnných Min
I ~ Výpis celočíselných proměnných Max
Shift + I ~ Výpis celočíselných proměnných Min + Max
d ~ Výpis desetinných proměnných Min
D ~ Výpis desetinných proměnných Max
Shift + D ~ Výpis desetinných proměnných Min + Max
Alt + K ~ konec
Co si přeješ: ";

            Console.Title = "Výpisy Min/Max";
            Console.SetWindowSize(150,30);
            do
            {
                Console.Write(menu);

                ConsoleKeyInfo cki = Console.ReadKey();
                Console.WriteLine();

                if (cki.Modifiers == 0 && cki.KeyChar == 'i') Console.WriteLine(VypisMin());
                else if (cki.Modifiers == 0 && cki.KeyChar == 'I') Console.WriteLine(VypisMax());
                else if (cki.Modifiers == ConsoleModifiers.Shift && cki.Key == ConsoleKey.I) Console.WriteLine(VypisMinMax());
                else if (cki.Modifiers == 0 && cki.KeyChar == 'd') Console.WriteLine(VypisDesetinneMin());
                else if (cki.Modifiers == 0 && cki.KeyChar == 'D') Console.WriteLine(VypisDesetinneMax());
                else if (cki.Modifiers == ConsoleModifiers.Shift && cki.Key == ConsoleKey.D) Console.WriteLine(VypisDesetinneMinMax());
                else if (cki.Modifiers == ConsoleModifiers.Alt && cki.Key == ConsoleKey.K) break;
                else Console.WriteLine($"Neplatný vstup!");

                Console.WriteLine($@"Odentruj!");
                Console.ReadLine();
            } while (true);
        }

        private static string VypisMin()
        {
            string ret;

            ret  = $"\n┌───────┬───────┬───────────────────────────────┐";
            ret += $"\n│ {"TYP",5} │ {"NICK",5} │ {"MinValue",29} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┤";
            ret += $"\n│ {"Byte",5} │ {"byte",5} │ {byte.MinValue,29:N0} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┤";
            ret += $"\n│ {"SByte",5} │ {"sbyte",5} │ {sbyte.MinValue,29:N0} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┤";
            ret += $"\n│ {"Int16",5} │ {"short",5} │ {short.MinValue,29:N0} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┤";
            ret += $"\n│ {"Int32",5} │ {"int",5} │ {int.MinValue,29:N0} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┤";
            ret += $"\n│ {"Int64",5} │ {"long",5} │ {long.MinValue,29:N0} │";
            ret += $"\n└───────┴───────┴───────────────────────────────┘";

            return ret;
        }

        private static string VypisMax()
        {
            string ret;

            ret  = $"\n┌───────┬───────┬───────────────────────────────┐";
            ret += $"\n│ {"TYP",5} │ {"NICK",5} │ {"MaxValue",29} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┤";
            ret += $"\n│ {"Byte",5} │ {"byte",5} │ {byte.MaxValue,29:N0} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┤";
            ret += $"\n│ {"SByte",5} │ {"sbyte",5} │ {sbyte.MaxValue,29:N0} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┤";
            ret += $"\n│ {"Int16",5} │ {"short",5} │ {short.MaxValue,29:N0} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┤";
            ret += $"\n│ {"Int32",5} │ {"int",5} │ {int.MaxValue,29:N0} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┤";
            ret += $"\n│ {"Int64",5} │ {"long",5} │ {long.MaxValue,29:N0} │";
            ret += $"\n└───────┴───────┴───────────────────────────────┘";

            return ret;
        }

        private static string VypisMinMax()
        {
            string ret;

            ret  = $"\n┌───────┬───────┬───────────────────────────────┬───────────────────────────────┐";
            ret += $"\n│ {"TYP",5} │ {"NICK",5} │ {"MinValue",29} │ {"MaxValue",29} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┼───────────────────────────────┤";
            ret += $"\n│ {"Byte",5} │ {"byte",5} │ {byte.MinValue,29:N0} │ {byte.MaxValue,29:N0} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┼───────────────────────────────┤";
            ret += $"\n│ {"SByte",5} │ {"sbyte",5} │ {sbyte.MinValue,29:N0} │ {sbyte.MaxValue,29:N0} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┼───────────────────────────────┤";
            ret += $"\n│ {"Int16",5} │ {"short",5} │ {short.MinValue,29:N0} │ {short.MaxValue,29:N0} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┼───────────────────────────────┤";
            ret += $"\n│ {"Int32",5} │ {"int",5} │ {int.MinValue,29:N0} │ {int.MaxValue,29:N0} │";
            ret += $"\n├───────┼───────┼───────────────────────────────┼───────────────────────────────┤";
            ret += $"\n│ {"Int64",5} │ {"long",5} │ {long.MinValue,29:N0} │ {long.MaxValue,29:N0} │";
            ret += $"\n└───────┴───────┴───────────────────────────────┴───────────────────────────────┘";

            return ret;
        }

        private static string VypisDesetinneMin()
        {
            string ret;

            ret  = $"\n┌─────────┬─────────┬───────────────────────────────────────────────────────────┐";
            ret += $"\n│ {"TYP",7} │ {"NICK",7} │ {"MinValue",57} │";
            ret += $"\n├─────────┼─────────┼───────────────────────────────────────────────────────────┤";
            ret += $"\n│ {"Single",7} │ {"float",7} │ {float.MinValue,57:N2} │";
            ret += $"\n├─────────┼─────────┼───────────────────────────────────────────────────────────┤";
            ret += $"\n│ {"Double",7} │ {"double",7} │ {double.MinValue,57:e16} │";
            ret += $"\n├─────────┼─────────┼───────────────────────────────────────────────────────────┤";
            ret += $"\n│ {"Decimal",7} │ {"decimal",7} │ {decimal.MinValue,57:N2} │";
            ret += $"\n└─────────┴─────────┴───────────────────────────────────────────────────────────┘";

            return ret;
        }

        private static string VypisDesetinneMax()
        {
            string ret;

            ret  = $"\n┌─────────┬─────────┬───────────────────────────────────────────────────────────┐";
            ret += $"\n│ {"TYP",7} │ {"NICK",7} │ {"MaxValue",57} │";
            ret += $"\n├─────────┼─────────┼───────────────────────────────────────────────────────────┤";
            ret += $"\n│ {"Single",7} │ {"float",7} │ {float.MaxValue,57:N2} │";
            ret += $"\n├─────────┼─────────┼───────────────────────────────────────────────────────────┤";
            ret += $"\n│ {"Double",7} │ {"double",7} │ {double.MaxValue,57:e16} │";
            ret += $"\n├─────────┼─────────┼───────────────────────────────────────────────────────────┤";
            ret += $"\n│ {"Decimal",7} │ {"decimal",7} │ {decimal.MaxValue,57:N2} │";
            ret += $"\n└─────────┴─────────┴───────────────────────────────────────────────────────────┘";

            return ret;
        }

        private static string VypisDesetinneMinMax()
        {
            string ret;

            ret  = $"\n┌─────────┬─────────┬───────────────────────────────────────────────────────────┬───────────────────────────────────────────────────────────┐";
            ret += $"\n│ {"TYP",7} │ {"NICK",7} │ {"MinValue",57} │ {"MaxValue",57} │";
            ret += $"\n├─────────┼─────────┼───────────────────────────────────────────────────────────┼───────────────────────────────────────────────────────────┤";
            ret += $"\n│ {"Single",7} │ {"float",7} │ {float.MinValue,57:N2} │ {float.MaxValue,57:N2} │";
            ret += $"\n├─────────┼─────────┼───────────────────────────────────────────────────────────┼───────────────────────────────────────────────────────────┤";
            ret += $"\n│ {"Double",7} │ {"double",7} │ {double.MinValue,57:e16} │ {double.MaxValue,57:e16} │";
            ret += $"\n├─────────┼─────────┼───────────────────────────────────────────────────────────┼───────────────────────────────────────────────────────────┤";
            ret += $"\n│ {"Decimal",7} │ {"decimal",7} │ {decimal.MinValue,57:N2} │ {decimal.MaxValue,57:N2} │";
            ret += $"\n└─────────┴─────────┴───────────────────────────────────────────────────────────┴───────────────────────────────────────────────────────────┘";

            return ret;
        }
    }
}
