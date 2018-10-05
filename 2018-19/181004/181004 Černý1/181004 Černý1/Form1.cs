using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181004_Černý1
{
    public partial class FormBarvy : Form
    {
        static Random _ran = new Random();
        public FormBarvy()
        {
            InitializeComponent();
        }

        private void FormBarvy_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;

            lblOut.Text = "Label pro výpis\n";
            lblOut.Text += "Změněné vlastnosti:\n";
            lblOut.Text += " - AutoSize\n";
            lblOut.Text += " - BorderStyle\n";
            lblOut.Text += "\n";
            lblOut.Text += "Rada:\n";
            lblOut.Text += "Pro výpis do labelu:\n";
            lblOut.Text += ">> labelu přiřaďte metodu k události BackColorChanged a vypisujte v ní\n";
            lblOut.Text += ">> hodnoty jednotlivých komponent barvy získáte z vlastností barvy\n";

            btnRed.BackColor = Color.Red;
            btnGreen.BackColor = Color.Green;
            btnBlue.BackColor = Color.Blue;

            btnCyan.BackColor = Color.Cyan;
            btnMagenta.BackColor = Color.Magenta;
            btnYellow.BackColor = Color.Yellow;

            btnRndRGB.BackColor = Color.FromArgb(_ran.Next(0, 256), _ran.Next(0, 256), _ran.Next(0, 256));
            btnRndARGB.BackColor = Color.FromArgb(_ran.Next(0, 256), _ran.Next(0, 256), _ran.Next(0, 256), _ran.Next(0, 256));
            int grey = _ran.Next(0, 256);
            btnRndGrey.BackColor = Color.FromArgb(grey, grey, grey);

            btnRndRed.BackColor = Color.FromArgb(_ran.Next(0, 256), 0, 0);
            btnRndGreen.BackColor = Color.FromArgb(0, _ran.Next(0, 256), 0);
            btnRndBlue.BackColor = Color.FromArgb(0, 0, _ran.Next(0, 256));

            btnRndCyan.BackColor = Color.FromArgb(_ran.Next(0, 256), 255, 255);
            btnRndMagenta.BackColor = Color.FromArgb(255, _ran.Next(0, 256), 255);
            btnRndYellow.BackColor = Color.FromArgb(255, 255, _ran.Next(0, 256));
        }

        #region PojmenovaneBarvy
        private void btnPojmenovane_Click(object sender, EventArgs e)
        {
            lblOut.BackColor = ((Button)sender).BackColor;
        }

        #endregion
        
        #region NahodneBarvy
        private void btnRndRGB_Click(object sender, EventArgs e)
        {
            btnRndRGB.BackColor = Color.FromArgb(_ran.Next(0, 256), _ran.Next(0, 256), _ran.Next(0, 256));
            lblOut.BackColor = ((Button)sender).BackColor;
        }

        private void btnRndARGB_Click(object sender, EventArgs e)
        {
            btnRndARGB.BackColor = Color.FromArgb(_ran.Next(0, 256), _ran.Next(0, 256), _ran.Next(0, 256), _ran.Next(0, 256));
            lblOut.BackColor = ((Button)sender).BackColor;
        }

        private void btnRndGrey_Click(object sender, EventArgs e)
        {
            int seda = _ran.Next(0, 256);
            btnRndGrey.BackColor = Color.FromArgb(seda, seda, seda);
            lblOut.BackColor = ((Button)sender).BackColor;
        }
        #endregion

        #region NahodnyJedenKanal
        private void btnRndRed_Click(object sender, EventArgs e)
        {
            btnRndRed.BackColor = Color.FromArgb(_ran.Next(0, 256), 0, 0);
            lblOut.BackColor = ((Button)sender).BackColor;
        }

        private void btnRndGreen_Click(object sender, EventArgs e)
        {
            btnRndGreen.BackColor = Color.FromArgb(0, _ran.Next(0, 256), 0);
            lblOut.BackColor = ((Button)sender).BackColor;
        }

        private void btnRndBlue_Click(object sender, EventArgs e)
        {
            btnRndBlue.BackColor = Color.FromArgb(0, 0, _ran.Next(0, 256));
            lblOut.BackColor = ((Button)sender).BackColor;
        }

        private void btnRndCyan_Click(object sender, EventArgs e)
        {
            btnRndCyan.BackColor = Color.FromArgb(_ran.Next(0, 256), 255, 255);
            lblOut.BackColor = ((Button)sender).BackColor;
        }

        private void btnRndMagenta_Click(object sender, EventArgs e)
        {
            btnRndMagenta.BackColor = Color.FromArgb(255, _ran.Next(0, 256), 255);
            lblOut.BackColor = ((Button)sender).BackColor;
        }

        private void btnRndYellow_Click(object sender, EventArgs e)
        {
            btnRndYellow.BackColor = Color.FromArgb(255, 255, _ran.Next(0, 256));
            lblOut.BackColor = ((Button)sender).BackColor;
        }
        #endregion

        private void lblOut_BackColorChanged(object sender, EventArgs e)
        {
            //Když je barva pozadí moc tmavá, nastaví text na bílou a naopak
            lblOut.ForeColor = lblOut.BackColor.GetBrightness() < 0.5 && lblOut.BackColor.A > 128 ? Color.White : DefaultForeColor;

            lblOut.Text = "Nastavená barva:\n";
            lblOut.Text += $"{lblOut.BackColor}\n";
            lblOut.Text += $"A: {lblOut.BackColor.A}\n";
            lblOut.Text += $"R: {lblOut.BackColor.R}\n";
            lblOut.Text += $"G: {lblOut.BackColor.G}\n";
            lblOut.Text += $"B: {lblOut.BackColor.B}\n";
        }
    }
}