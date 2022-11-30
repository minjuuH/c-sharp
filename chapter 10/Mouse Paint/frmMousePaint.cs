using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_Paint
{
    public partial class frmMousePaint : Form
    {
        //Graphics 객체 참조 변수 선언
        private Graphics m_objGraphics;

        public frmMousePaint()
        {
            InitializeComponent();
        }

        private void frmMousePaint_Load(object sender, EventArgs e)
        {
            m_objGraphics = this.CreateGraphics();
        }

        private void frmMousePaint_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_objGraphics.Dispose();    //그래픽 객체 자원 반납
        }

        private void frmMousePaint_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle rectEllipse = new Rectangle();    //원 외접 사각형

            if (e.Button != MouseButtons.Left) 
                return; // 왼쪽 마우스 버튼이 아닐 경우 바로 종료

            //타원을 그리는 영역 설정
            rectEllipse.X = e.X - 1;
            rectEllipse.Y = e.Y - 1;
            rectEllipse.Width = 2;
            rectEllipse.Height = 2;

            //원 그리기
            m_objGraphics.DrawEllipse(System.Drawing.Pens.Blue, rectEllipse);
        }
    }
}
