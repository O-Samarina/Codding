﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3(int kab, int korp)
        {
            InitializeComponent();
            switch (korp)// переключение корпусов
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
            }
        }

        private void buttonZoomIn_Click(object sender, EventArgs e) // изменение масштаба карты
        {
            panel1.Scale(new SizeF(1.1f, 1.1f));
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            panel1.Scale(new SizeF(0.9f, 0.9f));
        }
    }
}
