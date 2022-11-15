using System;
using System.Windows.Forms;

namespace ch08_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strTemp = "";
            foreach(object obj in checkedListBox1.CheckedItems)
            {
                strTemp += obj.ToString() + " ";
            }
            MessageBox.Show("당신의 취미는 " + strTemp + "입니다.");
        }
    }
}
