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
namespace _190115p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rtbText.Text = @"Dobrý den milovaná paní třídní,
Omlouvám se, že jsem nepřišel do školy, protože jsem se včera opil.
Váš Maxíček :-P";
        }

        private void btnZakoduj_Click(object sender, EventArgs e)
        {
            rtbKod.Text = "";
            foreach (char z in rtbText.Text)
            {
                rtbKod.Text += ((int)z).ToString().PadLeft(3, '0');
            }
        }

        private void btnDekoduj_Click(object sender, EventArgs e)
        {
            rtbText.Text = "";
            try
            {
                string t = rtbKod.Text;
                for (int i = 0; i < t.Length; i += 3)
                {
                    rtbText.Text += $"{(char)Convert.ToInt16(t.Substring(i, 3))}";
                }
            }
            catch (Exception ex)
            {
                rtbText.Text = ex.Message;
            }
        }

        private void btnZakodujR3_Click(object sender, EventArgs e)
        {
            rtbKod.Text = "";
            foreach (char z in rtbText.Text)
            {
                rtbKod.Text = ((int)z).ToString().PadLeft(3, '0') + rtbKod.Text;
            }
        }

        private void btnDekodujR3_Click(object sender, EventArgs e)
        {
            rtbText.Text = "";
            try
            {
                string t = rtbKod.Text;
                for (int i = t.Length; i >= 0; i -= 3)
                {
                    rtbText.Text += $"{(char)Convert.ToInt16(t.Substring(i-3, 3))}";
                }
            }
            catch
            {
                // ignored
            }
        }

        private void btnZakodujR1_Click(object sender, EventArgs e)
        {
            string vstup = "";
            foreach (char znak in rtbText.Text)
            {
                vstup += ((int)znak).ToString().PadLeft(3, '0');
            }

            foreach (char znak in vstup.ToCharArray().Reverse().ToArray())
            {
                rtbKod.Text += znak;
            }
        }

        private void btnDekodujR1_Click(object sender, EventArgs e)
        {
            string vstup = "";

            foreach (char znak in rtbKod.Text.ToCharArray().Reverse().ToArray())
            {
                vstup += znak;
            }

            for (int i = 0; i < vstup.Length; i += 3)
            {
                rtbText.Text += $"{(char)Convert.ToInt16(vstup.Substring(i, 3))}";
            }

        }

        private void btnK1Zakoduj_Click(object sender, EventArgs e)
        {//znaky proložené * (!ohlídat, že v t není *)

            if (rtbText.Text.Contains('*'))
            {
                rtbKod.Text = "Nelze kódovat řetězec se znakem '*'";
                return;
            }

            string kod = "";

            foreach (char znak in rtbText.Text)
            {
                kod += $"{znak}*";
            }

            kod = kod.Trim('*');
            File.WriteAllText("k1.txt", kod, Encoding.UTF8);
            rtbKod.Text = "Uloženo!";

        }

        private void btnK2Zakoduj_Click(object sender, EventArgs e)
        {//ASCII proložené * (!ohlídat, že v t není *)

            if (rtbText.Text.Contains('*'))
            {
                rtbKod.Text = "Nelze kódovat řetězec se znakem '*'";
                return;
            }

            string kod = "";

            foreach (char znak in rtbText.Text)
            {
                kod += $"{(int)znak}*";
            }

            kod = kod.Trim('*');
            File.WriteAllText("k2.txt", kod, Encoding.UTF8);
            rtbKod.Text = "Uloženo!";
        }

        private void btnK3Zakoduj_Click(object sender, EventArgs e)
        {//znaky v ASCII o 1 posunuté

            if (rtbText.Text.Contains('*'))
            {
                rtbKod.Text = "Nelze kódovat řetězec se znakem '*'";
                return;
            }

            string kod = "";

            foreach (char znak in rtbText.Text)
            {
                kod += $"{(char)(znak+1)}";
            }

            File.WriteAllText("k3.txt", kod, Encoding.UTF8);
            rtbKod.Text = "Uloženo!";
        }

        private void btnK4Zakoduj_Click(object sender, EventArgs e)
        {
            //znaky v ASCII posunuté o náhodné číslo < 32,42 >

            if (rtbText.Text.Contains('*'))
            {
                rtbKod.Text = "Nelze kódovat řetězec se znakem '*'";
                return;
            }

            Random r = new Random();
            int cislo = r.Next(32, 43);

            string kod = $"{(char)cislo}{Environment.NewLine}";

            foreach (char znak in rtbText.Text)
            {
                kod += $"{(char)(znak + cislo)}";
            }

            File.WriteAllText("k4.txt", kod, Encoding.UTF8);
            rtbKod.Text = "Uloženo!";
        }
        private void btnK1Dekoduj_Click(object sender, EventArgs e)
        {
            string kod = File.ReadAllText("k1.txt", Encoding.UTF8);

            rtbKod.Text = kod;
            rtbKod.Text += "\n--------------------------\n";
            rtbKod.Text += kod.Replace("*", "");
        }

        private void btnK2Dekoduj_Click(object sender, EventArgs e)
        {
            string kod = File.ReadAllText("k2.txt", Encoding.UTF8);

            rtbKod.Text = kod;
            rtbKod.Text += "\n--------------------------\n";

            string[] znaky = kod.Split('*');
            foreach (string s in znaky)
            {
                rtbKod.Text += (char)Convert.ToInt32(s);
            }
        }

        private void btnK3Dekoduj_Click(object sender, EventArgs e)
        {
            string kod = File.ReadAllText("k3.txt", Encoding.UTF8);

            rtbKod.Text = kod;
            rtbKod.Text += "\n--------------------------\n";

            foreach (char znak in kod)
            {
                rtbKod.Text += (char)(znak-1);
            }
        }

        private void btnK4Dekoduj_Click(object sender, EventArgs e)
        {
            string[] kod = File.ReadAllLines("k4.txt", Encoding.UTF8);

            rtbKod.Text = $"{kod[0]}\n{kod[1]}";
            rtbKod.Text += "\n--------------------------\n";

            int cislo = Convert.ToChar(kod[0]);

            foreach (char znak in kod[1])
            {
                rtbKod.Text += (char)(znak - cislo);
            }
        }
    }
}
