// See https://aka.ms/new-console-template for more information



using GenericsIntro;
 
MyList<string> isimler= new MyList<string>();
isimler.Add("Mehmet");

Console.WriteLine(isimler.Length);


isimler.Add("Kemal");

Console.WriteLine(isimler.Length);

foreach (var isim in isimler.Items)
{
    Console.WriteLine(isim);
}
{

}