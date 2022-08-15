// See https://aka.ms/new-console-template for more information
using OOP1;
using System.Net.WebSockets;

Console.WriteLine("Hello, World!");

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrace = 500;
product1.UnitsInStock = 3;

//aşağıdaki şekilde de yazılabilir

Product product2 = new Product {Id=2, CategoryId=5, UnitsInStock=5, ProductName="kalem", UnitPrace=35 };

// PascalCase     / camelCase
ProductManager productManager = new ProductManager();
productManager.Add(product1);
Console.WriteLine(product1.ProductName + " eklendi ve güncellendi");

productManager.Topla2(3, 6);

int toplamaSonucu = productManager.Topla(3, 6);
Console.WriteLine(toplamaSonucu*4);

Console.WriteLine(productManager.Topla(3, 6) * 2);