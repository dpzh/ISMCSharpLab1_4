﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4WinForms
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
            double f = (Math.Pow((y + Math.Pow((x - 1), 1.0 / 3)), 1.0 / 4)) / (Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2) + Math.Tan(z)));
            label4.Text = "f = " + f.ToString();
        }
    }
}
