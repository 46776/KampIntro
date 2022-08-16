// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//genericste tip ne ise içindeki operasyonlar o tipte olmak zorunda int ise int string ise string
List<string> şehirler = new List<string>();
şehirler.Add("Adana");
şehirler.Add("Adana");
şehirler.Add("Adana");
şehirler.Add("Adana");
şehirler.Add("Adana");

Console.WriteLine(şehirler.Count);
//şehirler.Count=3; Count Property ve sadece get olduğu için aynı counttan aşağıda propfull oluşturulur
//şehirler.Add("adana");

MyList<string> sehirler2 = new MyList<string>();
sehirler2.Add("Maras");
sehirler2.Add("Maras");
sehirler2.Add("Maras");
sehirler2.Add("Maras");
sehirler2.Add("Maras");
sehirler2.Add("Maras");
sehirler2.Add("Maras");
sehirler2.Add("Maras");
Console.WriteLine(sehirler2.Count);


//MyList<int> şehirler2= new MyList<int>();
//şehirler2.Add(23);



class MyList<T> // bu artık generics class artık çalışma tipi T 
{
    T[] _array;// tip neyse o şekilde array yapılır
    T[] _tempArray; //burada eski bilgileri yedeklemek için yazıyoruz..
     public MyList()
     {
        
        _array = new T[0];// // arraylerin eleman sayısı artırılınca new'lememiz gerekir

    }
    
   
    public void Add(T item)
    {
        _tempArray = _array;    // temparray artık arrayın elemanını tutuyor.
        _array =new T[_array.Length + 1];   //arrayın eleman sayısını artırdık.Ama önceki tüm datalar uçar bu nedenle eski elemanların yedeğini almalıyız. 
        for (int i = 0; i < _tempArray.Length; i++) // aktardığımız kadar dönecek tutaacak olan temparray olduğu için onu yazarız.
        {
            _array[i] = _tempArray[i];   //eleman sayılarını eşitledik.
        }

        _array[_array.Length - 1] = item;     //Gönderdiğimiz eleman olan item eleman sayısının -1 yazma sebebimiz sıfırdan başladığı için item eşitledik.


    
    
    }


    

    public int Count
    {
        get { return _array.Length; } // MyListin Count'unu çağırırsak arrayın eleman sayısını verir. 
        
    }






}