using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch09_02 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();               //form2를 모덜리스 방식으로 띄운다.
            //모덜리스 방식: 다른 창으로 넘어갈 수 있음
        }
    }
}
