using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181213_Černý1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void controls_MouseUp(object sender, MouseEventArgs e)
        {
            var c = sender as Control;
            if (e.Button == MouseButtons.Left) MessageBox.Show($"RGB({c.BackColor.R},{c.BackColor.G},{c.BackColor.B})", c.GetType().Name);
            if (e.Button == MouseButtons.Right) MessageBox.Show($"Location[{c.Left},{c.Top}]", c.GetType().Name);
            if (e.Button == MouseButtons.Middle)
            {
                var dr = MessageBox.Show("Chcete prvek přegenerovat?", c.GetType().Name, MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes && c is CheckBox box)
                {
                    if (box.Checked)
                    {
                        ZmenaBarvy(box);
                        ZmenaPozice(box);
                    } else MessageBox.Show("S tímhle pracovat nebudu!", "CheckBox neaktivní");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                ZmenaBarvy(c);
                ZmenaPozice(c);
            }
        }

        private Random r = new Random();

        private void ZmenaPozice(Control c) => c.Location = new Point(r.Next(0, ClientSize.Width - c.Width), r.Next(0, ClientSize.Height - c.Height));

        private void ZmenaBarvy(Control c)
        {
            if (c is Button) c.BackColor = Color.FromArgb(r.Next(0, 256), 0, 0);
            if (c is RadioButton) c.BackColor = Color.FromArgb(0, r.Next(0, 256), 0);
            if (c is CheckBox) c.BackColor = Color.FromArgb(0, 0, r.Next(0, 256));
        }

        private void controls_KeyUp(object sender, KeyEventArgs e)
        {
            var s = sender as Control;

            if (e.Modifiers == 0)
            {
                if (e.KeyCode == Keys.B && s is Button ||
                    e.KeyCode == Keys.C && s is CheckBox ||
                    e.KeyCode == Keys.R && s is RadioButton ||
                    e.KeyCode == Keys.V)
                {
                    ZmenaPozice(s);
                }
            }
            else if (e.Modifiers == Keys.Alt)
            {
                if (e.KeyCode == Keys.B && s is Button ||
                    e.KeyCode == Keys.C && s is CheckBox ||
                    e.KeyCode == Keys.R && s is RadioButton ||
                    e.KeyCode == Keys.V)
                {
                    ZmenaBarvy(s);
                }
            }
            else if (e.Modifiers == Keys.Control)
            {
                if (e.KeyCode == Keys.B && s is Button ||
                    e.KeyCode == Keys.C && s is CheckBox ||
                    e.KeyCode == Keys.R && s is RadioButton ||
                    e.KeyCode == Keys.V)
                {
                    ZmenaPozice(s);
                    ZmenaBarvy(s);
                }
            }
            else if (e.Modifiers == Keys.Shift)
            {
                foreach (var c in Controls)
                {
                    if (e.KeyCode == Keys.B && s is Button && c is Button but) ZmenaPozice(but);
                    else if (e.KeyCode == Keys.C && s is CheckBox && c is CheckBox box) ZmenaPozice(box);
                    else if (e.KeyCode == Keys.R && s is RadioButton && c is RadioButton rb) ZmenaPozice(rb);
                    else if (e.KeyCode == Keys.V) ZmenaPozice((Control)c);
                }
            }
            else if (e.Modifiers == (Keys.Shift | Keys.Alt))
            {
                foreach (var c in Controls)
                {
                    if (e.KeyCode == Keys.B && s is Button && c is Button but) ZmenaBarvy(but);
                    else if (e.KeyCode == Keys.C && s is CheckBox && c is CheckBox box) ZmenaBarvy(box);
                    else if (e.KeyCode == Keys.R && s is RadioButton && c is RadioButton rb) ZmenaBarvy(rb);
                    else if (e.KeyCode == Keys.V) ZmenaBarvy((Control)c);
                }
            }
            else if (e.Modifiers == (Keys.Shift | Keys.Control))
            {
                foreach (var c in Controls)
                {
                    if (e.KeyCode == Keys.B && s is Button && c is Button but)
                    {
                        ZmenaPozice(but);
                        ZmenaBarvy(but);
                    }

                    else if (e.KeyCode == Keys.C && s is CheckBox && c is CheckBox box)
                    {
                        ZmenaPozice(box);
                        ZmenaBarvy(box);
                    }

                    else if (e.KeyCode == Keys.R && s is RadioButton && c is RadioButton rb)
                    {
                        ZmenaPozice(rb);
                        ZmenaBarvy(rb);
                    }
                    else if (e.KeyCode == Keys.V)
                    {
                        ZmenaPozice((Control)c);
                        ZmenaBarvy((Control)c);
                    }
                }
            }
        }
    }
}
