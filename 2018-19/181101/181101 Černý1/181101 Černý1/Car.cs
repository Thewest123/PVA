using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181101_Černý1
{
    public class Car
    {
        public Car(Label carLabel, Label roundsLabel)
        {
            CarLabel = carLabel;
            RoundsLabel = roundsLabel;
        }

        public void ResetCar(string carLabelText)
        {
            CarLabel.Text = carLabelText;
            CarLabel.BackColor = Color.White;

            CarLabel.Left = 20;
            CarLabel.Top = 0;

            RoundsLabel.Left = 0;
            RoundsLabel.Top = 0;

            IsReady = false;
            Direction = Form1.Direction.Right;
            RoundsPassed = 0;
            RoundsLabel.Text = RoundsPassed.ToString();
        }

        public Label CarLabel;
        public Label RoundsLabel;
        public bool IsReady;
        public Form1.Direction Direction;
        public int RoundsPassed;
    }
}
