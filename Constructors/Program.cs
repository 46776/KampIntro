// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//aşağıda 2 şekilde kullanabilirsin 2.şekilde kullanacaksan customerin içine bilgileri geçmen gerek.
//public Customer(int id, string firstName, string LastName, string City) şeklinde
// 2 şekilde de kullanmak istiyorsan aşağıdaki gibi 2 girmelisin
//public Customer()
//{

//}
//// default constructors= parametresi olmayan constructor'tır.
///{ Id = 1, FırstName = "Mehmet", LastName = "Karaaslan", Cİty="Ankara" }; parametre değildir süslü parantez parametre olmaz.
//public Customer(int id, string firstName, string LastName, string City)
//{
//    Console.WriteLine("Yapıcı blok Çalıştı");
//}



Customer customer1 = new Customer() { Id = 1, FırstName = "Mehmet", LastName = "Karaaslan", Cİty="Ankara" };
//üstündeki ve altında ki kullanım aynı kullanımdır.
Customer customer3 = new Customer();
customer3.Id = 3;


Customer customer2 = new Customer (2, "Kemal", "Kaya", "Antalya");

Console.WriteLine(customer2.FırstName);





//Özellik barındıran class türü bir de operasyon yapan class vardır(ekleme,silme,listeleme,filtreleme...gibi)
class Customer
{

    public Customer()
    {

    }
    // default constructors
    public Customer(int id, string firstName, string LastName, string City)
    {
        Id = id;
        FırstName=firstName;
        LastName = LastName;
        City = City;

//aşağıdaki bilgileri yazması için yukarda eşitlemen gerekir.

    }
    public int Id { get; set; }

    public string FırstName { get; set; }

    public string LastName { get; set; }

    public string Cİty { get; set; }
}