using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _181108_Černý
{
    public class Score
    {
        public DateTime Date;
        public int Clicks;
        public int SumPoints;
        public double Weight;

        public Score(DateTime date, int clicks, int sumPoints)
        {
            Date = date;
            Clicks = clicks;
            SumPoints = sumPoints;
            Weight = (double)sumPoints / (double)clicks;
        }
    }
}
