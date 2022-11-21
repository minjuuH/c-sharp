using System;
using System.Drawing;
using System.Windows.Forms;

namespace ch12_01 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            //Random.Next() : 0 ~ 2^(32-1) 사이의 난수 값 생성
            //Random.Next(int1=0, int2) : int1 ~ int2 사이의 난수 값 생성

            g.FillRectangle(new SolidBrush(c), e.ClipRectangle);
        }
    }
}
