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
            int w2 = ClientSize.Width / 2;
            int h2 = ClientSize.Height / 2;
            btnRed.Location = new Point(w2 - btnRed.Width - btnYellow.Width / 2, h2 - btnRed.Height - btnRed.Height/2);
            btnGreen.Location = new Point(w2 - btnGreen.Width / 2, h2 - btnGreen.Height - btnGreen.Height / 2);
            btnBlue.Location = new Point(w2 + btnBlue.Width / 2, h2 - btnBlue.Height - btnBlue.Height / 2);

            btnGray.Location = new Point(w2 - btnGray.Width / 2, h2 - btnGray.Height / 2);

            btnCyan.Location = new Point(w2 - btnCyan.Width - btnCyan.Width / 2, h2 + btnCyan.Height / 2);
            btnMagenta.Location = new Point(w2 - btnMagenta.Width / 2, h2 + btnMagenta.Height / 2);
            btnYellow.Location = new Point(w2 + btnYellow.Width / 2, h2 + btnYellow.Height / 2);

            MinimumSize = Size;
        }
        Random nc = new Random();
        private void btnRed_Click(object sender, EventArgs e)
        {
            btnRed.BackColor = Color.FromArgb(nc.Next(256),0,0);
            Vypiš("Red", (Button)sender);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            btnGreen.BackColor = Color.FromArgb(0, nc.Next(256), 0);
            Vypiš("Green", (Button)sender);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            btnBlue.BackColor = Color.FromArgb(0, 0, nc.Next(256));
            Vypiš("Blue", (Button)sender);
        }

        private void btnMagenta_Click(object sender, EventArgs e)
        {
            btnMagenta.BackColor = Color.FromArgb(255, nc.Next(256), 255);
            Vypiš("Magenta", (Button)sender);
        }

        private void btnCyan_Click(object sender, EventArgs e)
        {
            btnCyan.BackColor = Color.FromArgb(nc.Next(256), 255, 255);
            Vypiš("Cyan", (Button)sender);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            btnYellow.BackColor = Color.FromArgb(255, 255, nc.Next(256));
            Vypiš("Yellow", (Button)sender);
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            int gray = nc.Next(0, 256);
            btnGray.BackColor = Color.FromArgb(gray, gray, gray);
            Vypiš("Gray", (Button)sender);
        }

        private void Vypiš(string barva, Control control)
        {
            rtbVýpis.Text = $@"Odstíny {barva}
RGB({control.BackColor.R},{control.BackColor.G},{control.BackColor.B})";
        }

        private void tbRed_ValueChanged(object sender, EventArgs e)
        {
            var tb = (TrackBar)sender;
            tb.BackColor = Color.FromArgb(tb.Value, 0, 0);
            Vypiš("Red", tb);
        }

        private void tbGreen_ValueChanged(object sender, EventArgs e)
        {
            var tb = (TrackBar)sender;
            tb.BackColor = Color.FromArgb(0, tb.Value, 0);
            Vypiš("Green", tb);
        }

        private void tbBlue_ValueChanged(object sender, EventArgs e)
        {
            var tb = (TrackBar)sender;
            tb.BackColor = Color.FromArgb(0, 0, tb.Value);
            Vypiš("Blue", tb);
        }

        private void tbCyan_ValueChanged(object sender, EventArgs e)
        {
            var tb = (TrackBar)sender;
            tb.BackColor = Color.FromArgb(tb.Value, 255, 255);
            Vypiš("Cyan", tb);
        }

        private void tbMagenta_ValueChanged(object sender, EventArgs e)
        {
            var tb = (TrackBar)sender;
            tb.BackColor = Color.FromArgb(255, tb.Value, 255);
            Vypiš("Magenta", tb);
        }

        private void tbYellow_ValueChanged(object sender, EventArgs e)
        {
            var tb = (TrackBar)sender;
            tb.BackColor = Color.FromArgb(255, 255, tb.Value);
            Vypiš("Yellow", tb);
        }
    }
}
