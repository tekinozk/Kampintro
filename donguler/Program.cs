

string kurs1 = "yazılım gelistirici yetistime kampı";
string kurs2 = "programlamaya başlangıç için temel kurs";
string kurs3 = "Java";


//array-dizi

string[] kurslar = new string[] { "yazılım gelistirici yetistime kampı", "programlamaya başlangıç için temel kurs", "Java","python" };







for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("for bitti");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}







Console.WriteLine("sayfa sonu - footer");


