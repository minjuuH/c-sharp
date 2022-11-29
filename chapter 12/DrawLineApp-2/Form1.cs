using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawLineApp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 선 그리기
            Graphics g = CreateGraphics();
            Point[] pts = { new Point(40, 40), new Point(180, 40),
                new Point(180, 180), new Point(40, 180),
                new Point(40, 60), new Point(160, 60),
                new Point(160, 160), new Point(60, 160),
                new Point(60, 80), new Point(140, 80),
                new Point(140, 140), new Point(80, 140),
                new Point(80, 100), new Point(120, 100),
                new Point(120, 120), new Point(100, 120) };
            g.DrawLines(new Pen(Color.BlueViolet), pts);
        }
    }
}
