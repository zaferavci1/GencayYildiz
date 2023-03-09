Console.WriteLine("Yasinizi giriniz");
DateTime time = Convert.ToDateTime(Console.ReadLine());
DateTime now = DateTime.Now;
int kalan = now.Year - time.Year;
Console.WriteLine($"yaşınız: {kalan}");