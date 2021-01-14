using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    class Oyun
    {
        public Oyuncu BirinciOyuncu { get; set; }
        public Oyuncu IkinciOyuncu { get; set; }

        public void IlkOyuncuZarAt()
        {
            BirinciOyuncu.Oyna();
        }

        public void IkınciOyuncuZarAt()
        {
            IkinciOyuncu.Oyna();
        }

        public Oyuncu Karsilastir()
        {
            if(BirinciOyuncu.OyuncununZari.Deger > IkinciOyuncu.OyuncununZari.Deger)
            {
                BirinciOyuncu.OyuncununParası += BirinciOyuncu.Bahis + IkinciOyuncu.Bahis; 
                return BirinciOyuncu;
            }
            else if (BirinciOyuncu.OyuncununZari.Deger < IkinciOyuncu.OyuncununZari.Deger)
            {
                IkinciOyuncu.OyuncununParası += BirinciOyuncu.Bahis + IkinciOyuncu.Bahis;
                return IkinciOyuncu;
            }
            else
            {
                return null;
            }
          
        }
    }
}
