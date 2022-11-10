using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveResizeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetButtonText()
        {
            button1.Text = "Location = " + Location + "\n" +
                "Left/Right/Width = " + Left + ", " + Right + ", " + Width + "\n" +
                "Top/Bottom/Height = " + Top + ", " + Bottom + ", " + Height;

            //button1.Text : button의 프로퍼티
            //Location/Left/Right/Width/Top/Bottom/Height : Form의 프로퍼티 (폼의 위치)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetButtonText();
        }

        private void Form1_Move(object sender, EventArgs e)     //폼을 움직일 때
        {
            SetButtonText();
        }

        private void Form1_Resize(object sender, EventArgs e)   //폼의 크기를 변경할 때
        {
            SetButtonText();
        }
    }
}
