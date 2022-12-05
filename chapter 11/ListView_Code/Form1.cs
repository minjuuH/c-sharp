﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.BackColor = Color.Brown;
            listView1.ForeColor = Color.Blue;
            listView1.GridLines = true;         //행과 열 사이에 그리드라인 표시
            listView1.Size = new Size(450, 130); // 150 * 3= 450
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            //ColumnHeader 생성
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Student Name";
            columnHeader1.TextAlign = HorizontalAlignment.Left;
            columnHeader1.Width = 150;
            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "Father Name";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader3.Text = " Student No";
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            columnHeader3.Width = 150;

            //listView1에 Columns 추가
            listView1.Columns.Add(columnHeader1);
            listView1.Columns.Add(columnHeader2);
            listView1.Columns.Add(columnHeader3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            //추가할 ListViewItem 생성
            ListViewItem lv1 = new ListViewItem(textBox1.Text);
            lv1.SubItems.Add(textBox2.Text);
            lv1.SubItems.Add(textBox3.Text);
            listView1.Items.Add(lv1);

            //textBox 비워줌
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
