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
        public Label CarLabel;
        public Label RoundsLabel;
        public bool IsReady;
        public Direction CarDirection;
        public int RoundsPassed;

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
            CarDirection = Direction.Right;
            RoundsPassed = 0;
            RoundsLabel.Text = RoundsPassed.ToString();
        }

        //Enum na směr pohybu
        public enum Direction
        {
            Right,
            Left
        }
    }
}
