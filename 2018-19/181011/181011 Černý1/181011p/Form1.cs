using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181011p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Random nc = new Random();
        private void butRedLH_Click(object sender, EventArgs e)
        {
            butRedLH.BackColor = GenerujBarvu(true);
            rtbVýpis.Text = Vypiš("Red", butRedLH);
        }

        private void butGreenH_Click(object sender, EventArgs e)
        {
            butGreenH.BackColor = GenerujBarvu(g: true);
            rtbVýpis.Text = Vypiš("Green", butGreenH);
        }

        private void butBluePH_Click(object sender, EventArgs e)
        {
            butBluePH.BackColor = GenerujBarvu(b: true);
            rtbVýpis.Text = Vypiš("Blue", butBluePH);
        }

        private void butCyanLD_Click(object sender, EventArgs e)
        {
            butCyanLD.BackColor = GenerujBarvu(true, zbytek: 255);
            rtbVýpis.Text = Vypiš("Cyan", butCyanLD);
        }
        private void butMagentaD_Click(object sender, EventArgs e)
        {
            butMagentaD.BackColor = GenerujBarvu(g: true, zbytek: 255);
            rtbVýpis.Text = Vypiš("Magenta", butMagentaD);
        }
        private void butYellowPD_Click(object sender, EventArgs e)
        {
            butYellowPD.BackColor = GenerujBarvu(b: true, zbytek: 255);
            rtbVýpis.Text = Vypiš("Yellow", butYellowPD);
        }

        private string Vypiš(string b, Button but)
        {
            return $@"Odstíny {b}
RGB({but.BackColor.R},{but.BackColor.G},{but.BackColor.B})";
        }

        private Color GenerujBarvu(bool r = false, bool g = false, bool b = false, int zbytek = 0)
        {
            if (r) return Color.FromArgb(nc.Next(0, 255), zbytek, zbytek);
            if (g) return Color.FromArgb(zbytek, nc.Next(0, 255), zbytek);
            if (b) return Color.FromArgb(zbytek, zbytek, nc.Next(0, 255));
            return DefaultBackColor;
        }
    }
}
