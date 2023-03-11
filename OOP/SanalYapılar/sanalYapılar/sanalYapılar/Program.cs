/*
 *          Sanal (VIRTUAL) Yapılar 
 * Sanal yapılar base class da olan (metot ya da property) yapıların torunlarda yeniden yapılanması-içeriğinin değiştirilmesi
 *      veya görevinin farklılaştırılmasıdır.
 * Bu sanal yapılar torunlarda tekraradan yapılnamsı kalıcı bir durumdur ve runtime da gerçekleşir.
 * Virtual yapılar hangi hangi nesneden geleceği runtime da belirlenir.     
 */

//       SANAL YAPILAR NE İÇİN KULLANILIR
/*
 * Bir sınıfta kendisinden türeyen sınıflarda name hiding durumunun oluşmaması için yeniden yazılıp çizilmesi için kullanılır.
 * Sanal yapılar oluşturlduktan sonra kalıtım almış sınıflarda illa değiştirlmesi - ezilmesi zorunlu değildir.
 */
//      VIRTUAL Keyword'u
/*
 * class MyClass
    {
        public virtual int MyProperty { get; set; } SANAL PROP 
        public virtual void X()
        {
        }
    }
 */

//          KALITIM DURUMLARINDA OVERRIDE
/*
 *  Base class ta virtual ile işaretlendikten sonra kendisinden üretilen bir class da override edilen bir metot, 
 *          override edilen class dan kalıtım alan bir metotta geçerli olacaktır ve kendisinden sonraki kendisinden kalıtım 
 *          almış bir class da da tekrardan override edilebilir.
 */

//          SANAL VIRTUAL YAPILAR OZET
/*
 * SANAL YAPILAR OOP'DE POLİMORFİZM UYGULAYAN YAPIDIR.
 * BİR MEMBER SANAL OLARAK BİLDİRİLMİŞSE BUNUN HANGİ NESNEDEN GELECEĞİ RUN TİME DA BELİRLENİR.
 *      RUN TİME DA BELİRLENME DURUMUNDA BİZ GEÇ BAĞLAM (LATE BİNDİNG ) DERİZ.
 * SANAL YAPI BELİRLEMEK İÇİN VIRTUAL KEYWORDUNU KULLANIRIZ.
 * SANAL YAPIYI KLAITIM DURUMUNDA KULLANABİLMEK İÇİN DE OVERRIDE KEYWORDUNU KULLANIRIZ.
 * STATİC YAPILAR SANAL OLARAK BİLDİLEMEZLER.
 */

#region Ornek 1
//Terlik terlik = new();
//terlik.Bilgi();
//Kalem kalem = new();
//kalem.Bilgi();


//class Obje
//{
//    public virtual void Bilgi()
//    {
//        Console.WriteLine("Ben bir objeyim");
//    }
//}

//class Terlik : Obje
//{
//    public override void Bilgi()
//    {
//        Console.WriteLine("Ben bir terliğim");
//    }
//}
//class Kalem : Obje
//{
//    //override yazıp boşluk bırakmamaız yeterli 
//    public override void Bilgi()
//    {
//        Console.WriteLine("Ben bir kalemim ");
//    }

//}

#endregion
#region Ornek 2

//Maymun maymun = new();
//maymun.Konus();
//Inek inek = new();
//inek.Konus();


//class Memeli
//{
//    virtual public void Konus()
//    {
//        Console.WriteLine("ben konuşmuyorum");
//    }

//}
//class Maymun : Memeli
//{
//    public override void Konus()
//    {
//        Console.WriteLine("ben maymunum");
//    }
//}
//class Inek : Memeli
//{
//    public override void Konus()
//    {
//        Console.WriteLine("Ben ineğim");
//    }
//}
#endregion
#region Ornek 3


Ucgen ucgen = new(5, 10);
Console.WriteLine(ucgen.AlanHesapla());
Dikdortgen dikdortgen = new(5, 60);
Console.WriteLine(dikdortgen.AlanHesapla());



public class Sekil
{
    protected int boy;
    protected int en;
    public Sekil(int boy, int en)
    {
        this.boy = boy;
        this.en = en;
    }
    public virtual int AlanHesapla()
    {
        return 0;
    }
}

class Ucgen : Sekil
{
    public Ucgen(int boy, int en) : base(boy, en)//base class cnstructor'u parametre alıyo.
    {

    }

    public override int AlanHesapla()
    {
        return (boy * en) / 2;
    }
}

class Dikdortgen : Sekil
{
    public Dikdortgen(int en, int boy) : base(boy, en)
    {

    }
    public override int AlanHesapla()
    {
        return boy * en;
    }
}
#endregion