// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region record
//MyClass m2 = new()
//{
//	MyProperty = 10
//};
//MyClass m3 = new()
//{
//	MyProperty = 10
//};

//MyRecord m4 = new()
//{
//	MyProperty = 10
//};
//MyRecord m5 = new()
//{
//	MyProperty = 10
//};

//Console.WriteLine(m2.Equals(m3));//false 
//Console.WriteLine(m4.Equals(m5));//true recordlar birbirine eşittir ama nesneler hayır	





//MyClass m1 = new()
//{
//	MyProperty = 1,
//	A = 10
//};

////m1.MyProperty = 10;  !! Burada değer atayamıyoruz.

//// RECORD'lar bize değişmez nesneler oluşturmamızı sağlar
////	nesne canlı bir organizma. Record değeri değişmeyeceğinden artık bir nesne değil de bir değer durumuna dönüşür.
//// Record lar değeri ön planda olan bir nesne
////			35,18
//record MyRecord
//{
//	public int MyProperty { get; init; }
//}


//class MyClass
//{
//    public int MyProperty { get; init; }

//	readonly int a; 
//	public int A
//	{
//		get { return a; }
//		init { a= value; } // init set görevi gördü
//	}
//}
#endregion

#region With



MyClass m1 = new MyClass()
{
    MyProperty1 = 1,
    MyProperty2 = 2
};

    
//m1.MyProperty2=10;//bunu yapamıyorum çünkü bir class ve veri ön planda değil. MyProperty2 10 olması lazımdı.
//bana myproperty2 si 10 olan bir nesne lazım ama burada değiştiremedim bu yüzden yeni bir nesne oluşturacağım.
MyClass m2 = new MyClass()
{
    MyProperty1 = m1.MyProperty1,
    MyProperty2 = 10
};
//with metodu ile 
MyClass m3 = m2.With(10);//bu şekilde MyPropery2 si 10 olan bir MyClass oluştu
//ama bu da zahmetli şimdi record da

MyRecord r1 = new MyRecord()
{
    MyProperty1 = 1,
    MyProperty2 = 2
};

MyRecord r2 = r1 with { MyProperty2 = 10 };
// bu şekilde daha rahat oldu 





public class MyClass
{
    public int MyProperty1 { get; init; }
    public int MyProperty2 { get; init; }

    public MyClass With(int property2)
    {
        return new MyClass()
        {
            MyProperty1 = this.MyProperty1,
            MyProperty2 = property2
        };
    }
}

public record MyRecord
{
    public int MyProperty1 { get; init; }
    public int MyProperty2 { get; init; }
}
#endregion
