﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kab = int.Parse(textBox2.Text);
            int korp = int.Parse(textBox2.Text);

            if (kab < 200)
            {
                    Form form2 = new Form2();
                    form2.ShowDialog();
            }

            else if (kab < 300)
            {
                    Form form2 = new Form2();
                    form2.ShowDialog();
            }
            else if (kab < 400)
            {
                    Form form2 = new Form2();
                    form2.ShowDialog();
            }

            else if (kab < 500)
            {
                    Form form2 = new Form2();
                    form2.ShowDialog();
            }

            else if (kab < 600)
            {
                    Form form2 = new Form2();
                    form2.ShowDialog();
            }

        }
    }
}