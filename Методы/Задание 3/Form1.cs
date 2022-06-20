using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Ostatok(string a, string b)
        {
            double num1 = Convert.ToDouble(a);
            double num2 = Convert.ToDouble(b);
            return (num1 % num2);
        }

        double Stepen(string a, string b)
        {
            double num1 = Convert.ToDouble(a);
            double num2 = Convert.ToDouble(b);
            return Math.Pow(num1, num2);
        }

        string Concat(string a, string b)
        {
            return a + b;
        }

        double Division(string a, string b)
        {
            double num1 = Convert.ToDouble(a);
            double num2 = Convert.ToDouble(b);
            return (num1 / num2);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;

            if (radioButton1.Checked == true)
                textBox3.Text = Ostatok(a, b) + "";
            else if (radioButton2.Checked == true)
                textBox3.Text = Stepen(a, b) + "";
            else if (radioButton3.Checked == true)
                textBox3.Text = Concat(a, b);
            else if (radioButton4.Checked == true)
                textBox3.Text = Division(a, b) + "";
            else
                MessageBox.Show("Выберите действие");

        }
    }
}
