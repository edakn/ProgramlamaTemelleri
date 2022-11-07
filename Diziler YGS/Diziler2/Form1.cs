using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diziler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isim = { "ecem", "cemre", "esra", "melek", "elif", "betül", "melike", "eda", "seda", "cemile", "zeynep", "irem", "zana", "umut" };
        int[] YGS = { 150, 250, 220, 305, 318, 29, 339, 445, 155, 303, 389, 175, 145, 355 };
        private void button1_Click(object sender, EventArgs e)
        {
           
            //MessageBox.Show(YGS.Length.ToString());
            label2.Text = isim.Length.ToString();
            foreach (string a in isim)
                listBox1.Items.Add(a);
            foreach (int b in YGS)
            {
                listBox2.Items.Add(b);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        { // average = ortalama .
            label10.Text = YGS.Max().ToString();
            label11.Text = YGS.Min().ToString();
            label12.Text = YGS.Average().ToString();

            int say = 0, b = 0, m = 0;
            foreach (int x in YGS)
            {
                if (x >= 180) say++;
                if (x >= 350) b++;
                if (x >= 300 && x < 350) m++;
            }
           label13.Text= say.ToString();
            label14.Text = b.ToString();
            label15.Text = m.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
