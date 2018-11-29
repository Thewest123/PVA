using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181108_Černý
{
    public partial class Form1 : Form
    {
        public static int clicks;
        public static int points;
        public static int sumPoints;

        private Color[] colors = {Color.Red, Color.Green, Color.Blue, Color.Cyan, Color.Magenta, Color.Yellow,};

        Form highscoreForm = new HighscoreTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTitle();

            ResetGame();
            //ScoreHandler.LoadGame();
            ScoreHandler.LoadHighscore();

            highscoreForm.Show();
            highscoreForm.Location = new Point(Left + ClientSize.Width + 1, Top);
        }

        private void UpdateTitle()
        {
            Text = $"Hra {clicks} | Body {points} | Celkem {sumPoints}";
        }

        private void ResetGame()
        {
            btnPlay.Left = (ClientSize.Width - btnPlay.Width) / 2;
            btnPlay.Top = (ClientSize.Height - btnPlay.Height) / 2;
            btnPlay.Text = "S";
            points = 0;
        }

        private void AddPoints()
        {
            clicks++;
            if (btnPlay.BackColor == Color.Red || btnPlay.BackColor == Color.Green || btnPlay.BackColor == Color.Blue)
            {
                points++;
                sumPoints++;
            }
            else
            {
                points += 2;
                sumPoints += 2;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (timerGame.Enabled)
            {
                AddPoints();
                UpdateTitle();

                if (clicks % 10 == 0)
                {
                    timerGame.Stop();
                    MessageBox.Show($"Konec hry! Počet bodů {points}", "Konec hry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame();
                }

                if (clicks % 5 == 0 && timerGame.Interval > 500)
                {
                    timerGame.Interval -= 100;
                }
            }
            else
            {
                btnPlay.Text = "H";
                timerGame.Start();
            }
        }

        private Random r = new Random();
        private void timerGame_Tick(object sender, EventArgs e)
        {
            int x = r.Next(0, ClientSize.Width - btnPlay.Width);
            int y = r.Next(0, ClientSize.Height - btnPlay.Height);
            btnPlay.Location = new Point(x, y);

            btnPlay.BackColor = colors[r.Next(0, colors.Length)];
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ScoreHandler.SaveGame();
            if (clicks != 0) ScoreHandler.SaveHighscore();
            if (clicks != 0) ScoreHandler.ShowHighscoreResult();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            highscoreForm.Location = new Point(Left + ClientSize.Width + 1, Top);
        }
    }
}
