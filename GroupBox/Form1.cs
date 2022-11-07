using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                //  textBox2.Text = (int.Parse(textBox1.Text) - int.Parse(textBox1.Text) * 5 / 100).ToString();
                textBox2.Text = (int.Parse(textBox1.Text) * 0.95).ToString();



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true; 

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false ; 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) / 2).ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) /3).ToString();
        
        }
    }
}
