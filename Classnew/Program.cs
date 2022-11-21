// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");






Kurs kurs1 = new Kurs();
kurs1.KursAdi = "c+";
kurs1.KursunEgitmeni = "Engin Demirog";
kurs1.izlenmeOrani = 68;


Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.KursunEgitmeni = "Kerem Varıs";
kurs2.izlenmeOrani = 64;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Phyton";
kurs3.KursunEgitmeni = "Berkay Bilgin";
kurs3.izlenmeOrani = 80;

//Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursunEgitmeni);

Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni);
}


class Kurs
{
    public string KursAdi { get; set; }
    public string KursunEgitmeni { get; set; }
    public int izlenmeOrani { get; set; }

}