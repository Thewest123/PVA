using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181108_Černý
{
    public partial class HighscoreTable : Form
    {
        public static List<Score> Table = new List<Score>();

        public HighscoreTable()
        {
            InitializeComponent();
            rtbOutput.Font = new Font(FontFamily.GenericMonospace, rtbOutput.Font.Size);
        }

        public static void AddToTable(DateTime date, int clicks, int sumPoints)
        {
            Table.Add(new Score(date, clicks, sumPoints));
        }

        public void UpdateTable()
        {
            Table = Table.OrderBy(x => x.Weight).ToList();

            rtbOutput.Clear();
            rtbOutput.Text += $"#  │ {"Datum",-10} │ {"Počet her",-10} │ {"Body",-6} │ {"Průměr",-6}\n";
            rtbOutput.Text += $"───┼────────────┼────────────┼────────┼───────\n";
            int index = 0;
            foreach (var score in Table)
            {
                rtbOutput.Text += $"{++index:00} │ {score.Date,-10:d} │ {score.Clicks,-10} │ {score.SumPoints,-6} │ {score.Weight,-6:f2}\n";
                Debug.WriteLine($"Do highscore přidáno {score.Date:d} │ {score.Clicks} │ {score.SumPoints} │ {score.Weight:f2}");
            }
        }

        private void HighscoreTable_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
