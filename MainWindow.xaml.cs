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

namespace _307699_Drawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Brush b;
        public MainWindow()
        {
            InitializeComponent();
        }
    
        private void setColour_Click(object sender, RoutedEventArgs e)
        {
            pickColor p = new pickColor();
            p.ShowDialog();
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            DrawingHelper DH = new DrawingHelper(canvas, 10, 10, 100, 100, b, "Rectangle");
        }
    }
    public class DrawingHelper
    {
        private Canvas c;
        private Rectangle r;
        public DrawingHelper(Canvas C, double X, double Y, double W, double H, Brush color, string Shape)
        {
            r = new Rectangle();
            r.Height = H;
            r.Width = W;

            r.Fill = color;
            c = C;

            c.Children.Add(r);
            
            Canvas.SetTop(r, Y);
            Canvas.SetLeft(r, X);

        }
    }
}
