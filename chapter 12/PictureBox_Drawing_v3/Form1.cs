using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Persistent Graphics 구현
namespace PictureBox_Drawing_v3
{
    public partial class Form1 : Form
    {
        Point start; Point end;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height, 
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            g = Graphics.FromImage(pictureBox1.BackgroundImage);

            g.FillRectangle(new SolidBrush(pictureBox1.BackColor), 0, 0, pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                start = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                end.X = e.X; end.Y = e.Y;

            g.DrawLine(Pens.White, start, end);

            pictureBox1.Refresh();  //그래픽 작업 후 Refresh 필요
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            pictureBox1.Refresh();
        }
    }
}
