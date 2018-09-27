using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180927_Černý1
{
    public partial class Form1 : Form
    {
        //Výchozí pozice tlačítek
        static List<Button> _buttonyList       = new List<Button>();
        static List<Point>  _vychoziPoziceList = new List<Point>();

        static int _vychoziVelikost;

        public Form1()
        {
            InitializeComponent();

            //Výchozí velikost - šířka prostředního tlačítka
            _vychoziVelikost = btn5.Size.Width;

            //Uložení všech tlačítek do seznamu
            _buttonyList = new List<Button> {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9};

            //Uložení výchozí pozice každého tlačítka
            foreach (var button in _buttonyList)
            {
                _vychoziPoziceList.Add(new Point(button.Location.X, button.Location.Y));
            }
        }

        // ----- POSUNOVACÍ PROSTŘEDNÍ TLAČÍTKA ----- //
        // Jako číselník mobilu:
        // 1-2-3
        // 4-5-6
        // 7-8-9

        private void btn1_Click(object sender, EventArgs e)
        {
            PosunTlacitko(Smer.Nahoru, btn1);
            PosunTlacitko(Smer.Vlevo, btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            PosunTlacitko(Smer.Nahoru, btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            PosunTlacitko(Smer.Nahoru, btn3);
            PosunTlacitko(Smer.Vpravo, btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            PosunTlacitko(Smer.Vlevo, btn4);
        }

        //Prostřední tlačítko - Reset pozic a velikostí
        private void btn5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _buttonyList.Count; i++)
            {
                _buttonyList[i].Location = _vychoziPoziceList[i];
                _buttonyList[i].Size = new Size(_vychoziVelikost, _vychoziVelikost);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            PosunTlacitko(Smer.Vpravo, btn6); 
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            PosunTlacitko(Smer.Dolu, btn7);
            PosunTlacitko(Smer.Vlevo, btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            PosunTlacitko(Smer.Dolu, btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            PosunTlacitko(Smer.Dolu, btn9);
            PosunTlacitko(Smer.Vpravo, btn9);
        }

        // ----- ZVĚTŠOVACÍ OKRAJNÍ TLAČÍTKA ----- //
        private void btnZvetsi1_Click(object sender, EventArgs e)
        {
            ZvetsiTlacitka(Smer.Nahoru, btn1, btn2, btn3);
            ZvetsiTlacitka(Smer.Vlevo, btn1, btn4, btn7);
        }

        private void btnZvetsi2_Click(object sender, EventArgs e)
        {
            ZvetsiTlacitka(Smer.Nahoru, btn1, btn2, btn3);
        }

        private void btnZvetsi3_Click(object sender, EventArgs e)
        {
            ZvetsiTlacitka(Smer.Nahoru, btn1, btn2, btn3);
            ZvetsiTlacitka(Smer.Vpravo, btn3, btn6, btn9);
        }

        private void btnZvetsi4_Click(object sender, EventArgs e)
        {
            ZvetsiTlacitka(Smer.Vlevo, btn1, btn4, btn7);
        }

        private void btnZvetsi6_Click(object sender, EventArgs e)
        {
            ZvetsiTlacitka(Smer.Vpravo, btn3, btn6, btn9);
        }

        private void btnZvetsi7_Click(object sender, EventArgs e)
        {
            ZvetsiTlacitka(Smer.Vlevo, btn1, btn4, btn7);
            ZvetsiTlacitka(Smer.Dolu, btn7, btn8, btn9);
        }

        private void btnZvetsi8_Click(object sender, EventArgs e)
        {
            ZvetsiTlacitka(Smer.Dolu, btn7, btn8, btn9);
        }

        private void btnZvetsi9_Click(object sender, EventArgs e)
        {
            ZvetsiTlacitka(Smer.Vpravo, btn3, btn6, btn9);
            ZvetsiTlacitka(Smer.Dolu, btn7, btn8, btn9);
        }

        // ----- SMĚRY ----- //
        public enum Smer
        {
            Vlevo,
            Vpravo,
            Nahoru,
            Dolu
        }

        // ----- POSUN TLAČÍTEK ----- //
        public void PosunTlacitko(Smer smer, Button button)
        {
            switch (smer)
            {
                case Smer.Vlevo:
                    button.Left -= _vychoziVelikost;
                    break;
                case Smer.Vpravo:
                    button.Left += _vychoziVelikost;
                    break;
                case Smer.Nahoru:
                    button.Top -= _vychoziVelikost;
                    break;
                case Smer.Dolu:
                    button.Top += _vychoziVelikost;
                    break;
            }
        }

        // ----- ZMĚNA VELIKOSTÍ ----- //
        public void ZvetsiTlacitka(Smer smer, params Button[] buttony)
        {
            foreach (var button in buttony)
            {
                switch (smer)
                {
                    case Smer.Vlevo:
                        button.Width += _vychoziVelikost;
                        button.Left -= _vychoziVelikost;
                        break;
                    case Smer.Vpravo:
                        button.Width += _vychoziVelikost;
                        break;
                    case Smer.Nahoru:
                        button.Height += _vychoziVelikost;
                        button.Top -= _vychoziVelikost;
                        break;
                    case Smer.Dolu:
                        button.Height += _vychoziVelikost;
                        break;
                }
            }
        }
    }
}