using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch09_01 {
    public partial class Form2 : Form {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //해당 폼은 모달 방식임으로 닫기 전까지 이전 창으로 돌아갈 수 없음
            this.Close();   //폼을 닫음
        }
    }
}
