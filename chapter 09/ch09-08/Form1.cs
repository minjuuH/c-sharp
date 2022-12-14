using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch09_08 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";  //프로퍼티 지정
            openFileDialog1.FilterIndex = 1;            //filter 프로퍼티의 현재 인덱스
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = true;         //파일 여러 개 동시 선택 가능

            openFileDialog1.ShowDialog();

            foreach(string strTmp in openFileDialog1.FileNames)
            {
                textBox1.Text += strTmp;
                textBox1.Text += "\r\n";
            }
        }
    }
}
