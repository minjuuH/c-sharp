using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch09_05 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private int i;

        private void Form1_Click(object sender, EventArgs e)
        {
            i = i < 64 ? i += 16 : 0;   //i가 64보다 작을 때 10씩 증가 -> icon이 변경됨
            this.Text = ((MessageBoxIcon)i).ToString();
            MessageBox.Show("MessageBoxIcon", "Title Bar", MessageBoxButtons.OKCancel, (MessageBoxIcon)i);
        }
    }
}
