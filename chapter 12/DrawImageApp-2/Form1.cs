using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawImageApp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //지정 영역에 그림 - 영역의 크기만큼 이미지 크기가 자동으로 조절되어 출력
            Graphics g = CreateGraphics();
            Image img = new Bitmap("C:\\Users\\hwang\\source\\repos\\C#\\chapter 12\\vs.png");
            g.DrawImage(img, ClientRectangle);
        }
    }
}
