using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFFiguresVisualizer
{
    public partial class MainWindow : Window
    {
        private static PointCollection points = new PointCollection();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ShowFigure(object sender, RoutedEventArgs e)
        {
            FigurePlaceholder.Children.Clear();
            Button button = (Button)e.Source;
            string buttonName = button.Name;
            Shape shape;

            if (buttonName == "Triangel")
            {
                points.Add(new Point(100, 0));
                points.Add(new Point(0, 100));
                points.Add(new Point(200, 100));
                shape = FigureWPF.Get(points);
            }
            else
            {
                double heigth = 200;
                double width = 100;
                shape = FigureWPF.Get(buttonName, heigth, width);

            }

            shape.Fill = new SolidColorBrush(Colors.Blue);
            FigurePlaceholder.Children.Add(shape);
            Canvas.SetTop(FigurePlaceholder.Children[0], 117);
            Canvas.SetLeft(FigurePlaceholder.Children[0], 300);
        }
        private void HideCircle(object sender, RoutedEventArgs e)
        {
            FigurePlaceholder.Children.Clear();
        }
    }
}
