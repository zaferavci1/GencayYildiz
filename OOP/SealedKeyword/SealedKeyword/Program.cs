/*
 * Bir sınıfın miras vermesini yahut bir başka deyişle başka bir sınıftan kalıtım almasını engelleyen keyword'dur.
 * Sadece sınıflarda ve override edilmiş metotlarda kullanılır. 
 */
sealed class A//sınıf ve sınıf fıtratında olan yapılanmalarda kullanılır.   
{

}

class B : A//hata verdi
{

}

sealed record C
{

}
#region Metot üzerinde Sealed keywordunun işlevi    
/*
 *  Kalıtımmsal durumlarda virtual olarak belirtilmiş bir metotun 1. dereceden kalıtım almış sınıf tarafından override 
 *       edilmiş memberın hiyerarşik olarak sonrakş sınfılarda tekrardan override edilmesini engellemk amacıyla
 *       kullanılır.
 */
class D
{
    public virtual void X()
    {
        Console.WriteLine("Merhaba D");
    }
}
class E : D
{
    sealed public override void X()
    {
        Console.WriteLine("Merhaba E");
    }
}
class F : E
{
    public override void X()// hata verdi. Ama bizşm F class ımızda bir X memberımız var tabiki.
    {
        Console.WriteLine("merahba F");
    }
}
#endregion