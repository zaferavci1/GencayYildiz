//C#'ta tüm sınıflar object sınıfından türerler.
//Object'den bütün değerler türemeseinden dolayı bütün değerler object e atanabilir.
//Kalıtım alsa da almasa da
#region Name Hiding

class A
{
    public int X { get; set; }
}

class B : A
{
    public int X { get; set; } // Name hiding durummu burada derleyici anladı 
 // public new int X { get; set; } bu durumda biz name hiding olduğunu derleyiciye söylüyoruz ama günümüzde buna gerek 
}
#endregion
#region Recordlarda Kalıtım
/*
 * Recordlar sade ve sadece recordlardan kalıtım alabilir.
 * REcordlar sadece 1 redorddan kalıtım alabilir.
 * Classlardan kalıtım alamazlar.
 */
#endregion