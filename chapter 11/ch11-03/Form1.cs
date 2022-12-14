using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch11_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                textBox1.Text = treeView1.SelectedNode.Text;
                textBox2.Text = (treeView1.SelectedNode.Parent == null) ?
                "" : treeView1.SelectedNode.Parent.Text;
                textBox3.Text = (treeView1.SelectedNode.PrevNode == null) ?
                "" : treeView1.SelectedNode.PrevNode.Text;
                textBox4.Text = (treeView1.SelectedNode.NextNode == null) ?
                "" : treeView1.SelectedNode.NextNode.Text;
                if (treeView1.SelectedNode.Nodes != null)   //자식노드가 존재하는 경우
                {
                    listBox1.Items.Clear();

                    //treeView1.SelectedNode.Nodes: 선택된 노드의 자식노드
                    foreach (TreeNode node in treeView1.SelectedNode.Nodes)
                        listBox1.Items.Add(node.Text);
                }
            }

        }
    }
}
