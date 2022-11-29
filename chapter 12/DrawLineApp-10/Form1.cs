using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawLineApp_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 베지어 곡선 그리기(2)
            Graphics g = CreateGraphics();
            Point[] pts = { new Point(30, 30),      //시작점
                new Point(60, 30), new Point(30, 60),       //제어점
                new Point(60, 60),      //끝점 및 시작점
                new Point(90, 60), new Point(60, 90),       //제어점
                new Point(90, 90),      //끝점 및 시작점
                new Point(120, 90), new Point(90, 120),     //제어점
                new Point(120, 120),    //끝점 및 시작점
                new Point(150, 120), new Point(120, 150),   //제어점
                new Point(150, 150),    //끝점 및 시작점
                };
            g.DrawBeziers(Pens.DeepPink, pts);
        }
    }
}
