using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _181101_Černý2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Oba textové formáty|*.txt;*.rtf|Textové soubory|*.txt|Richtext soubory|*.rtf|Všechny soubory|*.*";

            rtbOut.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialog.FileName, Encoding.Default);

                try
                {
                    rtbOut.Rtf = text;
                }
                catch
                {
                    rtbOut.Text = text;
                }
                
                lblFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Oba textové formáty|*.txt;*.rtf|Textové soubory|*.txt|Richtext soubory|*.rtf|Všechny soubory|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName.EndsWith(".rtf"))
                {
                    File.WriteAllText(saveFileDialog.FileName, rtbOut.Rtf);
                }
                else if(saveFileDialog.FileName.EndsWith(".txt"))
                {
                    File.WriteAllText(saveFileDialog.FileName, rtbOut.Text);
                }
            }
        }
    }
}
