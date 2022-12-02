using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string o_1 = "Второе число больше";
            string o_2 = "Первое число больше";
            string o_3 = "Числа равны";
            string x = textBox1.Text;
            int x_1 = Convert.ToInt32(x);
            int first = x_1 / 100;
            int second = (x_1 % 100) / 10;
            if (first < second)
                textBox2.Text = o_1;
            if (first > second)
                textBox2.Text = o_2;
            if (first == second)
                textBox2.Text = o_3;
        }
    }
}
