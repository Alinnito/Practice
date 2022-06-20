using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2
{
    public partial class Form1 : Form
    {
        static int Factorial(int a)
        {
            int z = 1;
            do
            {
                if (a == 0)
                {
                    z = 1;
                }
                else
                {
                    z = a * z;
                    a = a - 1;
                }

            } while (a > 0);
            return z;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            res.Text = "Количество возможных вариантов доставки товара: " + Factorial(n);
        }
    }
}
