using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171201_Černý1
{
    class Program
    {
        static void Main(string[] args)
        {
            //bílé pozadí, černé písmo
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            //návěstí
            //...
            začátek:
            //vymazání konzole
            Console.Clear();
            //minimální a maximální hodnoty int, Single
            int minInt = int.MinValue;
            int maxInt = int.MaxValue;
            Single minSingle = Single.MinValue;
            Single maxSingle = Single.MaxValue;

            //DateTime
            DateTime datumNow = DateTime.Now;
            DateTime datumToday = DateTime.Today;
            DateTime datumVlastní = new DateTime(2001, 11, 5, 06, 09, 33);

            //DateTime
            TimeSpan časVlastní = new TimeSpan(10, 9, 8, 7, 6);

            try
            {
                Console.WriteLine($@"Deklarováno a inicializováno
int minInt = int.MinValue;
int maxInt = int.MaxValue;
Single minSingle = Single.MinValue;
Single maxSingle = Single.MaxValue;
------------------------------------------------------------------------
Výpis s formátováním čísel
formátování (jeden znak!!!!)
 - c,C <> Měna
{{minInt}} >> {{minInt:c}} >> {{minInt:c5}} =>>= {minInt} >> {minInt:c} >> {minInt:c5}
{{maxInt}} >> {{maxInt:c}} >> {{maxInt:c5}} =>>= {maxInt} >> {maxInt:c} >> {maxInt:c5}
{{minSingle}} >> {{minSingle:c}} >> {{minSingle:c5}} =>>= {minSingle} >> {minSingle:c} >> {minSingle:c5}
{{maxSingle}} >> {{maxSingle:c}} >> {{maxSingle:c5}} =>>= {maxSingle} >> {maxSingle:c} >> {maxSingle:c5}
{{0.0005}} >> {{0.0005:c}} >> {{0.0005:c5}} =>>= {0.0005} >> {0.0005:c} >> {0.0005:c5}
........................................................................
 - d,D <> Decimal
{{minInt}} >> {{minInt:d}} >> {{minInt:d5}} =>>= {minInt} >> {minInt:d} >> {minInt:d5}
{{maxInt}} >> {{maxInt:d}} >> {{maxInt:d5}} =>>= {maxInt} >> {maxInt:d} >> {maxInt:d5}
........................................................................
 - e,E <> Exponenciální (vědecké)
{{minInt}} >> {{minInt:e}} >> {{minInt:e5}} =>>= {minInt} >> {minInt:e} >> {minInt:e5}
{{maxInt}} >> {{maxInt:e}} >> {{maxInt:e5}} =>>= {maxInt} >> {maxInt:e} >> {maxInt:e5}
{{minSingle}} >> {{minSingle:e}} >> {{minSingle:e5}} =>>= {minSingle} >> {minSingle:e} >> {minSingle:e5}
{{maxSingle}} >> {{maxSingle:e}} >> {{maxSingle:e5}} =>>= {maxSingle} >> {maxSingle:e} >> {maxSingle:e5}
{{0.0005}} >> {{0.0005:e}} >> {{0.0005:e5}} =>>= {0.0005} >> {0.0005:e} >> {0.0005:e5}
........................................................................
 - f,F <> S pevnou desetinnou čárkou  
{{minInt}} >> {{minInt:f}} >> {{minInt:f5}} =>>= {minInt} >> {minInt:f} >> {minInt:f5}
{{maxInt}} >> {{maxInt:f}} >> {{maxInt:f5}} =>>= {maxInt} >> {maxInt:f} >> {maxInt:f5}
{{minSingle}} >> {{minSingle:f}} >> {{minSingle:f5}} =>>= {minSingle} >> {minSingle:f} >> {minSingle:f5}
{{maxSingle}} >> {{maxSingle:f}} >> {{maxSingle:f5}} =>>= {maxSingle} >> {maxSingle:f} >> {maxSingle:f5}
{{0.0005}} >> {{0.0005:f}} >> {{0.0005:f5}} =>>= {0.0005} >> {0.0005:f} >> {0.0005:f5}
........................................................................
 - g,G <> Obecné
{{minInt}} >> {{minInt:g}} >> {{minInt:g5}} =>>= {minInt} >> {minInt:g} >> {minInt:g5}
{{maxInt}} >> {{maxInt:g}} >> {{maxInt:g5}} =>>= {maxInt} >> {maxInt:g} >> {maxInt:g5}
{{minSingle}} >> {{minSingle:g}} >> {{minSingle:g5}} =>>= {minSingle} >> {minSingle:g} >> {minSingle:g5}
{{maxSingle}} >> {{maxSingle:g}} >> {{maxSingle:g5}} =>>= {maxSingle} >> {maxSingle:g} >> {maxSingle:g5}
{{0.0005}} >> {{0.0005:g}} >> {{0.0005:g5}} =>>= {0.0005} >> {0.0005:g} >> {0.0005:g5}
........................................................................
 - n,N <> Číslo
{{minInt}} >> {{minInt:n}} >> {{minInt:n5}} =>>= {minInt} >> {minInt:n} >> {minInt:n5}
{{maxInt}} >> {{maxInt:n}} >> {{maxInt:n5}} =>>= {maxInt} >> {maxInt:n} >> {maxInt:n5}
{{minSingle}} >> {{minSingle:n}} >> {{minSingle:n5}} =>>= {minSingle} >> {minSingle:n} >> {minSingle:n5}
{{maxSingle}} >> {{maxSingle:n}} >> {{maxSingle:n5}} =>>= {maxSingle} >> {maxSingle:n} >> {maxSingle:n5}
{{0.0005}} >> {{0.0005:n}} >> {{0.0005:n5}} =>>= {0.0005} >> {0.0005:n} >> {0.0005:n5}
........................................................................
 - p,P <> V procentech
{{minInt}} >> {{minInt:p}} >> {{minInt:p5}} =>>= {minInt} >> {minInt:p} >> {minInt:p5}
{{maxInt}} >> {{maxInt:p}} >> {{maxInt:p5}} =>>= {maxInt} >> {maxInt:p} >> {maxInt:p5}
{{minSingle}} >> {{minSingle:p}} >> {{minSingle:p5}} =>>= {minSingle} >> {minSingle:p} >> {minSingle:p5}
{{maxSingle}} >> {{maxSingle:p}} >> {{maxSingle:p5}} =>>= {maxSingle} >> {maxSingle:p} >> {maxSingle:p5}
{{0.0005}} >> {{0.0005:p}} >> {{0.0005:p5}} =>>= {0.0005} >> {0.0005:p} >> {0.0005:p5}
........................................................................
 - x,X <> Šestnáctkově
{{minInt}} >> {{minInt:x}} >> {{minInt:x5}} =>>= {minInt} >> {minInt:x} >> {minInt:x5}
{{maxInt}} >> {{maxInt:x}} >> {{maxInt:x5}} =>>= {maxInt} >> {maxInt:x} >> {maxInt:x5}
........................................................................

vlastní formátování (více znaků!!!)
Vlastní měna
{{512.345}} >> {{512.345:# zlatých.## stříbrných}} =>>= {512.345} >> {512.345:# zlatých.## stříbrných}

------------------------------------------------------------------------
");
                Console.WriteLine($@"Deklarováno a inicializováno
DateTime datumNow = DateTime.Now;
DateTime datumToday = DateTime.Today;
DateTime datumVlastní = new DateTime(2001,11,5,06,09,33);
------------------------------------------------------------------------
Výpis s formátováním datumu
formátování (jeden znak
........................................................................
- d <> Vzor krátkého formátu data.
{{datumNow:d}} >> {datumNow} >> {datumNow:d}
{{datumToday:d}} >> {datumToday} >> {datumToday:d}
{{datumVlastní:d}} >> {datumVlastní} >> {datumVlastní:d}
........................................................................
- D <> Vzor dlouhého formátu data.
{{datumNow:D}} >> {datumNow} >> {datumNow:D}
{{datumToday:D}} >> {datumToday} >> {datumToday:D}
{{datumVlastní:D}} >> {datumVlastní} >> {datumVlastní:D}
.......................................................................
- f <> Vzor úplné datum a čas(krátký čas).
{{datumNow:f}} >> {datumNow} >> {datumNow:f}
{{datumToday:f}} >> {datumToday} >> {datumToday:f}
{{datumVlastní:f}} >> {datumVlastní} >> {datumVlastní:f}
.......................................................................
- F <> Vzor úplné datum a čas(dlouhý čas).
{{datumNow:F}} >> {datumNow} >> {datumNow:F}
{{datumToday:F}} >> {datumToday} >> {datumToday:F}
{{datumVlastní:F}} >> {datumVlastní} >> {datumVlastní:F}
.......................................................................
- g <> Vzor Obecné datum a čas(krátký čas).
{{datumNow:g}} >> {datumNow} >> {datumNow:g}
{{datumToday:g}} >> {datumToday} >> {datumToday:g}
{{datumVlastní:g}} >> {datumVlastní} >> {datumVlastní:g}
........................................................................
- G <> Vzor Obecné datum a čas(dlouhý čas).
{{datumNow:G}} >> {datumNow} >> {datumNow:G}
{{datumToday:G}} >> {datumToday} >> {datumToday:G}
{{datumVlastní:G}} >> {datumVlastní} >> {datumVlastní:G}
........................................................................
- M, m <> Vzor měsíc a den.
{{datumNow:m}} >> {datumNow} >> {datumNow:m}
{{datumToday:m}} >> {datumToday} >> {datumToday:m}
{{datumVlastní:m}} >> {datumVlastní} >> {datumVlastní:m}
........................................................................
- R, r <> Vzor RFC1123.
{{datumNow:r}} >> {datumNow} >> {datumNow:r}
{{datumToday:r}} >> {datumToday} >> {datumToday:r}
{{datumVlastní:r}} >> {datumVlastní} >> {datumVlastní:r}
........................................................................
- s <> Vzor seřaditelné datum a čas.
{{datumNow:s}} >> {datumNow} >> {datumNow:s}
{{datumToday:s}} >> {datumToday} >> {datumToday:s}
{{datumVlastní:s}} >> {datumVlastní} >> {datumVlastní:s}
........................................................................
- t <> Vzor krátkého formátu času.
{{datumNow:t}} >> {datumNow} >> {datumNow:t}
{{datumToday:t}} >> {datumToday} >> {datumToday:t}
{{datumVlastní:t}} >> {datumVlastní} >> {datumVlastní:t}
........................................................................
- T <> Vzor dlouhého formátu času.
{{datumNow:T}} >> {datumNow} >> {datumNow:T}
{{datumToday:T}} >> {datumToday} >> {datumToday:T}
{{datumVlastní:T}} >> {datumVlastní} >> {datumVlastní:T}
........................................................................
- u <> Vzor Univerzální seřaditelné datum a čas.
{{datumNow:u}} >> {datumNow} >> {datumNow:u}
{{datumToday:u}} >> {datumToday} >> {datumToday:u}
{{datumVlastní:u}} >> {datumVlastní} >> {datumVlastní:u}
........................................................................
- U <> Vzor univerzální úplné datum a čas.
{{datumNow:U}} >> {datumNow} >> {datumNow:U}
{{datumToday:U}} >> {datumToday} >> {datumToday:U}
{{datumVlastní:U}} >> {datumVlastní} >> {datumVlastní:U}
........................................................................
- Y, y <> Vzorek roku a měsíce.
{{datumNow:y}} >> {datumNow} >> {datumNow:y}
{{datumToday:y}} >> {datumToday} >> {datumToday:y}
{{datumVlastní:y}} >> {datumVlastní} >> {datumVlastní:y}
------------------------------------------------------------------------
vlastní formátování (více znaků!!!)
{datumNow:'Dnes je 'dddd d\. MMMM', je právě 'H 'hodin a 's 'sekund, samozřejmě 'g' :)'}

------------------------------------------------------------------------
");
                Console.WriteLine($@"Deklarováno a inicializováno
TimeSpan časVlastní = new TimeSpan(10, 9, 8, 7, 6);
------------------------------------------------------------------------
Výpis s formátováním času
formátování (jeden znak!!!!)
........................................................................
- c <> Konstantní (neutrální) formát
{{časVlastní:c}} >> {časVlastní} >> {časVlastní:c}
 ........................................................................
- g <> Obecný krátký formát
{{časVlastní:g}} >> {časVlastní} >> {časVlastní:g}
 ........................................................................
- G <> Obecný dlouhý formát
{{časVlastní:G}} >> {časVlastní} >> {časVlastní:G}
 ------------------------------------------------------------------------
vastní formátování(více znaků!!!)
-, %d <> Počet celých dní v časovém intervalu.
{{časVlastní:%d}} >> {časVlastní} >> {časVlastní:%d}
 ........................................................................
- dd - dddddddd <> Počet celých dní v časovém intervalu, vyplní úvodními nulami podle potřeby.
{{časVlastní:dd}} >> {časVlastní} >> {časVlastní:dd}
{{časVlastní:ddd}} >> {časVlastní} >> {časVlastní:ddd}
{{časVlastní:dddd}} >> {časVlastní} >> {časVlastní:dddd}
{{časVlastní:ddddd}} >> {časVlastní} >> {časVlastní:ddddd}
{{časVlastní:dddddd}} >> {časVlastní} >> {časVlastní:dddddd}
{{časVlastní:ddddddd}} >> {časVlastní} >> {časVlastní:ddddddd}
{{časVlastní:dddddddd}} >> {časVlastní} >> {časVlastní:dddddddd}
 ........................................................................
- h, %h <> Počet celých hodin v časovém intervalu, který se počítají jako součást dnů. Hodin nemají úvodní nuly.
{{časVlastní:%h}} >> {časVlastní} >> {časVlastní:%h}
 ........................................................................
- hh <> Počet celých hodin v časovém intervalu, který se počítají jako součást dnů. Jednociferné hodiny má počáteční nuly.
{{časVlastní:hh}} >> {časVlastní} >> {časVlastní:hh}
 ........................................................................
- m, %m <> Počet celých minut v časovém intervalu, které nejsou součástí hodin nebo dnů. Řádu minut nemají úvodní nuly.
{{časVlastní:%m}} >> {časVlastní} >> {časVlastní:%m}
 ........................................................................
- mm <> Počet celých minut v časovém intervalu, které nejsou součástí hodin nebo dnů. Jednociferné minut mají počáteční nuly.
{{časVlastní:mm}} >> {časVlastní} >> {časVlastní:mm}
 ........................................................................
- s, %s <> Počet celých sekund v časovém intervalu, které nejsou součástí hodiny, dny nebo minut. Řádu sekund nemají úvodní nuly.
{{časVlastní:%s}} >> {časVlastní} >> {časVlastní:%s}
 ........................................................................
- ss <> Počet celých sekund v časovém intervalu, které nejsou součástí hodiny, dny nebo minut. Jednociferné sekund mají počáteční nuly.
{{časVlastní:ss}} >> {časVlastní} >> {časVlastní:ss}
 ........................................................................
- f, %f <> Desetin sekundy v určitém časovém intervalu.
{{časVlastní:%f}} >> {časVlastní} >> {časVlastní:%f}
 ........................................................................
- ff <> Setiny sekundy v určitém časovém intervalu.
{{časVlastní:ff}} >> {časVlastní} >> {časVlastní:ff}
 ........................................................................
- fff <> Počet milisekund v určitém časovém intervalu.
{{časVlastní:fff}} >> {časVlastní} >> {časVlastní:fff}
 ........................................................................
- ffff <> Desetitisíciny sekundy v časovém intervalu.
{{časVlastní:ffff}} >> {časVlastní} >> {časVlastní:ffff}
 ........................................................................
- fffff <> Stotisíciny sekundy v časovém intervalu.
{{časVlastní:fffff}} >> {časVlastní} >> {časVlastní:fffff}
 ........................................................................
- ffffff <> Miliontin sekundy v určitém časovém intervalu.
{{časVlastní:ffffff}} >> {časVlastní} >> {časVlastní:ffffff}
 ........................................................................
- fffffff <> Desetimiliontin druhý(nebo zlomkové rysky) v určitém časovém intervalu.
{{časVlastní:fffffff}} >> {časVlastní} >> {časVlastní:fffffff}
 ........................................................................
- F, %F <> Desetin sekundy v určitém časovém intervalu.Nezobrazí se žádná hodnota, pokud je číslice nula.
{{časVlastní:%F}} >> {časVlastní} >> {časVlastní:%F}
 ........................................................................
- FF <> Setiny sekundy v určitém časovém intervalu.Jakékoli koncové nuly nebo dvě zlomkové nuly nejsou zahrnuty.
{{časVlastní:FF}} >> {časVlastní} >> {časVlastní:FF}
 ........................................................................
- FFF <> Počet milisekund v určitém časovém intervalu.Jakékoli zlomkové koncové nuly nejsou zahrnuty.
{{časVlastní:FFF}} >> {časVlastní} >> {časVlastní:FFF}
 ........................................................................
- FFFF <> Desetitisíciny sekundy v časovém intervalu. Jakékoli zlomkové koncové nuly nejsou zahrnuty.
{{časVlastní:FFFF}} >> {časVlastní} >> {časVlastní:FFFF}
 ........................................................................
- FFFFF <> Stotisíciny sekundy v časovém intervalu. Jakékoli zlomkové koncové nuly nejsou zahrnuty.
{{časVlastní:FFFFF}} >> {časVlastní} >> {časVlastní:FFFFF}
 ........................................................................
- FFFFFF <> Miliontin sekundy v určitém časovém intervalu.Jakékoli zlomkové koncové nuly nejsou zobrazeny.
{{časVlastní:FFFFFF}} >> {časVlastní} >> {časVlastní:FFFFFF}
 ........................................................................
- FFFFFFF <> Do 10 milionů sekundy v určitém časovém intervalu. Jakékoli zlomkové koncové nuly nebo sedm nul se nezobrazí.
{{časVlastní:FFFFFF}} >> {časVlastní} >> {časVlastní:FFFFFFF}
 ........................................................................
 - ' řetězec ' <> Oddělovač řetězcového literálu.
{{časVlastní:'To jsou dny 'd}} >> {časVlastní} >> {časVlastní:'To jsou dny 'd}
 ........................................................................
- \ <> Řídicí znak.
{časVlastní:\T\o\ \j\s\o\u\ \d\n\y\ d} >> 2.06:55:05.0100000 >> To jsou dny 2
{{časVlastní:\T\o\ \j\s\o\u\ \d\n\y\ d}} >> {časVlastní} >> {časVlastní:\T\o\ \j\s\o\u\ \d\n\y\ d}
 ------------------------------------------------------------------------

vlastní formátování (více znaků!!!)
...

------------------------------------------------------------------------
");
                Console.WriteLine($@"Deklarováno a inicializováno
nic >> vytvářet vlastní výčtové typy (enum) ještě neumíme
------------------------------------------------------------------------
Výpis s formátováním enum
formátování (jeden znak!!!!)
...
vlastní formátování (více znaků!!!)
není!!!
------------------------------------------------------------------------
");

                Console.ReadLine();

            }
            catch (Exception er)
            {
                Console.WriteLine($@"------------------------------------------------------------------------
Chyba:
{er.Message}
------------------------------------------------------------------------");
            }
            Console.WriteLine("Odentruj!");
            Console.ReadLine();
            //přechod na návěstí
            //...
            goto začátek;
        }
    }
}
