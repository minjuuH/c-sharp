using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawImageApp_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //지정 좌표에 그림 - 원본의 크기로 출력
            Graphics g = CreateGraphics();
            Image img = new Bitmap("C:\\Users\\hwang\\source\\repos\\C#\\chapter 12\\vs.png");
            //g.DrawImage(img, 0, 0); 
            g.DrawImage(img, new Point(0, 0));
        }
    }
}
