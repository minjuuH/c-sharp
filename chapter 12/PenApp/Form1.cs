using System;
using System.Drawing;
using System.Windows.Forms;

namespace PenApp {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black, 20);   //생성자에서 pen width 지정
            // p.Width = 10;
            g.DrawRectangle(p, 30, 30, 70, 70);
            p.Dispose();    //Pen 자원 반납
        }
    }
}
