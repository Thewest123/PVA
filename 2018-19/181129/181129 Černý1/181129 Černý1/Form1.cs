using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181129_Černý1
{
    public partial class Form1 : Form
    {
        private string _loadStatus;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            if (MessageBox.Show("Chcete seřadit tlačítka?", _loadStatus, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) SortButtons();
            if (MessageBox.Show("Chcete spustit timer?", _loadStatus, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) timer.Start();
        }

        private void button_Click(object sender, EventArgs e) => timer.Enabled = !timer.Enabled;

        private Random r = new Random();
        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.Size = new Size(r.Next(25, 150), r.Next(25, 150));
                c.Location = new Point(r.Next(0, ClientSize.Width - c.Width + 1), r.Next(0, ClientSize.Width - c.Width + 1));
                c.BackColor = Color.FromArgb(r.Next(0, 255 + 1), r.Next(0, 255 + 1), r.Next(0, 255 + 1));
                c.ForeColor = Color.FromArgb(r.Next(0, 255 + 1), r.Next(0, 255 + 1), r.Next(0, 255 + 1));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => SaveData();

        public void SaveData()
        {
            List<string> line = new List<string>();
            foreach (Control c in Controls)
            {
                line.Add($"{c.Left}:{c.Top}:{c.Width}:{c.Height}:{c.BackColor.R}:{c.BackColor.G}:{c.BackColor.B}:{c.ForeColor.R}:{c.ForeColor.G}:{c.ForeColor.B}");
            }
            File.WriteAllLines("t.txt", line);
        }

        public void LoadData()
        {
            try
            {
                string[] line = File.ReadAllLines("t.txt");
                for (int i = 0; i < line.Length; i++)
                {
                    string[] data = line[i].Split(':');

                    Controls[i].Location = new Point(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]));
                    Controls[i].Size = new Size(Convert.ToInt32(data[2]), Convert.ToInt32(data[3]));
                    Controls[i].BackColor = Color.FromArgb(Convert.ToInt32(data[4]), Convert.ToInt32(data[5]), Convert.ToInt32(data[6]));
                    Controls[i].ForeColor = Color.FromArgb(Convert.ToInt32(data[7]), Convert.ToInt32(data[8]), Convert.ToInt32(data[9]));
                }

                _loadStatus = "OK";
            }
            catch (Exception e)
            {
                _loadStatus = e.Message;
            }
        }

        private void SortButtons()
        {
            int indent = 25;
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Size = new Size(indent, indent);
                Controls[i].Left = indent * i;
                Controls[i].Top = indent * i;
            }

            ClientSize = new Size(Controls.Count * indent, Controls.Count * indent);
        }
    }
}
