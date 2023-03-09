// Bir class tan üretilen nesneyi imha edilirken kullanldığımız metottur.
// Bir class sadece ve sadece 1 tane destructor'a sahip olabilir. 
// Destructor parametre almaz.
/*
 * Bir nesnenin imha edilebilmesi için;
 *      ilgili nesne herhangi bir referans tarafından işaretlenmemelidir
 *      ilgili nesneye herhangi bir yoldan erişimimiz yoksa garbage collactor tatarfından yok edilir.
 * Overloading yapılamaz.
 * Sınıf ismi ile aynı olacak.
*/

#region Ornek 1
//X();
//GC.Collect();//Tavsiye edilmeyen mudahele bu.
//Console.ReadLine();

//static void X()
//{
//    MyClass m1 = new();
//}
#endregion
#region Ornek 2
int a = 0;
while (a<100)
{
    new MyClass2(a++);
}
GC.Collect();
GC.WaitForPendingFinalizers();
#endregion


class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Selamun Aleykum");
    }

    ~MyClass()
    {
        Console.WriteLine("Gule Gule");
    }
}
class MyClass2
{
    int a;
    public MyClass2(int a)
    {
        this.a = a;
        Console.WriteLine($"{a}. nesne üretilmiştir.");
    }

    ~MyClass2()
    {
        Console.WriteLine($"{a}.nesne garbage collactor tarafından imha edilmiştir.");
    }
}