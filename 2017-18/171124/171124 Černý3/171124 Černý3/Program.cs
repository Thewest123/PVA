using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171124_Černý3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Odchytávání chyb";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Třída Math");
                Console.Write("Zadejte číslo a: ");
                string stringA = Console.ReadLine();
                int intA;
                double doubleA;
                decimal decimalA;

                Console.Write("Zadejte číslo b: ");
                string stringB = Console.ReadLine();
                int intB;
                double doubleB;
                decimal decimalB;

                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine("Vlastnosti:");
                Console.WriteLine($"{$"Math.E",60} >> {Math.E}");
                Console.WriteLine($"{$"Math.PI",60} >> {Math.PI}");

                string vlevo, vpravo;

                try
                {
                    intA = Convert.ToInt32(stringA);
                    intB = Convert.ToInt32(stringB);
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine("Metody s Int");

                    vlevo = "Math.Abs(intA)";
                    vpravo = $"Math.Abs({intA})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Abs(intA)}");

                    vlevo = "Math.BigMul(intA,intB)";
                    vpravo = $"Math.BigMul({intA}, {intB})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.BigMul(intA, intB)}");

                    vlevo = "Math.Exp(intA)";
                    vpravo = $"Math.Exp({intA})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Exp(intA)}");

                    vlevo = "Math.Max(intA,intB)";
                    vpravo = $"Math.Max({intA}, {intB})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Max(intA, intB)}");

                    vlevo = "Math.Min(intA, intB)";
                    vpravo = $"Math.Min({intA}, {intB})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Min(intA, intB)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine($"Metody s Int\n{e.Message}");
                }

                try
                {
                    decimalA = Convert.ToDecimal(stringA);
                    decimalB = Convert.ToDecimal(stringB);
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine("Metody s Decimal");

                    vlevo = "Math.Abs(decimalA)";
                    vpravo = $"Math.Abs({decimalA})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Abs(decimalA)}");

                    vlevo = "Math.Ceiling(decimalA)";
                    vpravo = $"Math.Ceiling({decimalA})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Ceiling(decimalA)}");

                    vlevo = "Math.Floor(decimalA)";
                    vpravo = $"Math.Floor({decimalA})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Floor(decimalA)}");

                    vlevo = "Math.Truncate(decimalA)";
                    vpravo = $"Math.Truncate({decimalA})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Truncate(decimalA)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine($"Metody s Decimal\n{e.Message}");
                }

                try
                {
                    doubleA = Convert.ToDouble(stringA);
                    doubleB = Convert.ToDouble(stringB);
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine("Metody s Double");

                    vlevo = "Math.Abs(doubleA)";
                    vpravo = $"Math.Abs({doubleA})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Abs(doubleA)}");

                    vlevo = "Math.Acos(doubleA)";
                    vpravo = $"Math.Acos({doubleA})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Acos(doubleA)}");

                    vlevo = "Math.Asin(doubleA)";
                    vpravo = $"Math.Asin({doubleA})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Asin(doubleA)}");

                    vlevo = "{Math.Cos(doubleA)";
                    vpravo = $"Math.Cos({doubleA})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Cos(doubleA)}");

                    vlevo = "Math.Log(doubleA)";
                    vpravo = $"Math.Log({doubleA})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Log(doubleA)}");

                    vlevo = "Math.Log10(doubleA)";
                    vpravo = $"Math.Log10({doubleA})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Log10(doubleA)}");

                    vlevo = "Math.Pow(doubleA, doubleB)";
                    vpravo = $"Math.Pow({doubleA}, {doubleB})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Pow(doubleA, doubleB)}");

                    vlevo = "Math.Sin(doubleA)";
                    vpravo = $"Math.Sin({doubleA})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Sin(doubleA)}");

                    vlevo = "Math.Sqrt(doubleA)";
                    vpravo = $"Math.Sqrt({doubleA})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Sqrt(doubleA)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine($"Metody s Double\n{e.Message}");
                }

                try
                {
                    doubleA = Convert.ToDouble(stringA);
                    intB = Convert.ToInt32(stringB);
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine("Metody s Double a Int");

                    vlevo = "Math.Round(doubleA,intA)";
                    vpravo = $"Math.Round({doubleA}, {intB})";
                    Console.WriteLine($"{vlevo,-30}{vpravo,30} >> {Math.Round(doubleA, intB)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine($"Metody s Double a Int\n{e.Message}");
                }

                Console.Write("Odenteruj!");
                Console.ReadLine();
            }

        }
    }
}
