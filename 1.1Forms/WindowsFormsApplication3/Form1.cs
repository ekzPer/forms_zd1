﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
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
            string s = textBox1.Text;
            double s_1 = Convert.ToDouble(s);
            double r = Math.Sqrt(s_1 / Math.PI);
            textBox2.Text = r.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
