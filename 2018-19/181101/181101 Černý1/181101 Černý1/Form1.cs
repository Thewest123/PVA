using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
                cars[i].ResetCar($"Z{i + 1}");
            }

            //Změna velikosti okna
            ChangeSizeToFitCars();

            tbRounds.Enabled = true;
            numCarsNumber.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var rand = new Random();

            foreach (var car in cars)
            {
                //Otáčení směru pohybu autíček a přidávání kol
                if (car.CarLabel.Left > panel1.Width - car.CarLabel.Width)
                {
                    car.CarDirection = Car.Direction.Left;
                    car.CarLabel.Left = panel1.Width - car.CarLabel.Width;
                    car.RoundsLabel.Text = (++car.RoundsPassed).ToString();
                }

                if (car.CarLabel.Left < 0)
                {
                    car.CarDirection = Car.Direction.Right;
                    car.CarLabel.Left = 0;
                    car.RoundsLabel.Text = (++car.RoundsPassed).ToString();
                }

                //Ověření výherce
                if (car.RoundsPassed == tbRounds.Value)
                {
                    timer.Stop();
                    MessageBox.Show($"Vítězem je autíčko {car.CarLabel.Text} s barvou {car.CarLabel.BackColor}", $"Vítěz {car.CarLabel.Text}");
                    Reset();
                    break;
                }

                //Pohyb autíček
                if (car.CarDirection == Car.Direction.Right) car.CarLabel.Left += rand.Next(1, tbSpeed.Value + 1);
                else car.CarLabel.Left -= rand.Next(1, tbSpeed.Value + 1);
            }
        }

        private void numCarsNumber_ValueChanged(object sender, EventArgs e)
        {
            GenerateCars();
            Reset();
        }

        private void btnStartAll_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            foreach (var car in cars)
            {
                Color c = Color.FromArgb(rand.Next(50, 256), rand.Next(50, 256), rand.Next(50, 256));
                car.CarLabel.Text = RandomString(c.GetHashCode(), 4);
                car.CarLabel.BackColor = c;
                car.CarLabel.Left = 0;
                car.IsReady = true;
            }

            Start();
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
    }
}
