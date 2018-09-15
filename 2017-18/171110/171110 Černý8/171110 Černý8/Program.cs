using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171110_Černý8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.CursorSize = 100;
            Console.Clear();
            while (true)
            {
                Console.CursorVisible = true;
                Console.Write("Zadej barvu: ");
                string barva = Console.ReadLine();
                Console.Write("Zadej zvíře: ");
                string potvora = Console.ReadLine();
                Console.Write("Zadej zachránce: ");
                string dalsi_potvora = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"\nO {barva} Karkulce\nBratři Grimmové\n\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($@"Byla jednou jedna sladká dívenka, kterou musel milovat každý, jen ji uviděl, ale nejvíce ji milovala její babička, která by jí snesla i modré z nebe. Jednou jí darovala čepeček karkulku z {barva} sametu a ten se vnučce tak líbil, že nic jiného nechtěla nosit, a tak jí začali říkat {barva} Karkulka.

Jednou matka {barva} Karkulce řekla: „Podívej, Karkulko, tady máš kousek koláče a láhev vína, zanes to babičce, je nemocná a zeslábla, tímhle se posilní. Vydej se na cestu dříve než bude horko, jdi hezky spořádaně a neodbíhej z cesty, když upadneš, láhev rozbiješ a babička nebude mít nic. A jak vejdeš do světnice, nezapomeň babičce popřát dobrého dne a ne abys šmejdila po všech koutech.“ „Ano, maminko, udělám, jak si přejete.“ řekla {barva} Karkulka, na stvrzení toho slibu podala matce ruku a vydala se na cestu.

Babička bydlela v lese; celou půlhodinu cesty od vesnice. Když šla {barva} Karkulka lesem, potkala {potvora}a. Tenkrát ještě nevěděla, co je to za záludné zvíře a ani trochu se ho nebála. „Dobrý den, {barva} Karkulko!“ řekl {potvora}. „Děkuji za přání, {potvora}u.“ „Kampak tak časně, {barva} Karkulko?“ „K babičce!“ „A copak to neseš v zástěrce?“ „Koláč a víno; včera jsme pekli, nemocné a zesláblé babičce na posilněnou.“ „Kdepak bydlí babička, {barva} Karkulko?“ „Inu, ještě tak čtvrthodiny cesty v lese, její chaloupka stojí mezi třemi velkými duby, kolem je lískové ořeší, určitě to tam musíš znát.“ odvětila {barva} Karkulka. {potvora} si pomyslil: „Tohle mlaďoučké, jemňoučké masíčko bude jistě chutnat lépe než ta stařena, musím to navléci lstivě, abych schlamstnul obě.“

Chvíli šel vedle {barva} Karkulky a pak pravil: „{barva} Karkulko, koukej na ty krásné květiny, které tu rostou všude kolem, pročpak se trochu nerozhlédneš? Myslím, že jsi ještě neslyšela ptáčky, kteří by zpívali tak líbezně. Ty jsi tu vykračuješ, jako kdybys šla do školy a přitom je tu v lese tak krásně!“ {barva} Karkulka otevřela oči dokořán a když viděla, jak sluneční paprsky tancují skrze stromy sem a tam a všude roste tolik krásných květin, pomyslila si: „Když přinesu babičce kytici čerstvých květin, bude mít jistě radost, času mám dost, přijdu akorát.“ A seběhla z cesty do lesa a trhala květiny. A když jednu utrhla, zjistila, že o kus dál roste ještě krásnější, běžela k ní, a tak se dostávala stále hlouběji do lesa.

Ale {potvora} běžel rovnou k babiččině chaloupce a zaklepal na dveře. „Kdo je tam?“ „{barva} Karkulka, co nese koláč a víno, otevři!“ „Jen zmáčkni kliku,“ zavolala babička: „jsem příliš slabá a nemohu vstát.“ {potvora} vzal za kliku, otevřel dveře a beze slova šel rovnou k babičce a spolknul ji. Pak si obléknul její šaty a nasadil její čepec, položil se do postele a zatáhnul závěs.

Zatím {barva} Karkulka běhala mezi květinami, a když jich měla náruč tak plnou, že jich víc nemohla pobrat, tu jí přišla na mysl babička, a tak se vydala na cestu za ní. Podivila se, že jsou dveře otevřené, a když vešla do světnice, přišlo jí vše takové podivné, že si pomyslila: „Dobrotivý Bože, je mi dneska nějak úzko a jindy jsem u babičky tak ráda.“ Zvolala: „Dobré jitro!“ Ale nedostala žádnou odpověď. Šla tedy k posteli a odtáhla závěs; ležela tam babička a měla čepec naražený hluboko do obličeje a vypadala nějak podivně.

Ach, babičko, proč máš tak velké uši?“ „Abych tě lépe slyšela.“ „Ach, babičko, proč máš tak velké oči?“ „Abych tě lépe viděla.“ „Ach, babičko, proč máš tak velké ruce?“ „Abych tě lépe objala.“ „Ach, babičko, proč máš tak strašlivou tlamu?“ „Abych tě lépe sežrala!!“

Sotva {potvora} ta slova vyřknul, vyskočil z postele a ubohou {barva} Karkulku spolknul. Když teď uhasil svoji žádostivost, položil se zpátky do postele a usnul a z toho spánku se jal mocně chrápat.

Zrovna šel kolem chaloupky {dalsi_potvora} a pomyslil si: „Ta stařenka ale chrápe, musím se na ni podívat, zda něco nepotřebuje.“ Vešel do světnice, a když přistoupil k posteli, uviděl, že v ní leží {potvora}. „Tak přece jsem tě našel, ty starý hříšníku!“ zvolal {dalsi_potvora}: „Už mám na tebe dlouho políčeno!“ Strhnul z ramene pušku, ale pak mu přišlo na mysl, že {potvora} mohl sežrat babičku a mohl by ji ještě zachránit. Nestřelil tedy, nýbrž vzal nůžky a začal spícímu {potvora}ovi párat břicho. Sotva učinil pár řezů, uviděl se červenat karkulku a po pár dalších řezech vyskočila dívenka ven a volala: „Ach, já jsem se tolik bála, ve {potvora}ovi je černočerná tma.“ A potom vylezla ven i živá babička; sotva dechu popadala. {barva} Karkulka pak nanosila obrovské kameny, kterými {potvora}ovo břicho naplnili, a když se ten probudil a chtěl utéci, kameny ho tak děsivě tížily, že klesnul k zemi nadobro mrtvý.

Ti tři byli spokojeni. {dalsi_potvora} stáhnul {potvora}ovi kožešinu a odnesl si ji domů, babička snědla koláč a vypila víno, které {barva} Karkulka přinesla, a opět se zotavila. A {barva} Karkulka? Ta si svatosvatě přísahala: „Už nikdy v životě nesejdu z cesty do lesa, když mi to maminka zakáže!“

O {barva} Karkulce se ještě vypráví, že když šla jednou zase k babičce s bábovkou, potkala jiného {potvora}a a ten se jí taky vemlouval a snažil se ji svést z cesty. Ale ona se toho vystříhala a kráčela rovnou k babičce, kde hned vypověděla, že potkala {potvora}a, který jí sice popřál dobrý den, ale z očí mu koukala nekalota. „Kdyby to nebylo na veřejné cestě, jistě by mne sežral!“ „Pojď,“ řekla babička: „zavřeme dobře dveře, aby nemohl dovnitř.“ Brzy nato zaklepal {potvora} a zavolal: „Otevři, babičko, já jsem {barva} Karkulka a nesu ti pečivo!“ Ty dvě však zůstaly jako pěny a neotevřely.

Tak se ten šedivák plížil kolem domu a naslouchal, pak vylezl na střechu, aby tam počkal, až {barva} Karkulka půjde večer domů, pak ji v temnotě popadne a sežere. Ale babička zlé {potvora}ovy úmysly odhalila. Před domem stály obrovské kamenné necky, tak {barva} Karkulce řekla: „Vezmi vědro, děvenko, včera jsem vařila klobásy, tak tu vodu nanosíme venku do necek.“ Když byly necky plné, stoupala vůně klobás nahoru až k {potvora}ovu čenichu. Zavětřil a natahoval krk tak daleko, že se na střeše více neudržel a začal klouzat dolů, kde spadnul přímo do necek a bídně se utopil.

A tak šla {barva} Karkulka večer spokojeně domů a nic zlého se jí nestalo.");

                Console.ForegroundColor = ConsoleColor.Black;
                Console.CursorVisible = false;
                Console.Write("\nOdenteruj!");
                Console.ReadLine();
                Console.Write("-------------------\n");
            }
        }
    }
}
