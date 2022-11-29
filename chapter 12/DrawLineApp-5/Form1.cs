using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawLineApp_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 타원 그리기 - 사각형에 내접하는 타원 그리기
            Graphics g = CreateGraphics();
            Rectangle r = new Rectangle(50, 50, 150, 100);
            g.FillEllipse(Brushes.Cyan, r);
            g.DrawEllipse(Pens.Black, r);
        }
    }
}
