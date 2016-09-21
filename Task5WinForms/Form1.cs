using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text); double y = double.Parse(textBox2.Text); double z = double.Parse(textBox3.Text);
            double t = (2 * Math.Cos(x - Math.PI / 6)) / (0.5 + Math.Pow(Math.Sin(y), 2)) * (1 + z * z / (3 - z * z / 5));
            label4.Text = "t = " + t.ToString();
        }
    }
}
