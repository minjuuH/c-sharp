using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidBrushApp {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            SolidBrush b = new SolidBrush(Color.Lime);  //연두색 지정
            g.FillRectangle(b, ClientRectangle);        //전체 채우기
            b.Dispose();
        }
    }
}
