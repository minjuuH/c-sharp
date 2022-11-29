using System;
using System.Windows.Forms;

namespace ch10_03
{
    public partial class Form1 : Form
    {
        private int num;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //마우스휠 이벤트 등록 방법
            this.MouseWheel += new MouseEventHandler(this.Form1_MouseWheel);
        }
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            textBox1.Text = (e.Delta > 0 ? num++ : num--).ToString();
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            num = 0;
            textBox1.Text = num.ToString();
        }

    }
}
