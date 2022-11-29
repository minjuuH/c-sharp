using System;
using System.Drawing;
using System.Windows.Forms;

namespace StringFormatSample {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            string s = "This is a long string that will wrap. ";
            s += "It will be centered both vertically and horizontally.";
            Font f = new Font("Tahoma", 15);
            StringFormat sf = new StringFormat();

            //가운데 정렬
            sf.Alignment = StringAlignment.Center; // 수평 정렬
            sf.LineAlignment = StringAlignment.Center; // 수직 정렬

            g.DrawString(s, f, Brushes.Black, ClientRectangle, sf);
            f.Dispose();

        }
    }
}
