// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

int sayı1 = 10;
int sayı2 = 20;

sayı1 = sayı2;

sayı2 = 100;
Console.WriteLine("sayı 1 " + sayı1);

//array,class,interface..... referance types

int[] sayılar1 = new int[] { 1, 2, 3, };

int[] sayılar2 = new int[] { 10, 20, 30, };

sayılar1 = sayılar2;

sayılar2[0] = 1000;
sayılar1[1] = 100;

Console.WriteLine("Sayılar 1 [0]" + sayılar1[0]);
Console.WriteLine("sayıalr 2 [1]" + sayılar2[1]);

Person person1 = new Person();
Person person2 = new Person();
person1.FırstName = "Mehmet";
person2.FırstName = "Kemal";
person2 = person1;
person2.FırstName = "İlker";
person1.FırstName = "Süleyman";
Console.WriteLine(person2.FırstName);


Customer customer = new Customer();
customer.FırstName = "Salih";
customer.CrediCardNumber = "1234567890";
Employee employee = new Employee();

Person person4 = employee;
employee.FırstName = "Mahmut";
Console.WriteLine(person4.FırstName);


Person person3 = customer;
customer.FırstName = "Fatih";
PersonManager personManager = new PersonManager();
personManager.Add(employee);

Console.WriteLine((((Customer)person3).CrediCardNumber) + " " + customer.FırstName + " " + "Sisteme Giriş Yaptınız.");

//base class 
class Person
{
    public int Id { get; set; }
    public string FırstName { get; set; }
    public string LastName { get; set; }    

 
}


class Customer:Person
{
    public string CrediCardNumber { get; set; }
}
//Emylose ve Customer'ın içinde artık Person bilgileri içermektedir.
class Employee:Person
{
    public int EmployeeNumber { get; set; }

}
class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FırstName);
    }

}

