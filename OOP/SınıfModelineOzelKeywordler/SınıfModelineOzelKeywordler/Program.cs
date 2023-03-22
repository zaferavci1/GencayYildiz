#region ThisKeyword'u
/*
 * Uygulamanın herhangş bşr noktasında üretilmiş olunan instance'larının/objectlerini/nesnelerini sınıf içerisinde temsil etmemizi 
 * sağlayan keyworddur. 
 * This keywordu bize sınıf içerisinde bulunan birden fazla constructorlar içerisnde geçiş yapmamızı sağlar.
 * zıplaya zıplaya gider. Kuyruk yapısı gibi düşünülebilir. 
 * Sondan çıkartma işlemi mesela
 */
//new MyClass();
//class MyClass
//{
//    public int MyProperty { get; set; }
//    public MyClass():this("merhaba")
//    {
//        Console.WriteLine("Boş Constructor.");
//    }
//    public MyClass(string A):this("merha",23)
//    {
//        Console.WriteLine("A parametreli");
//    }

//    public MyClass(string A,int b)
//    {
//        Console.WriteLine("A ve B parametreli Ctor");//
//    }
//}
#endregion
#region Base Keywor'du
/*
 * Base keyword'u bir class da o class'ın base class'ındaki memberları temsil eder.
 * Eğer kalıtım almadı ise object nesnesinin memberlarına erişim sağlanır.
 * Bir diğer görevi de base class daki constructorlar arsında seçim yapmamızı sağlar.
 */
//new MyClass2();
//class MyClass
//{
//    public int MyProperty { get; set; }
//    public MyClass() : this("merhaba")
//    {
//        Console.WriteLine("Boş Constructor.");
//    }
//    public MyClass(string A) : this("merha", 23)
//    {
//        Console.WriteLine("A parametreli");
//    }

//    public MyClass(string A, int b)
//    {
//        Console.WriteLine("A ve B parametreli Ctor");//
//    }
//}
//class MyClass2:MyClass
//{
//    public MyClass2():this(4," ")
//    {

//    }
//    public MyClass2(int a): base("", 4)
//    {

//    }
//    public MyClass2(int a, string b)
//    {

//    }
//}
#endregion
#region Readonly Keyword'u
/*
 * Bir class içersiinde tanımlanmış olan değişkenin vey referansın sadece okunaiblir olmasını sağlar.
 * Readonly bir değişkenin değerini ya tanımlama noktasında yada constructor içerisnde verebilrisin.
 * 
 * Const ile readonly arasındaki fark const olan bir değişkene sadece tanımlanma noktasında değer atanabilr.
 *      ama readonly bir değişkene constructor da da değer atanabilir.
 */
#endregion