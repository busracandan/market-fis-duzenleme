using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace markete_ödenecek_tutar_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double odenecek = 0;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int urunKDVsiz = Convert.ToInt32(textBox2.Text);
            double urunKDV = (urunKDVsiz * 0.18) + urunKDVsiz;
            double urunSonFiyat = 0;
            if (radioButton1.Checked == true)
            {
                urunSonFiyat = Math.Round((urunKDV - (urunKDV * 0.03)), 2); // öğrenciye %3 indirim uygulunacak.
                odenecek += urunSonFiyat;
            }
            else if (radioButton2.Checked == true)
            {
                urunSonFiyat = Math.Round((urunKDV - (urunKDV * 0.05)), 2); // yaşlıya %5 indirim uygulanacak.
                odenecek += urunSonFiyat;
            }
            else if (radioButton3.Checked == true)
            {
                urunSonFiyat = Math.Round(urunKDV, 2); // virgulden sonra son 2 haneye yuvarla.
                odenecek += urunSonFiyat;
            }
            listBox1.Items.Add(textBox1.Text + " " + urunSonFiyat + " TL");
            textBox2.Text = odenecek + " TL";
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           textBox2.Clear();
            odenecek = 0;
            textBox1.Clear();
            textBox2.Clear();
 
        }
    }
}
