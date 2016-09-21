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

namespace Task4WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(textBox.Text); double y = double.Parse(textBox1.Text); double z = double.Parse(textBox2.Text);
            double f = (Math.Pow((y + Math.Pow(x - 1, 1.0 / 3)), 1.0 / 4)) / (Math.Abs(x - y) * (Math.Sin(z)* Math.Sin(z) + Math.Tan(z)));
            label2.Content = "f = " + f.ToString();
        }
    }
}
