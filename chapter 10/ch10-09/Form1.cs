using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch10_09
{
    public partial class Form1 : Form
    {
        //클래스 멤버
        public int xPt, yPt;
        public static readonly int MOVE = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            //버튼의 위치 정보
            this.xPt = this.button1.Location.X;
            this.yPt = this.button1.Location.Y;

            //화살표 키를 눌렀을 때, 버튼의 좌표 변경
            switch (e.KeyCode)
            {
                case Keys.Left:
                    xPt -= MOVE; break;
                case Keys.Right:
                    xPt += MOVE; break;
                case Keys.Up:
                    yPt -= MOVE; break;
                case Keys.Down:
                    yPt += MOVE; break;
            }

            //일반 키를 누를 경우 button의 text 변경
            this.button1.Text = e.KeyCode.ToString();

            this.button1.Location = new Point(xPt, yPt);    //새로운 위치로 button 위치 조정
        }
    }
}
