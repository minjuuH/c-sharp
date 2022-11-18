using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch09_11 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrinterSettings printer = new PrinterSettings();
            printDialog1.PrinterSettings = printer;
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            printDocument1.DocumentName = textBox1.Text;
            Font printFont = new Font("Arial", 10, FontStyle.Regular);
            e.Graphics.DrawString(printDocument1.DocumentName, printFont, Brushes.Black, 10, 10);
        }
    }
}
