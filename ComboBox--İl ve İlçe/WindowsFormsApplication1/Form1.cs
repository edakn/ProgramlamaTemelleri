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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) { comboBox2.Items.Clear(); comboBox2.Text = ""; comboBox2.Items.Add("Kartal"); comboBox2.Items.Add("Kadıköy"); comboBox2.Items.Add("Maltepe"); }
            if (comboBox1.SelectedIndex == 1) { comboBox2.Items.Clear(); comboBox2.Text = ""; comboBox2.Items.Add("Altındağ"); comboBox2.Items.Add("Keçiören"); comboBox2.Items.Add("Çankaya"); }
            if (comboBox1.SelectedIndex == 2) { comboBox2.Items.Clear(); comboBox2.Text = ""; comboBox2.Items.Add("Akçabaat"); comboBox2.Items.Add("Maçka"); comboBox2.Items.Add("Sürmene"); }
            if (comboBox1.SelectedIndex == 3) { comboBox2.Items.Clear(); comboBox2.Text = ""; comboBox2.Items.Add("Bozüyük"); comboBox2.Items.Add("Söğüt"); comboBox2.Items.Add("Osmaneli"); }
            if (comboBox1.SelectedIndex == 4) { comboBox2.Items.Clear(); comboBox2.Text = ""; comboBox2.Items.Add("Otlukbeli"); comboBox2.Items.Add("İliç"); comboBox2.Items.Add("Kemah"); }
            if (comboBox1.SelectedIndex == 5) { comboBox2.Items.Clear(); comboBox2.Text = ""; comboBox2.Items.Add("Alaçam"); comboBox2.Items.Add("Bafra"); comboBox2.Items.Add("Çarşamba"); }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
