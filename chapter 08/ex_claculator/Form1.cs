using System;
using System.Windows.Forms;

namespace ex_claculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (double.Parse(textBox1.Text) + double.Parse(textBox2.Text)).ToString();
            textBox1.Clear(); textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = (double.Parse(textBox1.Text) - double.Parse(textBox2.Text)).ToString();
            textBox1.Clear(); textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text)).ToString();
            textBox1.Clear(); textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            textBox3.Text = (double.Parse(textBox1.Text) / double.Parse(textBox2.Text)).ToString();
            textBox1.Clear(); textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();    //프로그램 종료
        }
    }
}
