﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLineApp_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 사각형 여러개 그리기
            Graphics g = CreateGraphics();
            Rectangle[] rects = { new Rectangle(40, 40, 40, 100),
                new Rectangle(100, 40, 100, 40),
                new Rectangle(100, 100, 100, 40) };
            g.FillRectangles(Brushes.Blue, rects);
            g.DrawRectangles(Pens.Red, rects);
        }
    }
}
