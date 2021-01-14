using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             *  Bu oyunda iki oyuncu vardır.
             *  Her oyuncunun bir zarı vardır.
             *  Oyuncular zar atar.
             *  Zarlar karşılaştırılır.
             *  Büyük atan kazanır.
             *  
             */
        }

        Oyun zarOyunu = new Oyun();
        private void buttonOyuncu1_Click(object sender, EventArgs e)
        {
            string oyuncuAdi = textBoxOyuncu1Ad.Text;
            zarOyunu.BirinciOyuncu = new Oyuncu(oyuncuAdi, Convert.ToInt32( textBoxOyuncu1Para.Text));
            zarOyunu.BirinciOyuncu.OyuncununZari = new Zar();
            labelOyuncu1.Text = zarOyunu.BirinciOyuncu.Ad;
        }

        private void buttonOyuncu2_Click(object sender, EventArgs e)
        { 
            zarOyunu.IkinciOyuncu = new Oyuncu(textBoxOyuncu2Ad.Text, Convert.ToInt32(textBoxOyuncu2Para.Text));
            labelOyuncu2.Text = zarOyunu.IkinciOyuncu.Ad;
            zarOyunu.IkinciOyuncu.OyuncununZari = new Zar();
            labelOyuncu2.Text = zarOyunu.IkinciOyuncu.Ad;
        }

        private void buttonZar1_Click(object sender, EventArgs e)
        {
            zarOyunu.IlkOyuncuZarAt();
            labelOyuncu1Zar.Text = zarOyunu.BirinciOyuncu.OyuncununZari.Deger.ToString();
            buttonZar2.Enabled = true;

        }

        private void buttonZar2_Click(object sender, EventArgs e)
        {
            zarOyunu.IkınciOyuncuZarAt();
            labelOyuncu2Zar.Text = zarOyunu.IkinciOyuncu.OyuncununZari.Deger.ToString();

            Oyuncu kazanan = zarOyunu.Karsilastir();
            if (kazanan != null)
            {
                labelKazanan.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak oyunu kazandı.";
                labelOyuncu1KalanBakiye.Text = zarOyunu.BirinciOyuncu.OyuncununParası.ToString();
                labelOyuncu2KalanBakiye.Text = zarOyunu.IkinciOyuncu.OyuncununParası.ToString();
            }
            else
            {
                labelKazanan.Text = "Berabere!!";
            }
        }

        private void buttonOyuncu1BahisVer_Click(object sender, EventArgs e)
        {
            zarOyunu.BirinciOyuncu.BahisVer(Convert.ToInt32(textBoxOyuncu1BahisVer.Text));
            textBoxOyuncu1BahisVer.Text = zarOyunu.BirinciOyuncu.Bahis.ToString();
        }

        private void buttonOyuncu2BahisVer_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncu.BahisVer(Convert.ToInt32(textBoxOyuncu2BahisVer.Text));
            textBoxOyuncu2BahisVer.Text = zarOyunu.IkinciOyuncu.Bahis.ToString();
        }
    }
}
