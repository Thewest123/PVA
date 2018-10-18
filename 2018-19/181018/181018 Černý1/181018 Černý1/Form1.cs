using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181018_Černý1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MinimumSize = Size;

            //Nastavení na neproporcionální (Monospace) písmo
            rtbOut.Font = new Font(FontFamily.GenericMonospace, rtbOut.Font.Size);
        }

        private void btnVypis_Click(object sender, EventArgs e)
        {
            rtbOut.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= numPocet.Value; j++)
                {
                    rtbOut.Text += $"{numNasobenec.Value,4}x{i + 10*j,-2} = {numNasobenec.Value*(i + 10*j),-4} {(j != numPocet.Value ? "│" : "")}";
                }
                rtbOut.Text += "\n";
            }

            //Přizpůsobení velikosti okna na text
            Width = (Width - rtbOut.Width) + TextRenderer.MeasureText(rtbOut.Text, rtbOut.Font).Width + 10;
        }
    }
}
