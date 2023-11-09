using OOP2;

GercekMusteri musteri1 = new();
musteri1.MusteriNo = "";

TuzelMusteri musteri2 = new();
musteri2.MusteriNo = "";



Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
musteriManager.Ekle(musteri3);
musteriManager.Ekle(musteri4);