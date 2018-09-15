using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171124_Černý2
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

                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Vlastnosti:");
                Console.WriteLine($"Math.E >> {Math.E}");
                Console.WriteLine($"Math.PI >> {Math.PI}");

                try
                {
                    intA = Convert.ToInt32(stringA);
                    intB = Convert.ToInt32(stringB);
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Metody s Int");
                    Console.WriteLine($"Math.Abs(intA) >> Math.Abs({intA}) >> {Math.Abs(intA)}");
                    Console.WriteLine($"Math.BigMul(intA,intB) >> Math.BigMul({intA}, {intB}) >> {Math.BigMul(intA, intB)}");
                    Console.WriteLine($"Math.Exp(intA) >> Math.Exp({intA}) >> {Math.Exp(intA)}");
                    Console.WriteLine($"Math.Max(intA,intB) >> Math.Max({intA}, {intB}) >> {Math.Max(intA, intB)}");
                    Console.WriteLine($"Math.Min(intA,intB >> Math.Min({intA}, {intB} >> {Math.Min(intA, intB)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine($"Metody s Int\n{e.Message}");
                }

                try
                {
                    decimalA = Convert.ToDecimal(stringA);
                    decimalB = Convert.ToDecimal(stringB);
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Metody s Decimal");
                    Console.WriteLine($"Math.Abs(decimalA) >> Math.Abs({decimalA}) >> {Math.Abs(decimalA)}");
                    Console.WriteLine($"Math.Ceiling(decimalA) >> Math.Ceiling({decimalA}) >> {Math.Ceiling(decimalA)}");
                    Console.WriteLine($"Math.Floor(decimalA) >> Math.Floor({decimalA}) >> {Math.Floor(decimalA)}");
                    Console.WriteLine($"Math.Truncate(decimalA) >> Math.Truncate({decimalA}) >> {Math.Truncate(decimalA)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine($"Metody s Decimal\n{e.Message}");
                }

                try
                {
                    doubleA = Convert.ToDouble(stringA);
                    doubleB = Convert.ToDouble(stringB);
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Metody s Double");
                    Console.WriteLine($"Math.Abs(doubleA) >> Math.Abs({doubleA}) >> {Math.Abs(doubleA)}");
                    Console.WriteLine($"Math.Acos(doubleA) >> Math.Acos({doubleA}) >> {Math.Acos(doubleA)}");
                    Console.WriteLine($"Math.Asin(doubleA) >> ath.Asin({doubleA}) >> {Math.Asin(doubleA)}");
                    Console.WriteLine($"Math.Cos(doubleA) >> Math.Cos({doubleA}) >> {Math.Cos(doubleA)}");
                    Console.WriteLine($"Math.Log(doubleA) >> Math.Log({doubleA}) >> {Math.Log(doubleA)}");
                    Console.WriteLine($"Math.Log10(doubleA) >> Math.Log10({doubleA}) >> {Math.Log10(doubleA)}");
                    Console.WriteLine($"Math.Pow(doubleA,doubleB) >> Math.Pow({doubleA}, {doubleB}) >> {Math.Pow(doubleA, doubleB)}");
                    Console.WriteLine($"Math.Sin(doubleA) >> Math.Sin({doubleA}) >> {Math.Sin(doubleA)}");
                    Console.WriteLine($"Math.Sqrt(doubleA) >> Math.Sqrt({doubleA}) >> {Math.Sqrt(doubleA)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine($"Metody s Double\n{e.Message}");
                }

                try
                {
                    doubleA = Convert.ToDouble(stringA);
                    intB = Convert.ToInt32(stringB);
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Metody s Double a Int");
                    Console.WriteLine($"Math.Round(doubleA,intA) Math.Round({doubleA}, {intB}) >> {Math.Round(doubleA, intB)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine($"Metody s Double a Int\n{e.Message}");
                }

                Console.Write("Odenteruj!");
                Console.ReadLine();
            }

        }
    }
}
