using Metotlar;


Urun urun1 = new Urun()
{
    Adi = "Elma",
    Fiyati =15,
    Aciklama = "Amasya Elması"
};

Urun urun2 = new Urun()
{
    Adi = "Karpuz",
    Fiyati = 80,
    Aciklama = "Diyarbakır karpuzu"
};

Urun[] urunler = {urun1, urun2 }; 

//type-safe -- tip güvenli
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("-----------");
}

Console.WriteLine("----------------Metodlar-------------------");

//instance - örnek
//encapsulation
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);


sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
sepetManager.Ekle2("Karpuz", "Yeşil karpuz", 12, 8);