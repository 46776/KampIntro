// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string adı = "engin";
int yas = 34;
string soyadı = "soyadı";

Kurs kurs1 = new Kurs();
kurs1.KursAdı = "C+";
kurs1.egitmen = "Memoca";
kurs1.izlenmeOranı = 78;

Kurs kurs2 = new Kurs();
kurs2.KursAdı = "Cd+";
kurs2.egitmen = "Memocda";
kurs2.izlenmeOranı = 48;

Kurs kurs3 = new Kurs();
kurs3.KursAdı = "C+a";
kurs3.egitmen = "Memocsda";
kurs3.izlenmeOranı = 98;

Kurs kurs4 = new Kurs();
kurs4.KursAdı = "C++";
kurs4.egitmen = "asddocsda";
kurs4.izlenmeOranı = 198;


//Console.WriteLine(kurs1.KursAdı + " : " + kurs1.egitmen + " : " + kurs1.izlenmeOranı);

Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

foreach (var kurs in kurslar)

{
    Console.WriteLine(kurs.KursAdı + " : " + kurs.egitmen + " : " + kurs.izlenmeOranı);
}
class Kurs
{
    public string KursAdı { get; set; }

    public int izlenmeOranı { get; set; }

    public string egitmen { get; set; }

    
}

    Okul Okul1 = new Okul();
    Okul1.Asd = "C+";
    Okul1.Baba = "Memoca";
    Okul1.OgrenciYası = 78;

    Okul Okul2 = new Okul();
    Okul2.Asd = "Cd+";
    Okul2.Baba = "Memocda";
    Okul2.OgrenciYası = 48;

    Okul Okul3 = new Okul();
    Okul3.Asd = "C+a";
    Okul3.Baba = "Memocsda";
    Okul3.OgrenciYası = 98;

    Okul Okul4 = new Okul();
    Okul4.Asd = "C++";
    Okul4.Baba = "asddocsda";
    Okul4.OgrenciYası = 198;


Console.WriteLine(kurs1.KursAdı + " : " + kurs1.egitmen + " : " + kurs1.izlenmeOranı);

Okul[] okullar = new Okul[] {Okul1, Okul2, Okul3, Okul4 };

foreach (var okul in okullar)

{
    Console.WriteLine(okul.Asd + " : " + okul.Baba + " : " + okul.OgrenciYası);
}
class Okul
{
    public string Asd { get; set; }

    public int OgrenciYası { get; set; }

    public string Baba { get; set; }
}



