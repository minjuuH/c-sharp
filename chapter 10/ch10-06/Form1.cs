using System;
using System.Drawing;
using System.Windows.Forms;

namespace ch10_06
{
    public partial class Form1 : Form
    {
        //클래스 멤버
        protected const int xNum = 5; //가로 박스 수
        protected const int yNum = 4; //세로 박스 수
        protected bool[,] abChecked = new bool[yNum, xNum]; //체크 여부
        protected int cxBlock, cyBlock; //블록의 폭, 높이

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //블록의 폭, 높이를 화면 크기에 맞게 설정
            cxBlock = ClientSize.Width / xNum;
            cyBlock = ClientSize.Height / yNum;
            Invalidate();   //화면 갱신 시키는 paint 이벤트 발생시킴
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //화면에 블록을 그려줌
            Graphics g = e.Graphics;
            Pen pen = new Pen(ForeColor);
            for (int y = 0; y < yNum; y++)
                for (int x = 0; x < xNum; x++)
                {
                    g.DrawRectangle(pen, x * cxBlock, y * cyBlock,
                    cxBlock, cyBlock);
                    if (abChecked[y, x])
                    {
                        g.DrawLine(pen, x * cxBlock, y * cyBlock,
                        (x + 1) * cxBlock, (y + 1) * cyBlock);
                        g.DrawLine(pen, x * cxBlock, (y + 1) * cyBlock,
                        (x + 1) * cxBlock, y * cyBlock);
                    }
                }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //마우스의 클릭 위치를 블록 단위 좌표로 설정
            int x = e.X / cxBlock;
            int y = e.Y / cyBlock;

            if (x < xNum && y < yNum)   //폼 영역 내인지 검사
            {
                abChecked[y, x] ^= true;
                Invalidate(new Rectangle(x * cxBlock, y * cyBlock,  //블록의 시작 지점
                cxBlock, cyBlock));     //블록의 폭, 높이
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnResize(EventArgs.Empty);  //Resize 이벤트 발생
        }

    }
}
