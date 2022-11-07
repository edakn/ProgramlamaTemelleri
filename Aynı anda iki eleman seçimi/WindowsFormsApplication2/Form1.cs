using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a,b,c;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(comboBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = listBox1.SelectedIndex;
            listBox2.SelectedIndex = a;
            listBox3.SelectedIndex = a;

            label4.Text = (a+1).ToString();
            label6.Text = listBox1.Items.Count.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = listBox2.SelectedIndex;
            listBox1.SelectedIndex = a;
            listBox3.SelectedIndex = a;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = listBox3.SelectedIndex;
            listBox1.SelectedIndex = a;
            listBox2.SelectedIndex = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = listBox1.SelectedIndex;
            b = listBox1.SelectedIndex;
            c = listBox1.SelectedIndex;


            listBox1.Items.RemoveAt(a);
            listBox2.Items.RemoveAt(b);
            listBox3.Items.RemoveAt(c);


            //int b=0;
            // b= listBo1.SelectedIndex;
            //listBox1.Items.RemoveAt(b);
            //listBox2.Items.RemoveAt(b);
            //listBox3.Items.RemoveAt(b);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
