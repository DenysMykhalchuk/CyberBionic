using System;
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
            MessageBox.Show("from 0 to 255");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -128 to 127");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -32768 to 32767");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 to 65535");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -2147483648 to 2147483647");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 to 4294967295");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from –9 223 372 036 854 775 808 to 9 223 372 036 854 775 807");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 to 18 446 744 073 709 551 615");
        }
    }
}
