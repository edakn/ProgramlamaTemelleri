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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i=0, kod = 1;
            for (i = 2; i < (int.Parse(textBox1.Text)); i++)
            
                {

                if (int.Parse(textBox1.Text )% i==0) 

                    kod=0 ;
              
                }
                
             if(kod==1) textBox2.Text="Sayı asaldır." ;
             if(kod==0) textBox2.Text="Sayı asal değildir." ;
            
           
            

        }
    }
}
