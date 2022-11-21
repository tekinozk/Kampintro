// See https://aka.ms/new-console-template for more information
using methods;













product urun1 = new product();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";
urun1.Stokadedi = 120;

product urun2 = new product();
urun2.Adi = "karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakir Karpuzu";
urun2.Stokadedi = 300;
product[] urunler = new product[] { urun1, urun2, };


foreach (product product in urunler)
{
    Console.WriteLine(product.Adi);
    Console.WriteLine(product.Fiyati);
    Console.WriteLine(product.Aciklama);
    Console.WriteLine("------");
}


Console.WriteLine("--------Metotlar-----");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut","yeşil",4,12);
sepetManager.Ekle2("elma", "sarı", 5,12);



