//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person p1 = new Person("Bek",26);
//        Person p2 = new Person("Mohi", 22);

//        Console.WriteLine("1-Odamning - Ismi: " + p1.Name + ", Yoshi: " + p1.Age + " da");
//        Console.WriteLine("2-Odamning - Ismi: " + p2.Name + ", Yoshi: " + p2.Age + " da");
//    }

//}



//class Dog
//{
//    public string Name { get; set; }
//    public string Breed { get; set; }

//    public Dog(string name, string breed)
//    {
//        Name = name;
//        Breed = breed;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Dog d1 = new Dog("Malla", "Xashaki");
//        Dog d2 = new Dog("Davlat", "Pidbull");

//        Console.WriteLine("  ");
//        Console.WriteLine("Dog 1 - Name: " + d1.Name + ", Breed: " + d1.Breed);
//        Console.WriteLine("Dog 2 - Name: " + d2.Name + ", Breed: " + d2.Breed);

//        d1.Name = "Olopar";
//        d1.Breed = "Zotsiz";
//        d2.Name = "Qorash";
//        d2.Breed = "bulduq";

//        Console.WriteLine("  ");
//        Console.WriteLine("Dog 1 - Name: " + d1.Name + ", Breed: " + d1.Breed);
//        Console.WriteLine("Dog 2 - Name: " + d2.Name + ", Breed: " + d2.Breed);
//    }
//}

//class Rectangle
//{
//    public int x
//    {
//        get; set;
//    }
//    public int y
//    {
//        get; set;
//    }
//    public int Maydon()
//    {
//        return x * y;
//    }
//    public int Peremetr()
//    {
//        return 2 * (x + y);
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Rectangle r = new Rectangle();
//        Console.Write("x tomonni kiriting: ");
//        r.x = int.Parse(Console.ReadLine());
//        Console.Write("y tomonni kiriting: ");
//        r.y = int.Parse(Console.ReadLine());

//        int Maydon = r.Maydon();
//        int Peremetr = r.Peremetr();
//        Console.WriteLine("Maydon: " + Maydon);
//        Console.WriteLine("Peremetr: " + Peremetr);
//    }
//}


//class Circle
//{
//    public int R
//    {
//        get; set;
//    }
//    public double Maydon()
//    {
//        return 3.14 * R * R;
//    }
//    public double Uzunligi()
//    {
//        return 2 * R * 3.14;
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Circle C = new Circle();
//        Console.Write("Raidusni kiriting: ");
//        C.R = int.Parse(Console.ReadLine());

//        double Maydon = C.Maydon();
//        double Uzunligi = C.Uzunligi();
//        Console.WriteLine("Maydon: " + Maydon);
//        Console.WriteLine("Uzunligi: " + Uzunligi);
//    }
//}

//using System;
//using System.Collections.Generic;

//class Kitob
//{
//    public string Sarlavha { get; set; }
//    public string Muallif { get; set; }
//    public string ISBN { get; set; }

//    public Kitob(string sarlavha, string muallif, string isbn)
//    {
//        Sarlavha = sarlavha;
//        Muallif = muallif;
//        ISBN = isbn;
//    }
//}

//class Kutubxona
//{
//    private List<Kitob> kitoblar = new List<Kitob>();

//    public void KitobQoshish(Kitob kitob) {
//        kitoblar.Add(kitob);
//        Console.WriteLine("Kitob kutubxonaga qo'shildi: " + kitob.Sarlavha);
//    }

//public void KitobOchirish(Kitob kitob) {
//        bool ochirildi = kitoblar.Remove(kitob);
//        if (ochirildi) {
//            Console.WriteLine("Kitob kutubxonadan olib tashlandi: " + kitob.Sarlavha);
//        } else
//{
//    Console.WriteLine("Kitob kutubxonada topilmadi: " + kitob.Sarlavha);
//}
//    }

//    public void KitoblarniChopEtish()
//{
//    Console.WriteLine("Kutubxona Kitoblari:");
//    foreach (Kitob kitob in kitoblar)
//    {
//        Console.WriteLine("Sarlavha: " + kitob.Sarlavha);
//        Console.WriteLine("Muallif: " + kitob.Muallif);
//        Console.WriteLine("ISBN: " + kitob.ISBN);
//        Console.WriteLine();
//    }
//}
//}

//class Dastur
//{
//    static void Main(string[] args)
//    {
//        Kutubxona kutubxona = new Kutubxona();

//        // Kitoblar qo'shish
//        Kitob kitob1 = new Kitob("Savol va Javob", "Imom Buxoriy", "9789943388498");
//        Kitob kitob2 = new Kitob("To'rtta til", "Abdulla Qodiriy", "6543124563214");
//        Kitob kitob3 = new Kitob("Gulliverning sayohati", "Jonathan Swift", ""1324659873124);

//        kutubxona.KitobQoshish(kitob1);
//        kutubxona.KitobQoshish(kitob2);
//        kutubxona.KitobQoshish(kitob3);

//        // Kitob ochirish
//        kutubxona.KitobOchirish(kitob2);

//        // Kutubxonadagi kitoblarni chop etish
//        kutubxona.KitoblarniChopEtish();
//    }
//}


//using System.Diagnostics.CodeAnalysis;

//int index = 0;
//try
//{
//    int number = int.Parse(Console.ReadLine());
//    int a = 3;
//    int b = int.Parse(Console.ReadLine());
//    // divide by zero exception
//    int c = a / b;
//    Console.WriteLine(c);
//    // index out of range by zero exception
//    int[] arr = { 1 };
//    index = int.Parse(Console.ReadLine());
//    Console.WriteLine(arr[index]);
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Divide By Zero Exception");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Format Exception");
//}
//catch (IndexOutOfRangeException)

//    when (index < 0)
//        {
//            Console.WriteLine("Index manfiy boliwi mumkin emas");
//        }
////catch (IndexOutOfRangeException)

////    when (index > 0)
////{
////    Console.WriteLine("Index musbat boliwi mumkin emas");
////}

//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

int n = int.Parse(Console.ReadLine());
long M = (2 * 7 + (n - 2) * 7) * (n - 1) / 2 + 1;
Console.WriteLine(M);