using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetMeneger
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi + " " + urun.Fiyati);
            

        }

        public void Ekle2(string urunAdi, string Aciklama, double Fiyat, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        
        }

    }
}
