#region Constructor


//new MyClass(9);

//MyClass m = new("String constructor");
//class MyClass
//{
//    //Bir sınıfın içerisinde bir constructor tanımlamasak bile default bir constructor vardır.
//    //Biz bir constructor tanımlarsak default constructoru ezeriz.
//    public MyClass(int a)
//    {
//        Console.WriteLine($"Bir adet MyClasss nesnesi oluşturuldu {a}");
//    }
//    //Constructorlar overload olan metotlardır.
//    public MyClass(string a)
//    {
//        Console.WriteLine($"Bir adet MyClass nesnei oluşturuldu {a}");
//    }
//    //constructor  erişim belirleyicisini private yaparsak bizim nesnemiz başka constructor yok ise oluşmaz.
//    //Bu durumda bizim ileri seviyede nesnenin sadece içinde kendisini üretebilme dışarıdan kendisini çoğaltmaması durumlarında kullanılır.

//}

//class MyClass2
//{
//    private MyClass2()
//    {
//        new MyClass2(); 
//    }
//}
#endregion
#region Constructorlar arası geçiş This


new MyClass3(10);
class MyClass3
{
    public MyClass3()
    {
        Console.WriteLine("1. constructor");
    }
    public MyClass3(int a): this(5,"ads")
    {
        Console.WriteLine($"2. constructor a = {a}");
    }
    public MyClass3(int a,string b):this()
    {
        Console.WriteLine($"3. constructor a={a}  b={b}");
    }
}
#endregion