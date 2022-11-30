using System;
using System.Windows.Forms;

namespace ch10_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Enter: 자신 또는 자식 컨트롤이 입력포커스를 가질 때 발생
        //Leave: 자신 또는 자식 컨트롤이 입력포커스를 잃을 때 발생
        private void textBox1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("비밀번호를 입력하세요");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("두번째 TextBox 입력");
        }
    }
}
