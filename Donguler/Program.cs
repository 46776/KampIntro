// See https://aka.ms/new-console-template for more information
//onsole.WriteLine("Hello, World!");

string kurs1 = "yazılım tyetiştime";
string kurs2 = "kurscu yetiştime";
string kurs3 = "java kurs başlama";

string[] kurslar = new string[] { "yazılım tyetiştime", " kurscu yetiştime", " java kurs başlama", "phyton", "html", "passat", "c#" };

Console.WriteLine(kurslar);


for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);


	
}
Console.WriteLine("for bitti");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
Console.WriteLine("sayfa sonu");



