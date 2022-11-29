using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawimagePointsSample_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 이미지를 90도 회전하도록 설정
            Graphics g = CreateGraphics();
            Image img = new Bitmap("C:\\Users\\hwang\\source\\repos\\C#\\chapter 12\\vs.png");
            Point[] pts = {
                new Point(100, 0), new Point(100, 200), new Point(0, 0)
            };
            g.DrawImage(img, pts);
        }
    }
}
