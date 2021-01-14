using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    class Oyuncu
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Zar OyuncununZari { get; set; }
        public int OyuncununParası { get; set; }
        public int Bahis { get; set; }

        public void Oyna()
        {
            OyuncununZari.At();
        }

        public Oyuncu(string ad, int para)
        {
            Ad = ad;
            OyuncununParası = para;
        }

        public void BahisVer(int bahis)
        {
            Bahis = bahis;
            OyuncununParası -= bahis;
        }
    }
}
