using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawStringApp {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Font f = new Font("Tahoma", 15);
            g.DrawString("Hello World!", f, Brushes.Black, 10, 10);
            f.Dispose();

        }
    }
}
