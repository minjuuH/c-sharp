using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawimagePointsSample_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 이미지를 한쪽으로 기울여 그리는 예
            Graphics g = CreateGraphics();
            Image img = new Bitmap("C:\\Users\\hwang\\source\\repos\\C#\\chapter 12\\vs.png");
            Point[] pts = {
                new Point(0, 0), // 원본의 왼쪽 상단 모서리의 대상 위치
                new Point(200, 0), // 원본의 오른쪽 상단 모서리의 대상 위치
                new Point(50, 100) // 원본의 왼쪽 하단 모서리의 대상 위치
            };
            g.DrawImage(img, pts);
        }
    }
}
