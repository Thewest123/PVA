using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181025_Černý1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MinimumSize = Size;

            tbWidth.Minimum = 0;
            tbWidth.Maximum = pictureBox.Width;
            tbWidth.Value = tbWidth.Maximum;

            tbHeight.Minimum = -pictureBox.Height;
            tbHeight.Maximum = 0;
            tbHeight.Value = tbHeight.Minimum;
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Obrázkové typy|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff|Všechny soubory|*.*",
                Title = "Vyberte obrázek"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = null;
                pictureBox.BackColor = colorDialog.Color;
            }
        }

        private void tbWidth_Scroll(object sender, EventArgs e)
        {
            pictureBox.Width = tbWidth.Value;
        }

        private void tbHeight_Scroll(object sender, EventArgs e)
        {
            pictureBox.Height = Math.Abs(tbHeight.Value);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            tbWidth.Maximum = tbWidth.Width;
            tbWidth.Value = pictureBox.Width;

            tbHeight.Minimum = -tbHeight.Height;
            tbHeight.Value = -pictureBox.Height;
        }
    }
}
