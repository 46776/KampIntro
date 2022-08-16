// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");







MyDictionary<string> arabalar = new MyDictionary<string>();
arabalar.Add("PASSAT");
arabalar.Add("jETTA");
arabalar.Add("POLO");
arabalar.Add("GOLF");
arabalar.Add("AMAROK");
arabalar.Add("TIGUAN");
Console.WriteLine(arabalar.Count);


class MyDictionary<W>
    {
        W[] names;
        W[] tempNames;

        public MyDictionary()
        {
            names = new W[0];
        }

        public void Add(W name)
        {
            tempNames = names;
            names = new W[tempNames.Length + 1];
            for (int i = 0; i < tempNames.Length; i++)
            {
                names[i] = tempNames[i];
            }

            names[names.Length -1] = name;
        }


        public int Count 
        { 
            get { return names.Length; } 
        }

       
}

