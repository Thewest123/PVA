using System.Windows.Forms;

namespace _190124d
{
    internal class Hlášky
    {
        public Hlášky()
        {
        }

        public void VypišHláškuInst(string s, string t = "", MessageBoxButtons mbb = MessageBoxButtons.OK, MessageBoxIcon mbi = MessageBoxIcon.None, MessageBoxDefaultButton mbdb = MessageBoxDefaultButton.Button1)
        {
            MessageBox.Show(s, t, mbb, mbi, mbdb);
        }

        public string VypišHláškuInstString(string s, string t = "", MessageBoxButtons mbb = MessageBoxButtons.OK, MessageBoxIcon mbi = MessageBoxIcon.None, MessageBoxDefaultButton mbdb = MessageBoxDefaultButton.Button1)
        {
            return MessageBox.Show(s, t, mbb, mbi, mbdb).ToString();
        }

        public static void VypišHlášku(string s, string t = "", MessageBoxButtons mbb = MessageBoxButtons.OK, MessageBoxIcon mbi = MessageBoxIcon.None, MessageBoxDefaultButton mbdb = MessageBoxDefaultButton.Button1)
        {
            MessageBox.Show(s, t, mbb, mbi, mbdb);
        }

        public static string VypišHláškuString(string s, string t = "", MessageBoxButtons mbb = MessageBoxButtons.OK, MessageBoxIcon mbi = MessageBoxIcon.None, MessageBoxDefaultButton mbdb = MessageBoxDefaultButton.Button1)
        {
            return MessageBox.Show(s, t, mbb, mbi, mbdb).ToString();
        }
    }
}