﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Suma k = new Suma();
        double n1;
        

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(textBox1.Text);

            textBox3.Text = k.Per(n1).ToString();
            textBox2.Text = k.Sur(n1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
    }
}
