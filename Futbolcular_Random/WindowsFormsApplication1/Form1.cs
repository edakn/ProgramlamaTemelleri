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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {  // remove ; Index yerine Item yap :D Remove sözel , RemoveAt sayısal :D 
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            label5.Text = listBox2.Items.Count.ToString();
            //eleman sayısı 11 olduğunda ;
            if (listBox2.Items.Count == 11)
            {
                button1.Enabled = false;
                MessageBox.Show("İlk 11 tamamlandı başarılar...");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            label5.Text = listBox2.Items.Count.ToString();
            if (listBox2.Items.Count != 11)
            {
                button1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           int i ;
           for (i = 0; i < listBox2.Items.Count; i++)
           {
               listBox1.Items.Add(listBox2.Items[i]); // köşeli parantez dizi örneği :)

           }

           listBox2.Items.Clear();

               }



        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { listBox1.Items.Add(textBox1.Text); textBox1.Text = ""; }
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            if (e.Control && e.Shift && e.KeyCode == Keys.D) // e. control de yazabilir :D 
                listBox1.Items.Clear();
            if (e.KeyCode == Keys.F3)
            {
                int a = 0;
                a = listBox1.Items.IndexOf(textBox2.Text); // arama yapıp index'i yazar D:
                MessageBox.Show(a.ToString());
                if(a==-1)
                {   MessageBox.Show("Kayıt bulunamadı..."); }
               else
                { listBox1.SelectedIndex = a; }

                
            }

        }

        
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {   // döngüyle rastgele 11 kişiyi ekle :D 
            // int i=1;
            //for (i = 1; i <= 11; i++)
            // {
                int sayi;
                Random rastgele = new Random();
                sayi = rastgele.Next(1, listBox1.Items.Count - 1);
                // MessageBox.Show(sayi.ToString()); // 10 tane eleman var ama 0 'dan 9'a kadar oluyor o yüzden -1 koy :D 
                listBox2.Items.Add(listBox1.Items[sayi]);
                listBox1.Items.RemoveAt(sayi);
                label5.Text = listBox2.Items.Count.ToString();
           //}
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
