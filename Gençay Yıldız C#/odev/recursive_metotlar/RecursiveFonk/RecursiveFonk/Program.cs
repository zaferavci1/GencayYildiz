/*
 Recursive Fonk: Kendi içerisinde kendisini çağıran/tetikleyen fonksiyonlardır.
             Özyinelemeli/Tekrarlamalı Fonk.

            Recursive Fonk. bir yaklaşımdır.
            Kullanılması ve anlatılmsaı zordur.

            Recursive fonk. ne amaçla kullanılmaktadır?
            Öngörülemeyen, derinliği tahmin edilemeyen , sonu bilinmeyen durumlarda tercih edilebilir.
            Döngülerin kullanıldığı her yerde recusive kullanılır amm velakin recursive fonk. kullanıldığı her yerde döngüler kullanılamaz
 */
//komple main fonksiyonu burası







//x();

//void x(int a = 1)
//{
//    Console.WriteLine("merhaba");
//    if (a < 3)
//    {
//        x(++a);
//    }
//}

//void x(int a = 1)
//{
//    Console.WriteLine("merhaba");
//    if (a < 3)
//    {
//        x(++a);
//    }
//    Console.WriteLine("Dünya");
//}

//void x()
//{
//    Console.WriteLine("merhaba");
//    x();
//    Console.WriteLine("Dünya");
//}


#region Ornek 1
//Belirli değer aralığındaki 5in katı olan tüm sayıları toplayalaım.

//Console.WriteLine(Topla(20,30));

//int Topla(int baslangic,int bitis)
//{
//    if (baslangic % 5 == 0)
//        return baslangic + Topla(++baslangic, bitis);
//    if (baslangic < bitis)
//    {
//        return Topla(++baslangic, bitis);
//    }
//    return 0;
//}

#endregion
#region Örenek 2 Dosya isimleri getirme

//List<FileInfo> files = DosyaYazdir("C://Users//ZAFER//OneDrive//Masaüstü//DERSLER");
//foreach (var item in files)
//{
//    Console.WriteLine(item.FullName);
//}
//List<FileInfo> DosyaYazdir(string path)
//{
//    List<FileInfo> files = new();
//    DirectoryInfo directoryInfo = new(path);
//    DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
//    if(directoryInfos.Any())
//        foreach (DirectoryInfo item in directoryInfos)
//            files.AddRange(DosyaYazdir(item.FullName));
//    else
//    {
//        files.AddRange(directoryInfo.GetFiles());
//    }
//    return files;
//}

#endregion
