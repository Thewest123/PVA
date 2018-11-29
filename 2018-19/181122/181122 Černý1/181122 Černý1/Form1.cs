using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _181122_Černý1
{
    public partial class Form1 : Form
    {
        int dolniMez = -100;
        int horniMez = 100;
        int pocet = 10;
        int[] pole = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string zprava = @"Ano 
>> načte soubor (čOd*čDo*čPočet)
>> vytvoří pole, vygeneruje do něj čísla
>> hlídá pasivně chyby >> jako Ne
Ne
>> vytvoří pole <10,20>
>> vygeneruje do něj čísla <<-100,-1>,<1,100>>";

            if (MessageBox.Show(zprava, "Chcete načíst hodnoty?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Text = Nacti();
            }
            else
            {
                Generuj();
                Text = "Vygenerováno";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string zprava = @"Ano 
>> přepíše soubor hodnotami (čOd*čDo*čPočet)
Ne
>> neuloží hodnoty do souboru
Storno >> zastaví zavírání";

            DialogResult dr = MessageBox.Show(zprava, "Chcete uložit změny?", MessageBoxButtons.YesNoCancel);

            if (dr == DialogResult.Yes)
            {
                File.WriteAllText("t.txt", $"{dolniMez}*{horniMez}*{pocet}");

                using (StreamWriter sw = new StreamWriter("tt.txt"))
                {
                    foreach (var c in pole)
                    {
                        sw.WriteLine(c);
                    }
                }
            }
            else if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            Generuj();
        }

        private void btnVypis_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = $@"Pole:
Velikost {pole.Length}
Dolní mez: {dolniMez}
Horní mez: {horniMez}
------------
";
            for (int i = 0; i < pole.Length; i++)
            {
                rtbOutput.Text += $"pole[{i}] <> {pole[i]}\n";
            }
        }

        private void Generuj(bool nove = true)
        {
            Random r = new Random();
            if (nove)
            {
                pocet = r.Next(10, 20 + 1);
                dolniMez = r.Next(-100, 0 + 1);
                horniMez = r.Next(1, 100 + 1);
            }

            pole = new int[pocet];

            for (int i = 0; i < pocet; i++)
            {
                pole[i] = r.Next(dolniMez, horniMez + 1);
            }
        }

        private string Nacti()
        {
            try
            {
                string text = File.ReadAllText("t.txt", Encoding.Default);

                string[] split = text.Split('*');
                dolniMez = Convert.ToInt32(split[0]);
                horniMez = Convert.ToInt32(split[1]);
                pocet = Convert.ToInt32(split[2]);

                bool ano = NactiHodnoty();
                if (ano) return "Načteno";
                return "Vygenerováno";
            }
            catch
            {
                Generuj();
                return "Vygenerováno";
            }
        }

        private bool NactiHodnoty()
        {
            try
            {
                string[] poleHodnot = File.ReadAllLines("tt.txt", Encoding.Default);

                if (poleHodnot.Length != pocet)
                {
                    MessageBox.Show("Počet se nerovná velikosti pole");
                    Generuj();
                    return false;
                }
                else
                {
                    bool ano = KontrolaHodnot(poleHodnot);
                    
                    if (ano) return true;

                    MessageBox.Show("Kontrola hodnot je false");
                    Generuj();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error při načítání");
                Generuj();
                return false;
            }
        }

        private bool KontrolaHodnot(string[] poleHodnot)
        {
            int pocetChybnychKonverzi = 0;
            int[] novePoleHodnot = new int[poleHodnot.Length];

            for (int i = 0; i < poleHodnot.Length; i++)
            {
                if (!int.TryParse(poleHodnot[i], out novePoleHodnot[i])) pocetChybnychKonverzi++;
            }

            if (pocetChybnychKonverzi == 0)
            {
                pole = novePoleHodnot;
                return true;
            }

            return false;
        }
    }
}
