using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch09_03 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load 이벤트는 폼이 표시되기 전에 발생
            MessageBox.Show("MessageBox", "Title Bar");
        }
    }
}
