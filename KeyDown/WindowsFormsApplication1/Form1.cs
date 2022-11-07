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

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Hoşgeldiniz..");
            //MessageBox.Show(listbox1.SelectedIndex.ToString()); = Seçilen öğrenin index'ini numarasını gösterir :D 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        { //Basılan tuş Listbox'a eklettirir.Şimşek işaretinden KeyDown'a çift tıkla :D 
          

     
            if (e.KeyCode == Keys.Enter)
            {

                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";

            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { // RemoveAt'te sayusal veri giriyorsun :D < İndex'lii >

            if (e.KeyCode == Keys.Delete)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            if (e.KeyCode == Keys.ShiftKey)

                listBox1.Items.Clear();
            //Key Preview = Forma yazılan kodları çalışması için true olmalıdır :D 
          
        }

    }
}