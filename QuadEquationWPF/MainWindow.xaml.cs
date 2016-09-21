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

namespace QuadEquationWPF
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
            float a = float.Parse(textBoxA.Text); float b = float.Parse(textBoxB.Text); float c = float.Parse(textBoxC.Text);
            float D = b * b - 4 * a * c;
            textBoxD.Text = D.ToString();
            float x1, x2;
            if (D>0)
            {
                x1 = (float) (-b - Math.Sqrt(D)) / (2 * a); x2 = (float)(-b + Math.Sqrt(D)) / (2 * a);
                labelX1.Visibility = Visibility.Visible; labelX2.Visibility = Visibility.Visible;
                textBoxX1.Visibility = Visibility.Visible; textBoxX2.Visibility = Visibility.Visible;
                textBoxX1.Text = x1.ToString(); textBoxX2.Text = x2.ToString();
            }
            else if (D==0)
            {
                x1 = (-b) / (2 * a);
                labelX1.Visibility = Visibility.Visible; labelX2.Visibility = Visibility.Hidden;
                textBoxX1.Visibility = Visibility.Visible; textBoxX2.Visibility = Visibility.Hidden;
                textBoxX1.Text = x1.ToString();
            }
            else
            {
                labelX1.Visibility = Visibility.Hidden; labelX2.Visibility = Visibility.Hidden;
                textBoxX1.Visibility = Visibility.Hidden; textBoxX2.Visibility = Visibility.Hidden;
                MessageBox.Show("Solution does not exist");
            }
        }
    }
}
