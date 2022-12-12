using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//폼을 최소화 시킨 후, 다시 display할 경우, line이 사라지는 문제 존재
namespace PictureBox_Drawing_v1
{
    public partial class Form1 : Form
    {
        Point start; Point end;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(this.pictureBox1.BackColor);    //Picture 화면 지우기
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            end.X = e.X; end.Y = e.Y;

            g = this.pictureBox1.CreateGraphics();  //해당 그래픽은 Form1에 대한 그래픽이 됨
            g.DrawLine(Pens.White, start, end);
        }
    }
}
