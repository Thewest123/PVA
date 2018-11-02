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
        private List<Car> cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();

            GenerateCars();
            Reset();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var rand = new Random();

            for (int i = 0; i < cars.Count; i++)
            {
                //Otáčení směru pohybu autíček a přidávání kol
                if (cars[i].CarLabel.Left > panel1.Width - cars[i].CarLabel.Width)
                {
                    cars[i].Direction = Direction.Left;
                    cars[i].CarLabel.Left = panel1.Width - cars[i].CarLabel.Width;
                    cars[i].RoundsLabel.Text = (++cars[i].RoundsPassed).ToString();
                }

                if (cars[i].CarLabel.Left < 0)
                {
                    cars[i].Direction = Direction.Right;
                    cars[i].CarLabel.Left = 0;
                    cars[i].RoundsLabel.Text = (++cars[i].RoundsPassed).ToString();
                }

                //Ověření výherce
                if (cars[i].RoundsPassed == tbRounds.Value)
                {
                    timer.Stop();
                    MessageBox.Show($"Vítězem je autíčko {cars[i].CarLabel.Text} s barvou {cars[i].CarLabel.BackColor}", $"Vítěz {cars[i].CarLabel.Text}");
                    Reset();
                    break;
                }

                //Pohyb autíček
                if (cars[i].Direction == Direction.Right) cars[i].CarLabel.Left += rand.Next(1, tbSpeed.Value + 1);
                else cars[i].CarLabel.Left -= rand.Next(1, tbSpeed.Value + 1);
            }
        }

        private void numCarsNumber_ValueChanged(object sender, EventArgs e)
        {
            GenerateCars();
            Reset();
        }

        //Metoda po stisku labelu (autíčka) na připravení na start
        private void SetCar(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                //Nastavení autíček na připraveno
                for (int i = 0; i < cars.Count; i++)
                {
                    if (lbl == cars[i].CarLabel)
                    {
                        cars[i].CarLabel.Text = RandomString(colorDialog.Color.GetHashCode(), 4); ;
                        cars[i].CarLabel.BackColor = colorDialog.Color;
                        cars[i].CarLabel.Left = 0;
                        cars[i].IsReady = true;
                    }
                }
            }

            Start();
        }

        //Start závodu
        private void Start()
        {
            if (cars.All(car => car.IsReady))
            {
                tbRounds.Enabled = false;
                numCarsNumber.Enabled = false;
                timer.Start();
            }
        }

        //Vyvoláno po konci závodu, resetuje vše do původního stavu
        private void Reset()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].ResetCar($"Z{i+1}");
            }

            //Změna velikosti okna
            ChangeSizeToFitCars();

            tbRounds.Enabled = true;
            numCarsNumber.Enabled = true;
        }

        //Vegenerování labelů autíček a kol
        private void GenerateCars()
        {
            //Vyresetování listu autíček a panelů
            cars.Clear();
            panel1.Controls.Clear();
            panel2.Controls.Clear();

            //Přidání autíček
            for (int i = 0; i < numCarsNumber.Value; i++)
            {
                //Label pro autíčko
                Label carLabel = new Label();
                carLabel.AutoSize = true;
                carLabel.Click += SetCar;

                //Label pro kola
                Label roundsLabel = new Label();
                roundsLabel.AutoSize = true;

                //Vytvoření autíčka s labely a přidání do listu
                cars.Add(new Car(carLabel, roundsLabel));

                //Zobrazení prvnků v panelech
                panel1.Controls.Add(carLabel);
                panel2.Controls.Add(roundsLabel);
            }
        }

        //Změna velikostí panelů a okna, aby se do nich vešla všechna autíčka
        private void ChangeSizeToFitCars()
        {
            panel1.Height = 30;
            panel2.Height = 30;
            int top = 0;

            //Pro každé existující autíčko zvětší panely a posune labely autíček
            foreach (var car in cars)
            {
                panel1.Height += 20;
                panel2.Height += 20;

                car.CarLabel.Top += (top += 20);
                car.RoundsLabel.Top += top;
            }

            //Nastavení velikosti okna podle velikosti panelu a dalších prvků
            Height = panel1.Height + numCarsNumber.Height + tbSpeed.Height + 70;
        }

        //Generace "náhodného" jména autíčka z abecedy = podle seedu (hash barvy) ==> Vždy stejné pro určitou barvu
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

        //Enum na směr pohybu
        public enum Direction
        {
            Right,
            Left
        }
    }
}
