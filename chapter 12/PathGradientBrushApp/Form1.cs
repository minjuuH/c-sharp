using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PathGradientBrushApp {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();

            //기준점으로 사용할 point 배열
            Point[] pts = { new Point(ClientRectangle.Width/2, 0),
                new Point(0, ClientRectangle.Height),
                new Point(ClientRectangle.Width, ClientRectangle.Height) };

            PathGradientBrush b = new PathGradientBrush(pts);   //기준점 여러개 색전환
            g.FillRectangle(b, ClientRectangle);
            b.Dispose();

        }
    }
}
