using System;
using System.Windows.Forms;

namespace ch10_02 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        //버튼 이벤트
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //메뉴 이벤트
        private void 새파일NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
        private void 열기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
        private void 닫기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
        private void 인쇄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
        private void 미리보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
        private void 잘라내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

    }
}
