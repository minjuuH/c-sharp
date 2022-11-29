using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawImageApp_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 원본 이미지의 일부분만 그림
            Graphics g = CreateGraphics();
            Image img = new Bitmap("C:\\Users\\hwang\\source\\repos\\C#\\chapter 12\\vs.png");
            Rectangle sr = new Rectangle(0, 0, 80, 30); // 원본의 부분적인 크기
            Rectangle dr = new Rectangle(0, 0, 200, 100); // 그려질 영역 크기
            g.DrawImage(img, dr, sr, GraphicsUnit.Pixel);
        }
    }
}
