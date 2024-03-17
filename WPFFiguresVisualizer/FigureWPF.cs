using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using Rectangle = System.Windows.Shapes.Rectangle;

namespace WPFFiguresVisualizer
{
    public class FigureWPF
    {
        public static Shape Get(string Shape, double hight, double width)
        {
            Shape figure = null;
            double side = 0;
            switch (Shape)
            {
                case "Square":
                    side = width;
                    figure = new Rectangle();
                    figure.Width = side;
                    figure.Height = side;
                    return figure;
                case "Ellipse":
                    figure = new Ellipse();
                    figure.Width = width;
                    figure.Height = hight;
                    return figure;
                case "Rectangle":
                    figure = new Rectangle();
                    figure.Width = width;
                    figure.Height = hight;
                    return figure;
                case "Circle":
                    side = width;
                    figure = new Ellipse();
                    figure.Width = side;
                    figure.Height = side;
                    return figure;

            }
            return figure;
        }
        public static Shape Get(PointCollection points)
        {
            Polygon figure = new Polygon();
            figure.Points = points;
            return figure;
        }
    }
}
