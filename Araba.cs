using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Pratic
{
    public class Araba
    {
        private int _kapiSayisi;  // Kapı sayısını encapsulation ile kontrol altında tutmak için private değişken tanımlanıyor

        // Public özellikler: Marka, Model ve Renk
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        public int KapiSayisi   // Kapı Sayısı özelliği
        {
            get
            {
                return _kapiSayisi; // Kapı sayısı değeri döndürülüyor , okunabilmesi için
            }
            set
            {
                if (value == 4 || value == 2)    // Kapı sayısı yalnızca 2 veya 4 olabilir

                {
                    _kapiSayisi = value; // Geçerli bir değer atanıyor
                }
                else
                {
                    Console.WriteLine("Kapı sayısı 2 ya da 4 dışında bir değer olamaz ");     // Geçersiz bir değer girildiğinde hata mesajı yazdırılıyor
                    _kapiSayisi = -1; // Geçersiz durum için -1 atanıyor
                }

            }
        }

        // Araba bilgilerini ekrana yazdıran metod
        public void Bilgi()
        {
            Console.WriteLine("MARKA: "+Marka);
            Console.WriteLine("MODEL: "+Model);
            Console.WriteLine("RENK: "+Renk);
            Console.WriteLine("KAPI SAYISI: "+_kapiSayisi);
        }
    }
}
