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
using System.Windows.Media.Animation;
namespace Template1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation da = new DoubleAnimation(360, 0, new Duration(TimeSpan.FromSeconds(9)));
            RotateTransform rt = new RotateTransform();
           
           
            RotateImg3.RenderTransform = rt;
            RotateImg3.RenderTransformOrigin = new Point(0.5, 0.5);
            RotateImg2.RenderTransform = rt;
            RotateImg2.RenderTransformOrigin = new Point(0.5, 0.5);
            RotateImg4.RenderTransform = rt;
            RotateImg4.RenderTransformOrigin = new Point(0.5, 0.5);
            RotateImg5.RenderTransform = rt;
            RotateImg5.RenderTransformOrigin = new Point(0.5, 0.5);
            da.RepeatBehavior = RepeatBehavior.Forever;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
        }

       

        private void exit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menu1_enter(object sender, MouseEventArgs e)
        {
            
            menu1.Foreground = Brushes.Black;
        }

        private void menu1_leave(object sender, MouseEventArgs e)
        {
            menu1.Foreground = Brushes.White;
        }
    }
}
