﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName  +   "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

        public int Topla(int sayı1, int sayı2)
        {
            return sayı1 + sayı2;
        }

        public void Topla2(int sayı1, int sayı2)
        {
            Console.WriteLine(sayı1 + sayı2);         }


    }
}
