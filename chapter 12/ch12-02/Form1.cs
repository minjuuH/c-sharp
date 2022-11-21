using System;
using System.Drawing;
using System.Windows.Forms;

namespace ch12_02 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Random r = new Random();        //난수를 생성할 랜덤 객체 생성
            Color c = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));   //랜덤 색상 지정
            g.FillRectangle(new SolidBrush(c), ClientRectangle);
        }
    }
}
