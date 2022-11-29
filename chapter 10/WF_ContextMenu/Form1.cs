using System;
using System.Drawing;
using System.Windows.Forms;

namespace WF_ContextMenu {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 파란색으로 테두리 그려줌
            Graphics objGraphics = CreateGraphics();
            objGraphics.DrawRectangle(Pens.Blue,
                pictureBox1.Left - 2, pictureBox1.Top - 2,
                pictureBox1.Width + 2, pictureBox1.Height + 2);
            objGraphics.Dispose();
        }
    }
}
