using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawStringSample {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            string s = "This string is long enough to wrap.";
            s += " With a 250px-width rectangle, ";
            s += "it requires six lines to display the string in its entirety.";
            Font f = new Font("Tahoma", 15);
            Rectangle r = new Rectangle(10, 10, 250, 150);
            g.DrawRectangle(Pens.Black, r);
            g.DrawString(s, f, Brushes.Black, r);
            f.Dispose();
        }
    }
}
