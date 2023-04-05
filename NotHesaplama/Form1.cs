using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotHesaplama
{
    
    
    public partial class Form1 : Form
    {

        double hesapla, not1, not2, proje;
        string ad, soyad;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad = textBox1.Text;
            soyad = textBox2.Text;
            not1 = Convert.ToInt32(textBox3.Text);

            not2 = Convert.ToInt32(textBox4.Text);

            proje = Convert.ToInt32(textBox5.Text);

            hesapla = (not1 + not2 + proje) / 2;

            richTextBox1.Text = "Sayın "+ad + " " + soyad +  " Not Ortalamanız " +hesapla.ToString() ;

        }
    }
}
