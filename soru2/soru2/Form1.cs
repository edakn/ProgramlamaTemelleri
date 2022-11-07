using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int k=0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                
                int c = 0;
                c = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(c);
                listBox2.Items.RemoveAt(c);
                listBox3.Items.RemoveAt(c);
            }

            if (e.KeyCode == Keys.F3)
            {
                k = listBox1.Items.IndexOf(textBox6.Text);

                listBox1.SelectedIndex = k;
            }
            
            int x,y,z;
            if (e.KeyCode == Keys.F5)
            {
                x=listBox1.SelectedIndex;
                y=listBox1.SelectedIndex;
                z=listBox1.SelectedIndex;
                
                textBox3.Text = x.ToString();//güncelleme
                textBox4.Text = y.ToString();//güncelleme
                textBox5.Text = z.ToString();//güncelleme
                
            }
    
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(comboBox1.Text);
            listBox3.Items.Add(textBox2.Text);

            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
   
        }
        int a,b;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = listBox1.SelectedIndex;
            listBox2.SelectedIndex = a;
            listBox3.SelectedIndex = a;

            b = listBox1.SelectedIndex;
            label4.Text = (b + 1).ToString();
            label6.Text = listBox1.Items.Count.ToString();

            textBox3.Text = listBox1.Items[a].ToString();//güncelleme
            textBox4.Text = listBox2.Items[a].ToString();//güncelleme
            textBox5.Text = listBox3.Items[a].ToString();//güncelleme

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
    }
}
