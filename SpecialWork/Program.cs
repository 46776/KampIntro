// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

Okul okul1 = new Okul();
okul1.OkulAdı = "gazi";
okul1.Ogretmen = "ali";
okul1.DersSayısı = 25;
okul1.kursAdedi = 2131;

Okul okul2 = new Okul();
okul2.OkulAdı = "mhe";
okul2.Ogretmen = "veli";
okul2.DersSayısı = 50;
okul2.kursAdedi = 123;

Okul okul3 = new Okul();
okul3.OkulAdı = "mmö";
okul3.Ogretmen = "isa";
okul3.DersSayısı = 50;
okul3.kursAdedi = 789;

Okul okul4 = new Okul();
okul4.OkulAdı = "ASD";
okul4.Ogretmen = "FGH";
okul4.DersSayısı = 150;
okul4.kursAdedi = 456; 

//Console.WriteLine(okul1.OkulAdı + " " +okul1.Ogretmen+ " " + okul1.DersSayısı);
//Console.WriteLine(okul2.OkulAdı + " " + okul2.Ogretmen + " " + okul2.DersSayısı);
//Console.WriteLine(okul3.OkulAdı + " " + okul3.Ogretmen + " " + okul3.DersSayısı);

Okul[] okullar = new Okul[] { okul1,  okul3, okul4,okul2 };

foreach (var okul in okullar)
{
    Console.WriteLine(okul.OkulAdı + "- " + okul.Ogretmen+ " - " + okul.DersSayısı+ "  "+okul.kursAdedi);
}
class Okul
{
    public string OkulAdı { get; set; }
    public string Ogretmen { get; set; }
    public int DersSayısı { get; set; }

    public int kursAdedi { get; set; }
}