using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HatchBrushApp {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            //HatchBrush: 모양 패턴으로 된 브러시 객체
            HatchBrush b = new HatchBrush(HatchStyle.WideDownwardDiagonal, Color.Green);
            g.FillRectangle(b, ClientRectangle);    //전체 영역을 이미지로 채움
            b.Dispose();
        }
    }
}
