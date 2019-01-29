using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190124d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (MessageBoxButtons i in Enum.GetValues(typeof(MessageBoxButtons)))
            {
                lbMessageBoxButtons.Items.Add(i);
            }
            lbMessageBoxButtons.SelectedIndex = 0;
            foreach (MessageBoxIcon i in Enum.GetValues(typeof(MessageBoxIcon)))
            {
                lbMessageBoxIcon.Items.Add(i);
            }
            lbMessageBoxIcon.SelectedIndex = 0;
            foreach (MessageBoxDefaultButton i in Enum.GetValues(typeof(MessageBoxDefaultButton)))
            {
                lbMessageBoxDefaultButton.Items.Add(i);
            }
            lbMessageBoxDefaultButton.SelectedIndex = 0;
        }
        #region Instanční
        Hlášky no = new Hlášky();
        #region Instanční bez návratu
        private void butVoidInst1p_Click(object sender, EventArgs e)
        {
            no.VypišHláškuInst(tbTělo.Text);
        }

        private void butVoidInst2p_Click(object sender, EventArgs e)
        {
            no.VypišHláškuInst(tbTělo.Text, tbTitulek.Text);
        }

        private void butVoidInst3p_Click(object sender, EventArgs e)
        {
            no.VypišHláškuInst(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem);
        }

        private void butVoidInst4p_Click(object sender, EventArgs e)
        {
            no.VypišHláškuInst(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem, (MessageBoxIcon)lbMessageBoxIcon.SelectedItem);
        }

        private void butVoidInst5p_Click(object sender, EventArgs e)
        {
            no.VypišHláškuInst(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem, (MessageBoxIcon)lbMessageBoxIcon.SelectedItem, (MessageBoxDefaultButton)lbMessageBoxDefaultButton.SelectedItem);
        }

        private void butVoidInst2_0_1p_Click(object sender, EventArgs e)
        {
            no.VypišHláškuInst(tbTělo.Text, tbTitulek.Text, mbi: (MessageBoxIcon)lbMessageBoxIcon.SelectedItem);
        }

        private void butVoidInst3_0_1p_Click(object sender, EventArgs e)
        {
            no.VypišHláškuInst(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem, mbdb: (MessageBoxDefaultButton)lbMessageBoxDefaultButton.SelectedItem);
        }
        #endregion
        #region Instanční s návratem
        private void butStringInst1p_Click(object sender, EventArgs e)
        {
            tbNávratI.Text = no.VypišHláškuInstString(tbTělo.Text);
        }

        private void butStringInst2p_Click(object sender, EventArgs e)
        {
            tbNávratI.Text = no.VypišHláškuInstString(tbTělo.Text, tbTitulek.Text);
        }

        private void butStringInst3p_Click(object sender, EventArgs e)
        {
            tbNávratI.Text = no.VypišHláškuInstString(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem);
        }

        private void butStringInst4p_Click(object sender, EventArgs e)
        {
            tbNávratI.Text = no.VypišHláškuInstString(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem, (MessageBoxIcon)lbMessageBoxIcon.SelectedItem);
        }

        private void butStringInst5p_Click(object sender, EventArgs e)
        {
            tbNávratI.Text = no.VypišHláškuInstString(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem, (MessageBoxIcon)lbMessageBoxIcon.SelectedItem, (MessageBoxDefaultButton)lbMessageBoxDefaultButton.SelectedItem);
        }

        private void butStringInst2_0_1p_Click(object sender, EventArgs e)
        {
            tbNávratI.Text = no.VypišHláškuInstString(tbTělo.Text, tbTitulek.Text, mbi: (MessageBoxIcon)lbMessageBoxIcon.SelectedItem);
        }

        private void butStringInst3_0_1p_Click(object sender, EventArgs e)
        {
            tbNávratI.Text = no.VypišHláškuInstString(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem, mbdb: (MessageBoxDefaultButton)lbMessageBoxDefaultButton.SelectedItem);
        }
        #endregion
        #endregion
        #region Statické
        #region Statické bez návratu
        private void butVoidStat1p_Click(object sender, EventArgs e)
        {
            Hlášky.VypišHlášku(tbTělo.Text);
        }

        private void butVoidStat2p_Click(object sender, EventArgs e)
        {
            Hlášky.VypišHlášku(tbTělo.Text, tbTitulek.Text);
        }

        private void butVoidStat3p_Click(object sender, EventArgs e)
        {
            Hlášky.VypišHlášku(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem);
        }

        private void butVoidStat4p_Click(object sender, EventArgs e)
        {
            Hlášky.VypišHlášku(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem, (MessageBoxIcon)lbMessageBoxIcon.SelectedItem);
        }

        private void butVoidStat5p_Click(object sender, EventArgs e)
        {
            Hlášky.VypišHlášku(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem, (MessageBoxIcon)lbMessageBoxIcon.SelectedItem, (MessageBoxDefaultButton)lbMessageBoxDefaultButton.SelectedItem);
        }

        private void butVoidStat2_0_1p_Click(object sender, EventArgs e)
        {
            Hlášky.VypišHlášku(tbTělo.Text, tbTitulek.Text, mbi: (MessageBoxIcon)lbMessageBoxIcon.SelectedItem);
        }

        private void butVoidStat3_0_1p_Click(object sender, EventArgs e)
        {
            Hlášky.VypišHlášku(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem, mbdb: (MessageBoxDefaultButton)lbMessageBoxDefaultButton.SelectedItem);
        }
        #endregion
        #region Statické s návratem
        private void butStringStat1p_Click(object sender, EventArgs e)
        {
            tbNávratS.Text = Hlášky.VypišHláškuString(tbTělo.Text);
        }

        private void butStringStat2p_Click(object sender, EventArgs e)
        {
            tbNávratS.Text = Hlášky.VypišHláškuString(tbTělo.Text, tbTitulek.Text);
        }

        private void butStringStat3p_Click(object sender, EventArgs e)
        {
            tbNávratS.Text = Hlášky.VypišHláškuString(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem);
        }

        private void butStringStat4p_Click(object sender, EventArgs e)
        {
            tbNávratS.Text = Hlášky.VypišHláškuString(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem, (MessageBoxIcon)lbMessageBoxIcon.SelectedItem);
        }

        private void butStringStat5p_Click(object sender, EventArgs e)
        {
            tbNávratS.Text = Hlášky.VypišHláškuString(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem, (MessageBoxIcon)lbMessageBoxIcon.SelectedItem, (MessageBoxDefaultButton)lbMessageBoxDefaultButton.SelectedItem);
        }

        private void butStringStat2_0_1p_Click(object sender, EventArgs e)
        {
            tbNávratS.Text = Hlášky.VypišHláškuString(tbTělo.Text, tbTitulek.Text, mbi: (MessageBoxIcon)lbMessageBoxIcon.SelectedItem);
        }

        private void butStringStat3_0_1p_Click(object sender, EventArgs e)
        {
            tbNávratS.Text = Hlášky.VypišHláškuString(tbTělo.Text, tbTitulek.Text, (MessageBoxButtons)lbMessageBoxButtons.SelectedItem, mbdb: (MessageBoxDefaultButton)lbMessageBoxDefaultButton.SelectedItem);
        }
        #endregion
        #endregion
    }
}