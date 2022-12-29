using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety -- tip güvenliği önemlidi java ve c# da katıdır.          
            // Do not repeat yourself!
            string kategoriEtiketi = "Kategoris";
            int ogrenciSayisi = 12000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun )
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            

        }
    }
}
