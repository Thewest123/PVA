using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _181108_Černý.Form1;

namespace _181108_Černý
{
    class ScoreHandler
    {
        /*
         public static void SaveGame()
        {
            if (MessageBox.Show("Chcete uložit skóre?", "Uložit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.WriteAllText("save.txt", $"{clicks}:{points}:{sumPoints}");
            }
        }

        public static void LoadGame()
        {
            if (MessageBox.Show("Chcete načíst skóre?", "Načíst?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!File.Exists("save.txt")) File.Create("save.txt").Close();

                string[] input = File.ReadAllText("save.txt", Encoding.Default).Split(':');

                try
                {
                    clicks = Convert.ToInt32(input[0]);
                    points = Convert.ToInt32(input[1]);
                    sumPoints = Convert.ToInt32(input[2]);
                }
                catch
                {
                    clicks = 0;
                    points = 0;
                    sumPoints = 0;
                }
            }
        }
        */

        public static void SaveHighscore()
        {
            File.AppendAllText("highscore.txt", $"{DateTime.Now:d}:{clicks}:{sumPoints}\n");
        }

        public static void LoadHighscore()
        {
            if (!File.Exists("highscore.txt")) File.Create("highscore.txt").Close();

            string[] input = File.ReadAllLines("highscore.txt", Encoding.Default);

            try
            {
                foreach (var line in input)
                {
                    string[] score = line.Split(':');

                    DateTime date = Convert.ToDateTime(score[0]);
                    int clicks = Convert.ToInt32(score[1]);
                    int sumPoints = Convert.ToInt32(score[2]);

                    HighscoreTable.AddToTable(date, clicks, sumPoints);
                }
            }
            catch
            {
                Debug.WriteLine("Nenačteno highscore!");
            }

        }

        public static void ShowHighscoreResult()
        {
            Score currentScore = new Score(DateTime.Now, clicks, sumPoints);
            HighscoreTable.Table.Add(currentScore);
            HighscoreTable.Table = HighscoreTable.Table.OrderBy(x => x.Weight).ToList();
            int index = HighscoreTable.Table.IndexOf(currentScore) + 1;

            MessageBox.Show($"Konec hry! V žebříčku nejlepších jste na {index}. pozici!", "Konec hry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
