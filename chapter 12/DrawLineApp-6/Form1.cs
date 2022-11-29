using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLineApp_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 다각형 그리기
            Graphics g = CreateGraphics();
            Point[] pts = { new Point(110, 40), new Point(125, 91),
                new Point(180, 91), new Point(135, 123),
                new Point(152, 172), new Point(110, 141),
                new Point(66, 172), new Point(82, 122),
                new Point(40, 91), new Point(95, 91) };
            g.FillPolygon(Brushes.Pink, pts);
            g.DrawPolygon(Pens.Purple, pts);
        }
    }
}
