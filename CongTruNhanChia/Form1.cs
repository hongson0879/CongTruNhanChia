﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongTruNhanChia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ketqua = Double.Parse(textBox1.Text) + Double.Parse(textBox2.Text);
            textBox3.Text =  ketqua.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ketqua = Double.Parse(textBox1.Text) - Double.Parse(textBox2.Text);
            textBox3.Text = ketqua.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ketqua = Double.Parse(textBox1.Text) * Double.Parse(textBox2.Text);
            textBox3.Text = ketqua.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double ketqua = Double.Parse(textBox1.Text) / Double.Parse(textBox2.Text);
            textBox3.Text = ketqua.ToString();
        }
    }
}
