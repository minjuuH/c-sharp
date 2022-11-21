using System;
using System.Drawing;
using System.Windows.Forms;

namespace ch12_03 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Size s = ClientRectangle.Size;              //바뀐 Client 영역 반영
            Image img = new Bitmap(s.Width, s.Height);  //폼 크기와 같은 메모리상 가상 이미지
            Graphics bg = Graphics.FromImage(img);      //가상 이미지에 대한 그래픽 객체

            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));   //랜덤한 색상 생성
            bg.FillRectangle(new SolidBrush(c), ClientRectangle); //크기 확대 변경 영역만 변경
            // 참고 : e.ClipRectangle

            Graphics fg = e.Graphics;   //폼에 대한 그래픽 객체
            fg.DrawImage(img, 0, 0);    //폼에 대한 그래픽 객체에 변형된 백그라운드 작업 이미지 표시
        }
    }
}
