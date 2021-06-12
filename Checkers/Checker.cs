using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Checkers
{
    public class Checker
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsEnemy { get; set; }
        public bool IsRankedUp { get; set; }
        public bool Selected { get; set; }

        public Ellipse E { get; private set; }

        public Checker(int X, int Y, double size, bool isEnemy = false)
        {
            this.E = new Ellipse();
            this.X = X;
            this.Y = Y;
            this.IsEnemy = isEnemy;
            E.Width = size;
            E.Height = size;
            E.Fill = isEnemy ? Brushes.Red : Brushes.Black;

            IsRankedUp = false;
        }

        public void SetGridPosition()
        {
            Grid.SetColumn(E, X);
            Grid.SetRow(E, Y);
        }

        public void RankUp()
        {
            IsRankedUp = true;
            E.Stroke = E.Fill;
            E.Fill = Brushes.White;
            E.StrokeThickness = E.Width / 4;
        }
    }
}
