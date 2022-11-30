using System;
using System.Drawing;
using System.Windows.Forms;

namespace ch10_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //버튼1 클릭 시 버튼2가 입력 포커스를 가짐
            this.button1.BackColor = SystemColors.Control;
            this.button2.Focus();
            if (this.button2.Focused)
                this.button2.BackColor = SystemColors.ControlDark;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //버튼2 클릭 시 버튼1이 입력 포커스를 가짐
            this.button2.BackColor = SystemColors.Control;
            this.button1.Focus();
            if (this.button1.Focused)
                this.button1.BackColor = SystemColors.ControlDark;
        }
    }
}
