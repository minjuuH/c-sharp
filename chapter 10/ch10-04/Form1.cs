using System;
using System.Drawing;
using System.Windows.Forms;

namespace ch10_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);    //마우스의 상대좌표 정보 저장
            string msg = "Mouse Position : "+mousePoint.X+", "+mousePoint.Y;
            MessageBox.Show(msg);   //마우스 위치를 메시지박스로 출력
        }
    }
}
