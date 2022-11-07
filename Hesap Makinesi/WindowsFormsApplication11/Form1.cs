using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0, b = 0;
        
        
        string islem;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = 0;
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Text = "";
            islem = "^";
            
          
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Text = "";
            islem = "+";
            
          

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (islem == "+")
                textBox1.Text = (a + int.Parse(textBox1.Text)).ToString();
            if (islem == "-")
                textBox1.Text = (a - int.Parse(textBox1.Text)).ToString();
            if (islem == "/")
                textBox1.Text = (a / int.Parse(textBox1.Text)).ToString();
            if (islem == "*")
                textBox1.Text = (a * int.Parse(textBox1.Text)).ToString();
            if (islem == "^")
            { textBox1.Text = (Math.Pow(a, double.Parse(textBox1.Text)).ToString()); }
            if (islem == "Karekök")
            { textBox1.Text = (Math.Sqrt(a).ToString()); }
            if (islem == "%")
            { textBox1.Text = (a % int.Parse(textBox1.Text)).ToString(); }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Text = "";
            islem = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Text = "";
            islem = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Text = "";
            islem = "*";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Text = "";
            islem = "%";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Text = "";
            islem = "Karekök";
        
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) % 2 == 0) textBox1.Text = "Çift";
            if (int.Parse(textBox1.Text) % 2 == 1) textBox1.Text = "Tek";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
