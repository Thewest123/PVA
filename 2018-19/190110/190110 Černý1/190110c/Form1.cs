using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190110c
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSplitAny_Click(object sender, EventArgs e)
        {
            Control c = sender as Control;
            List<string> vystup = new List<string>();
            vystup = tbVstup.Text.Split(Convert.ToChar(c.Text)).ToList();

            rtbVystup.Clear();
            for (int i = 0; i < vystup.Count; i++)
            {
                rtbVystup.Text += $"vystup[{i}] ~ {vystup[i]}\n";
            }
        }

        private void btnSubstring1_Click(object sender, EventArgs e)
        {
            rtbVystup.Text = $"t.SubString({nudOd.Value})\n";
            try
            {
                rtbVystup.Text += $"{tbVstup.Text.Substring((int)nudOd.Value)}";
            }
            catch (Exception ex)
            {
                rtbVystup.Text += $"Nastala chyba:\n{ex.Message}";
            }
        }

        private void btnSubstring2_Click(object sender, EventArgs e)
        {
            rtbVystup.Text = $"t.Substring({nudOd.Value},{nudKolik.Value})\n";
            try
            {
                rtbVystup.Text += $"{tbVstup.Text.Substring((int)nudOd.Value, (int)nudKolik.Value)}";
            }
            catch (Exception ex)
            {
                rtbVystup.Text += $"Nastala chyba:\n{ex.Message}";
            }
        }

        private void btnReplace1_Click(object sender, EventArgs e)
        {
            try
            {
                rtbVystup.Text = $"t.Replace({Convert.ToChar(tbCo.Text)},{Convert.ToChar(tbČím.Text)})\n";
                rtbVystup.Text += $"{tbVstup.Text.Replace(Convert.ToChar(tbCo.Text), Convert.ToChar(tbČím.Text))}";
            }
            catch (Exception ex)
            {
                rtbVystup.Text = $"t.Replace('','')\n";
                rtbVystup.Text += $"Nastala chyba:\n{ex.Message}";
            }
        }

        private void btnReplace2_Click(object sender, EventArgs e)
        {
            try
            {
                rtbVystup.Text = $"t.Replace({tbCo.Text},{tbČím.Text})\n";
                rtbVystup.Text += $"{tbVstup.Text.Replace(tbCo.Text, tbČím.Text)}";
            }
            catch (Exception ex)
            {
                rtbVystup.Text = $"t.Replace(\"\",\"\")\n";
                rtbVystup.Text += $"Nastala chyba:\n{ex.Message}";
            }
        }

        private void btnPadLeft1_Click(object sender, EventArgs e)
        {
            rtbVystup.Text = $"t.PadLeft({(int)nudNa.Value})\n";
            try
            {
                rtbVystup.Text += $"\"{tbVstup.Text.PadLeft((int)nudNa.Value)}\"";
            }
            catch (Exception ex)
            {
                rtbVystup.Text += $"Nastala chyba:\n{ex.Message}";
            }
        }
        private void btnPadLeft2_Click(object sender, EventArgs e)
        {
            try
            {
                rtbVystup.Text = $"t.PadLeft({(int)nudNa.Value},'{Convert.ToChar(tbČím.Text)}')\n";
                rtbVystup.Text += $"\"{tbVstup.Text.PadLeft((int)nudNa.Value, Convert.ToChar(tbČím.Text))}\"";
            }
            catch (Exception ex)
            {
                rtbVystup.Text = $"t.PadLeft(,'')\n";
                rtbVystup.Text += $"Nastala chyba:\n{ex.Message}";
            }
        }

        private void btnPadRight1_Click(object sender, EventArgs e)
        {
            rtbVystup.Text = $"t.PadRight({(int)nudNa.Value})\n";
            try
            {
                rtbVystup.Text += $"\"{tbVstup.Text.PadRight((int)nudNa.Value)}\"";
            }
            catch (Exception ex)
            {
                rtbVystup.Text += $"Nastala chyba:\n{ex.Message}";
            }
        }
        private void btnPadRight2_Click(object sender, EventArgs e)
        {
            try
            {
                rtbVystup.Text = $"t.PadRight({(int)nudNa.Value},'{Convert.ToChar(tbČím.Text)}')\n";
                rtbVystup.Text += $"\"{tbVstup.Text.PadRight((int)nudNa.Value, Convert.ToChar(tbČím.Text))}\"";
            }
            catch (Exception ex)
            {
                rtbVystup.Text = $"t.PadRight(,'')\n";
                rtbVystup.Text += $"Nastala chyba:\n{ex.Message}";
            }
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            char[] znaky = tbZnaky.Text.ToCharArray();

            rtbVystup.Text = $"Odstraňování přebytečných znaků:\n";
            rtbVystup.Text += $"Původní text: \"{tbVstup.Text}\"\n";

            rtbVystup.Text += $"t.Trim(): \"{tbVstup.Text.Trim()}\"\n";
            rtbVystup.Text += $"t.Trim([{tbZnaky.Text}]): \"{tbVstup.Text.Trim(znaky)}\"\n";
            rtbVystup.Text += $"t.TrimStart(): \"{tbVstup.Text.TrimStart()}\"\n";
            rtbVystup.Text += $"t.TrimStart([{tbZnaky.Text}]): \"{tbVstup.Text.TrimStart(znaky)}\"\n";
            rtbVystup.Text += $"t.TrimEnd(): \"{tbVstup.Text.TrimEnd()}\"\n";
            rtbVystup.Text += $"t.TrimEnd([{tbZnaky.Text}]): \"{tbVstup.Text.TrimEnd(znaky)}\"\n";
        }
    }
}