﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Shell sh = new Shell();
        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string str = textBox1.Text;
            int[] num = sh.Sort(Shell.Parse(str), ref count);
            label3.Text = count.ToString();
            for (int i = 0; i < num.Length; i++)
            {
                textBox2.Text += num[i] + " ";
            }
        }
    }
}
