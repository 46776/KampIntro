// See https://aka.ms/new-console-template for more information
using Metotlar;

Console.WriteLine("Hello, World!");
string urunAdı = "Elma";
double fiyatı = 15;
string acıklama = "Amasya elması";

string[] meyveler = new string[] { };

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyatı = 105;
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyatı= 30;
urun2.Aciklama = "Diyarbakır Karpuzu";

Urun[] urunler = new Urun[] {urun1, urun2 };

foreach (var urun in urunler )
{
    Console.WriteLine(urunAdı);
    Console.WriteLine(urun.Fiyatı);
    Console.WriteLine(urun.Aciklama);
}
Console.WriteLine("---------------Metotlar-------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);
sepetManager.Ekle2("Armut", "Yeşil alma", 73,8);
sepetManager.Ekle2("siye", "Yeşil siye", 72,8);
sepetManager.Ekle2("kalet", "Yeşil elma", 17,7);
sepetManager.Ekle2("siper", "Yeşil karpuz", 87,7);
