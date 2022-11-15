using System;
using System.Windows.Forms;

namespace ch08_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);  //입력한 텍스트로 아이템 추가
                textBox1.Clear();   //텍스트 박스 내용 지우기
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //선택한 리스트박스의 항목을 삭제
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
