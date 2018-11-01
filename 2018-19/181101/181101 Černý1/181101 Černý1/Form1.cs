using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181101_Černý1
{
    public partial class Form1 : Form
    {
        private List<bool> carReady = new List<bool> {false, false, false, false};
        private List<Label> cars;

        private List<Direction> carDirections = new List<Direction> {Direction.Right, Direction.Right, Direction.Right, Direction.Right};

        private List<Label> roundsLabels;
        private List<int> roundsNums = new List<int> {0, 0, 0, 0};


        public Form1()
        {
            InitializeComponent();

            cars = new List<Label> {lblCar1, lblCar2, lblCar3, lblCar4};
            roundsLabels = new List<Label> {lblRounds1, lblRounds2, lblRounds3, lblRounds4};

            Reset();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var rand = new Random();

            for (int i = 0; i < cars.Count; i++)
            {
                //Otáčení směru pohybu autíček a přidávání kol
                if (cars[i].Left > panel1.Width - cars[i].Width)
                {
                    carDirections[i] = Direction.Left;
                    cars[i].Left = panel1.Width - cars[i].Width;
                    roundsLabels[i].Text = (++roundsNums[i]).ToString();
                }

                if (cars[i].Left < 0)
                {
                    carDirections[i] = Direction.Right;
                    cars[i].Left = 0;
                    roundsLabels[i].Text = (++roundsNums[i]).ToString();
                }

                //Ověření výherce
                if (roundsNums[i] == tbRounds.Value)
                {
                    timer.Stop();
                    MessageBox.Show($"Vítězem je autíčko {cars[i].Text} s barvou {cars[i].BackColor}", $"Vítěz {cars[i].Text}");
                    Reset();
                    break;
                }

                //Pohyb autíček
                if (carDirections[i] == Direction.Right) cars[i].Left += rand.Next(1, tbSpeed.Value + 1);
                else cars[i].Left -= rand.Next(1, tbSpeed.Value + 1);
            }
        }

        private void SetCar(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lbl.Left = 0;
                lbl.BackColor = colorDialog.Color;
                lbl.Text = RandomString(colorDialog.Color.GetHashCode(), 4);

                //Nastavení autíček na připraveno
                for (int i = 0; i < cars.Count; i++)
                {
                    if (lbl == cars[i]) carReady[i] = true;
                }
            }

            Start();
        }

        private void Start()
        {
            if (carReady[0] && carReady[1] && carReady[2] && carReady[3])
            {
                tbRounds.Enabled = false;
                timer.Start();
            }
        }

        private void Reset()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].BackColor = Color.White;
                cars[i].Text = $"Z{i+1}";
                cars[i].Left = 20;

                carDirections[i] = Direction.Right;
                carReady[i] = false;
                roundsNums[i] = 0;
                roundsLabels[i].Text = roundsNums[i].ToString();

                tbRounds.Enabled = true;
            }
        }

        enum Direction
        {
            Left,
            Right
        }

        private string RandomString(int seed, int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] stringChars = new char[length];
            var rand = new Random(seed);

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[rand.Next(chars.Length)];
            }

            return new String(stringChars);
        }
    }
}
