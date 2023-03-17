#region Polimorfizm Nedir?
/*      Polimorfizm Nedir?
 * polimmorfizm esasında kalıtım gibi bir biyolojik terimdir.
 *      OOP'de poliformizm ise
 *   Bir nesnenin birden fazla farklı türdeki referans tarafından işaretlenebilmesidir.
 *   Polimorfizm bir nesnenin kalıtımsal olarak ilişkisi olan diğer nesnelerin referansıyla işaretlenebilmesidir.
 *   
 *   
 *   A a = new B(); Buradaki durum bize Sağ/Sol dengesini ezip daha ileriye gitmemizi sağlıyor.

       class A
        {

        }

      class B:A
        {

        }

    Bir nesnenin birden fazla referans ile işaretlenebilmesi, o nesnenin birden fazla türün davranişlarını 
    gösterebilmesini sağlar.
 *
 */

//A a1 = new B();
//class A
//{

//}

//class B : A
//{

//}

#endregion
#region Polimorfizm Durumlarında Tür Dönüşümleri
/*
 * Polimorfizm de bizim şu ana kadar öğredniğimiz durum olan, bize sağ sol eşitliğinin ezilebilirliğinden yararlnamamızı 
 *      sağlayan bi olay diyebiliriz.
 * Tür dönüşümünde aşağıdaki örenkelerden yanlarındaki notlar ile devam edelim.
 * 
 */
A a = new C();//Bu bize polimorfizmin getirdiği bir durumdur.
B b = new C();// Polimorfizm

C c = new A(); // Bu durum olmaz burada biz artık bir tür dönüşümüne ihtiyacımız var 

C c1 = (C)a; // Burada cast operatörü ile birlikte bilinçli bir tür dönüşümü gerçekleştirdik.
// A a = new C(); buradaki durumda ise bilinçsiz bir tür dönüşümü görüyoruz
class A
{

}
class B:A
{

}
class C:B
{

}




#endregion