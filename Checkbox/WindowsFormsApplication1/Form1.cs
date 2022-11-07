using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.Text = (int.Parse(textBox1.Text) + int.Parse(textBox1.Text) * 0.18).ToString();
            else
                textBox2.Text = (int.Parse(textBox1.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
