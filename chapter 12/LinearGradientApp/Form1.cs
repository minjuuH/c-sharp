using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LinearGradientApp {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            LinearGradientBrush b = new LinearGradientBrush(new Point(0, 0), new Point(40, 30), Color.Blue, Color.Red);
            //LinearGradientBrush(시작점, 끝점, 시작 색, 끝 색)
            g.FillRectangle(b, ClientRectangle);
            b.Dispose();
        }
    }
}
