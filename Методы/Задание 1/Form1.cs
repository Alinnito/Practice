using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Info(int pay)
        {
            int credit = Convert.ToInt32(textBox1.Text);
            int sum = credit - pay;
            if (sum <= 0)
            {
                textBox1.Text = 0 + "";
                MessageBox.Show("Долг отсутствует. Переплата: " + (pay - credit));
            }
            else
                textBox1.Text = sum + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pay = Convert.ToInt32(textBox2.Text);
            Info(pay);
        }
    }
}
