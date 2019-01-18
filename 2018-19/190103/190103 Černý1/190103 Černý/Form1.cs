using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190103_Černý
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            Pregenerovat();
        }

        public void Pregenerovat()
        {
            Color[] colors = new Color[5];
            Random r = new Random();

            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }

            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button) ctrl.BackColor = colors[0];
                if (ctrl is RadioButton) ctrl.BackColor = colors[1];
                if (ctrl is CheckBox) ctrl.BackColor = colors[2];
                if (ctrl is Label) ctrl.BackColor = colors[3];
                if (ctrl is TextBox) ctrl.BackColor = colors[4];

                ctrl.Location = new Point(r.Next(0, ClientSize.Width - ctrl.Width + 1), r.Next(0, ClientSize.Height - ctrl.Height + 1));
            }
        }

        enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }

        private void Posun(Direction dir, Type t1, Type t2, bool vsechny = false)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl.GetType() == t1 || ctrl.GetType() == t2 || vsechny)
                {
                    if (dir == Direction.Left) ctrl.Left -= 5;
                    if (dir == Direction.Right) ctrl.Left += 5;
                    if (dir == Direction.Up) ctrl.Top -= 5;
                    if (dir == Direction.Down) ctrl.Top += 5;

                    if (ctrl.Top <= 0) ctrl.Top = 0;
                    if (ctrl.Left <= 0) ctrl.Left = 0;
                    if (ctrl.Top >= ClientSize.Height - ctrl.Height) ctrl.Top = ClientSize.Height - ctrl.Height;
                    if (ctrl.Left >= ClientSize.Width - ctrl.Width) ctrl.Left = ClientSize.Width - ctrl.Width;
                }
            }
        }

        private void Prkvy_MouseDown(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;

            if (e.Button == MouseButtons.Left) Text = $"Kliknuto na typ {c.GetType().Name} <> RGB({c.BackColor.R},{c.BackColor.G},{c.BackColor.B}), Pozice [{c.Left},{c.Top}]";
            if (e.Button == MouseButtons.Middle) Text = $"Kliknuto na typ {c.GetType().Name}";
            if (e.Button == MouseButtons.Right) Text = $"Pozice [{c.Left},{c.Top}]";
        }

        private void Prvky_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Alt | Keys.K)) Close();
            if (e.KeyData == Keys.P) Pregenerovat();

            // POSUN Klávesy
            Type t1 = null;
            Type t2 = null;
            bool vse = false;
            if (e.Modifiers == Keys.Shift) t1 = typeof(Button);
            if (e.Modifiers == Keys.Control) t1 = typeof(RadioButton);
            if (e.Modifiers == Keys.Alt) t1 = typeof(CheckBox);  
            
            // POSUN Složitější klávesy  
            if (e.Modifiers == (Keys.Shift | Keys.Control))
            {
                t1 = typeof(Button);
                t2 = typeof(RadioButton);
            }

            if (e.Modifiers == (Keys.Shift | Keys.Alt))
            {
                t1 = typeof(Button);
                t2 = typeof(CheckBox);
            }

            if (e.Modifiers == (Keys.Control | Keys.Alt))
            {
                t1 = typeof(RadioButton);
                t2 = typeof(CheckBox);
            }

            if (e.Modifiers == (Keys.Shift | Keys.Control | Keys.Alt))
            {
                t1 = typeof(Label);
                t2 = typeof(TextBox);
            }

            if (e.Modifiers == 0) vse = true;

            // POSUN
            if (e.KeyCode == Keys.PageUp) Posun(Direction.Up, t1, t2, vse);
            if (e.KeyCode == Keys.PageDown) Posun(Direction.Down, t1, t2, vse);

            if (e.KeyCode == Keys.Home) Posun(Direction.Left, t1, t2, vse);
            if (e.KeyCode == Keys.End) Posun(Direction.Right, t1, t2, vse);
        }
    }
}