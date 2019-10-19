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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        static int count = 3000;

        public void timer_Tick(object sender, EventArgs e)
        {
            count--;
            lblTime.Content = count;
            if (count < 3000)
            {
                Red.Fill = Brushes.Red;
                Yellow.Fill = Brushes.Gray;
                Green.Fill = Brushes.Gray;
            }
            if (count < 2600)
            {
                Red.Fill = Brushes.Red;
                Yellow.Fill = Brushes.Yellow;
                Green.Fill = Brushes.Gray;
            }
            if (count< 2500)
            {
                Red.Fill = Brushes.Gray;
                Yellow.Fill = Brushes.Gray;
                Green.Fill = Brushes.Lime;
            }

            if (count<2300)
            {
                Red.Fill = Brushes.Gray;
                Yellow.Fill = Brushes.Gray;
                Green.Fill = Brushes.Gray;
            }
            if (count < 2290)
            {
                Red.Fill = Brushes.Gray;
                Yellow.Fill = Brushes.Gray;
                Green.Fill = Brushes.Lime;
            }
            if (count < 2280)
            {
                Red.Fill = Brushes.Gray;
                Yellow.Fill = Brushes.Gray;
                Green.Fill = Brushes.Gray;
            }
            if (count < 2270)
            {
                Red.Fill = Brushes.Gray;
                Yellow.Fill = Brushes.Gray;
                Green.Fill = Brushes.Lime;
            }
            if (count < 2260)
            {
                Red.Fill = Brushes.Gray;
                Yellow.Fill = Brushes.Gray;
                Green.Fill = Brushes.Gray;
            }


            if (count < 2250)
                {
                Red.Fill = Brushes.Gray;
                Yellow.Fill = Brushes.Yellow;
                Green.Fill = Brushes.Gray;
            }
            if (count< 2150)
            {
                count = 3000;
            }
        }
    }
}
