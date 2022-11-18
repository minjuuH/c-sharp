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
    public partial class Form2 : Form {
        Form1 parent;

        public Form2(Form1 p)
        {
            InitializeComponent();
            parent = p;
        }

        public void setText1(string temp)
        {
            this.label1.Text = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.SetTextBox("Hello there");
            this.Close();
        }
    }
}
