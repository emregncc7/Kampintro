using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //nameing convertion -- isimlendirme kuralı
        //syntax -- yazım şekilleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Adi);


        }

        public void Ekle2(string urunadi,string aciklama,int fiyat,int StokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urunadi);
        }
    }
}
