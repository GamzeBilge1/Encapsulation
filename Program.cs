
using Encapsulation_Pratic;

Araba araba = new Araba();   // Yeni bir araba nesnesi oluşturuluyor

araba.Marka = "Toyota";
araba.Model = "Corolla";
araba.Renk = "Beyaz";

araba.KapiSayisi = 4; // Kapı sayısı atanıyor (geçerli bir değer: 4)

araba.Bilgi();

Console.WriteLine("--------------------------");

araba.KapiSayisi = 5; // Kapı sayısı atanıyor (geçersiz bir değer: 5)

araba.Bilgi();  // Araba bilgileri yazdırılır (Kapı sayısı -1 olur)