using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace _181115c
{
    public partial class Form1 : Form
    {
        private List<string> _byteOutput = new List<string>();
        private List<string> _int16Output = new List<string>();
        private List<string> _int32Output = new List<string>();
        private List<string> _doubleOutput = new List<string>();

        public Form1()
        {
            InitializeComponent();
            MinimumSize = Size;

            nudInt16DM.Minimum = short.MinValue;
            nudInt16DM.Maximum = short.MaxValue;

            nudInt16HM.Minimum = short.MinValue;
            nudInt16HM.Maximum = short.MaxValue;

            nudInt32DM.Minimum = int.MinValue;
            nudInt32DM.Maximum = int.MaxValue;

            nudInt32HM.Minimum = int.MinValue;
            nudInt32HM.Maximum = int.MaxValue;
        }

        private void btnNacti_Click(object sender, EventArgs e)
        {
            if (File.Exists("Intervaly.txt"))
            {
                string[] lines = File.ReadAllLines("Intervaly.txt");
                lbVýpis.Text =          Kontroluj(lines[0], nudBytePočet, nudByteDM, nudByteHM)       ;
                lbVýpis.Text += $"<> {  Kontroluj(lines[1], nudInt16DM, nudInt16DM, nudInt16HM)     }";
                lbVýpis.Text += $"<> {  Kontroluj(lines[2], nudInt32Počet, nudInt32DM, nudInt32HM)  }";
                lbVýpis.Text += $"<> {  Kontroluj(lines[3], nudDouble)  }";
            }
            else
            {
                lbVýpis.Text = "Soubor neexistuje!";
            }
        }

        public string Kontroluj(string radek, params NumericUpDown[] nud)
        {
            try
            {
                string[] split = radek.Split('*');

                for (int i = 0; i < nud.Length; i++)
                {
                    nud[i].Value = Convert.ToInt32(split[i]);
                }

                return "OK";
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return "Chyba v souboru";
            }

        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            Generuj(_byteOutput, nudBytePočet, nudByteDM, nudByteHM);
            Generuj(_int16Output, nudInt16Počet, nudInt16DM, nudInt16HM);
            Generuj(_int32Output, nudInt32Počet, nudInt32DM, nudInt32HM);
            Generuj(_doubleOutput, nudDouble);
        }

        public void Generuj(List<string> output, NumericUpDown pocet, NumericUpDown dolniMez, NumericUpDown horniMez)
        {
            int dm = (int)dolniMez.Value;
            int hm = (int)horniMez.Value;
            output.Clear();

            if (dm > hm)
            {
                int swap = dm;
                dm = hm;
                hm = swap;

                output.Add("PROHOZENO\n");
            }
            else
            {
                output.Add("VÝCHOZÍ\n");
            }

            output.Add($"Počet {pocet.Value}");
            output.Add($"Od {dm}");
            output.Add($"Do {hm}");
            output.Add($"----------------\n");

            Random r = new Random();
            for (int i = 1; i <= pocet.Value; i++)
            {
                output.Add($"{i,3} ~ {r.Next(dm, hm+1)}");
            }
        }

        public void Generuj(List<string> output, NumericUpDown pocet)
        {
            output.Clear();
            output.Add($"Počet {pocet.Value}");
            output.Add($"Od 0");
            output.Add($"Do 1");
            output.Add($"----------------\n");

            Random r = new Random();
            for (int i = 1; i <= pocet.Value; i++)
            {
                output.Add($"{i,3} ~ {r.NextDouble():f6}");
            }
        }

        private void btnVypis_Click(object sender, EventArgs e)
        {
            trbByte.Lines = _byteOutput.ToArray();
            trbInt16.Lines = _int16Output.ToArray();
            trbInt32.Lines = _int32Output.ToArray();
            trbDouble.Lines = _doubleOutput.ToArray();
        }
    }
}
