using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawLineApp_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 폐곡선(닫힌 곡선) 그리기
            Graphics g = CreateGraphics();
            Point[] pts = { new Point(115, 30), new Point(140, 90),
                new Point(200, 115), new Point(140, 140),
                new Point(115, 200), new Point(90, 140),
                new Point(30, 115), new Point(90, 90) };
            g.FillClosedCurve(Brushes.Yellow, pts);
            g.DrawClosedCurve(Pens.Red, pts);
        }
    }
}
