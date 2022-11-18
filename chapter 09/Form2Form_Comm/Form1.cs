using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2Form_Comm {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        public void SetTextBox(string strText)
        {
            textBox1.Text = strText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2show = new Form2(this);
            form2show.Show();
            form2show.setText1("Hello");
        }
    }
}
