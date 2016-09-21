using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadEquationWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBoxA.Text); float b = float.Parse(textBoxB.Text); float c = float.Parse(textBoxC.Text);
            float D = b * b - 4 * a * c;
            textBoxD.Text = D.ToString();
            float x1, x2;
            if (D>0)
            {
                x1 = (float) (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (float) (-b + Math.Sqrt(D)) / (2 * a);
                textBoxX1.Visible = true; textBoxX2.Visible = true;
                labelX1.Visible = true; labelX2.Visible = true;
                textBoxX1.Text = x1.ToString(); textBoxX2.Text = x2.ToString();
            }
            else if (D==0)
                {
                    x1 = (-b) / (2 * a);
                    textBoxX1.Visible = true; textBoxX2.Visible = false;
                    labelX1.Visible = true; labelX2.Visible = false;
                    textBoxX1.Text = x1.ToString();
                }
                else
                {
                    textBoxX1.Visible = false; textBoxX2.Visible = false;
                    labelX1.Visible = false; labelX2.Visible = false;
                    MessageBox.Show("Solution does not exist");
                }

        }
    }
}
