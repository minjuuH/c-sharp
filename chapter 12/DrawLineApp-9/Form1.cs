using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawLineApp_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 베지어 곡선 그리기(1)
            //베지어 곡선: 시작점, 제어점 2개, 끝 점을 받아서 곡선을 그림 / 곡선이 제어점을 지나가지 않음
            Graphics g = CreateGraphics();
            g.DrawBezier(Pens.Magenta,
            new Point(100, 50), // start point
            new Point(0, 100), // control point one
            new Point(200, 100), // control point two
            new Point(100, 150)); // end point
        }
    }
}
