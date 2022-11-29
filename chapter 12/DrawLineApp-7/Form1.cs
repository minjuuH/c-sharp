using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawLineApp_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 곡선 그리기
            Graphics g = CreateGraphics();
            Point[] pts = { new Point(40, 100), new Point(50, 60),
                new Point(60, 50), new Point(70, 60),
                new Point(80, 100), new Point(90, 140),
                new Point(100, 150), new Point(110, 140),
                new Point(120, 100), new Point(130, 60),
                new Point(140, 50), new Point(150, 60),
                new Point(160, 100), new Point(170, 140),
                new Point(180, 150), new Point(190, 140),
                new Point(200, 100) };
            g.DrawCurve(Pens.Red, pts);
        }
    }
}
