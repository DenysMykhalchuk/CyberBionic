using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHomeWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, i'm Byte");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, i'm sByte");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, i'm short");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, i'm uShort");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, i'm int");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, i'm uInt");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, i'm long");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, i'm uLong");
        }
    }
}
