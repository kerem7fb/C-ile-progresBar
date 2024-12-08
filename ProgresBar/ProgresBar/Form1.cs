﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgresBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int yuzde;
                yuzde = Convert.ToByte(textBox1.Text);
                progressBar1.Value = yuzde;
            }
            catch 
            {
                MessageBox.Show("0-100 arası sayı giriniz");
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            progressBar1.Value = 0;
        }
    }
}
