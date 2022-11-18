using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch09_07 {
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

            openFileDialog1.ShowDialog();   //파일열기 대화상자(모달)
            textBox1.Text = openFileDialog1.FileName;
        }
    }
}
