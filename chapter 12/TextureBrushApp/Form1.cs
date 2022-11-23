using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextureBrushApp {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Image img = new Bitmap("vs.png"); // 이미지 객체 생성
            TextureBrush b = new TextureBrush(img); // 이미지로 된 브러시 객체 생성
            g.FillRectangle(b, ClientRectangle); // 사용자 영역을 이미지로 채움
            img.Dispose(); // 이미지 객체를 해제
            b.Dispose();
        }
    }
}
