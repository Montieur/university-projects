using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Checkers
{
    public class Square
    {
        public Square(int X, int Y, bool passive)
        {
            this.X = X;
            this.Y = Y;
            area = new Rectangle() { Fill = passive ? Brushes.White : Brushes.Green };
            selection = new Border() { BorderBrush = Brushes.Gold, BorderThickness = new Thickness(0) };
            selection.Child = area;
            Grid.SetZIndex(selection, 0);
            Grid.SetColumn(selection, X);
            Grid.SetRow(selection, Y);
        }

        public void Highlight()
        {
            selection.BorderThickness = highlighted ? new Thickness(0) : new Thickness(4);
            highlighted = !highlighted;
        }

        public bool highlighted = false;
        public int X { get; }
        public int Y { get; }
        public Rectangle area { get; }
        public Border selection { get; }
        public Checker checker { get; set; }

    }
}
