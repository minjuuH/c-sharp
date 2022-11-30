using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp2
{
    public partial class Form1 : Form
    {
        private int index;
        private Image[] images;

        public Form1()
        {
            InitializeComponent();
            images = new Image[10];
            string imagePath = "C:\\Users\\hwang\\source\\repos\\C#\\chapter 11\\DUKE\\T";

            for (int i = 1; i <= 10; i++)
                images[i - 1] = Image.FromFile(imagePath + i + ".gif");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < 10)
                label1.Image = images[index++];
            else
            {
                index = 0;
                label1.Image = images[index++];
            }
        }
    }
}
