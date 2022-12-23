using System;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace duzenli_ifadeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Regular Expression Operatoru
            //^ Operatorü : Satır basşının istenilen ifade ile başlamasını sağlayan operatordur.

            //^9 : yazı 9 ile başlamalı 9dasfaf, 955**//, 13245, askdafs

            //string text = "91315145asdasfagfsd";
            //Regex regex = new Regex("^91");
            //Match match = regex.Match(text);

            //Console.WriteLine(match.Success);//true döndü

            #endregion
            #region \ Operatoru
            //\     : Belirli karakter gruplarını içermesini isityorsak kullanırız.

            /*
             \D     : Metinsel değerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiğini belirtir.
             \d     : Metinsel değerin ilgili yerinde 0 - 9 arasında tek bir rakam olmasını belirtir.      
             
             \W     : Metinsel değerin ilgili yerinde alfanümerik olmayan karaketrin olması gerektiğini belirtir. Alfanumerik karakterler : a - z  A - Z 0 - 9
             \w     : Metinsel değerin ilgili yerinde alfanümerik olan karakterin olacağı ifade edilir.
             
             \S     : Metinsel değerin ilgili yerinde boşluk karakterleri(tab/space) dışında herhangi bir karakterin olamayacağını belirtir.
             \s     : Metinsel değerin ilgili yerinde sadece boşluk karakterinin olacağını ifade eder.

             Örn;
             9 ile başlayan, ikinci karakteri herhangi bir sayı olan ve sonraki karakteri de boşluk olmayan bir düzenli ifade oluşturalım
            ^9/d/S
             */
            //string text = "98465asdasf";

            //Regex regex= new Regex(@"^9\d\S");
            //Match match = regex.Match(text);

            //Console.WriteLine(match.Success);
            #endregion
            #region + Operaörü
            //Belirtilen gruptaki karakterlerden bir yada daha fazlasının olmasını istiyorsak kullanılan operatördür.
            //9 ile başlayan, arada herhangi bir sayısal değerleri olan ve son karakteri de boşluk olmayan bir düzenli ifade oluşturalım
            //^9\d\S

            //string text = "9 8656dasdasf ";

            //Regex regex= new Regex(@"^9\d+\S");
            //Match match= regex.Match(text);

            //Console.WriteLine(match.Success);


            #endregion
            #region  | Operatörü
            //Birden fazla karakter grubundan bir yada birkaçının ilgili yerde olabileceğini belirtmek istiyorsak mantıksal veya operatoru kullanılır.
            //Baş harfi a b veya c ile başlayan bir metinsel ifadeye bakalım
            //string text = "ahmety";

            //Regex regex= new Regex(@"a|b|c|A");
            //Match match = regex.Match(text);
            //Console.WriteLine(match.Success);
            #endregion
            #region {n} Operatörü
            //Sabit sayıda karakterin (adet) olmasını istiyorsak bu operatörü kullanırız

            //Telefon numarası kontrol 553-882-6863
            //\d\d\d-\d\d\d-\d\d\d\d
            //\d{3}-\d{3}-\d{4}

            //string text = "553-882-6863";

            //Regex regex = new Regex(@"\d{3}-\d{3}-\d{4}");
            //Regex regex1= new Regex(@"\d\d\d-\d\d\d-\d\d\d\d");//ameleus

            //Match matchmatch = regex.Match(text);
            //Match matchmatch1 = regex1.Match(text);

            //Console.WriteLine(matchmatch.Success);
            //Console.WriteLine(matchmatch1.Success);
            #endregion
            #region ? Operatörü
            //Bu karakterin önüne gelen karakter en fazla en az sıfır defa olabilmektedir

            //\d{3}b?A
            //A karakterinden önce en fzla 1 defa B karakteri gelecek
            //string text = "123BA";
            //Regex regex= new Regex(@"\d{3}B?A");

            //Match match = regex.Match(text);
            //Console.WriteLine(match.Success);
            #endregion
            #region . Operatörü
            // Kullanıldığı \n karakteri dışında her karakter bulunabilir
            //\d{3}.A 
            //3 sayı gelecek ardından herhangi bir karakter gelecek ve sonra A krarkteri gelecek
            //string text = "123?A";
            //Regex regex = new Regex(@"\d{3}.A");

            //Match match = regex.Match(text);
            //Console.WriteLine(match.Success);
            #endregion
            #region \b \B Operatörü
            //\B: Bu ifade ile kelimenin başında ve sonunda olmaması gerekn karakterleri belirtir.
            //\b: Bu ifade ilgili kelimenin sonunda hangi karakterin olması gerektiğini belirtir.

            //\d{3}dır\B  => 123dır, dır123
            //bunun basşında ve sonunda dır olmayacak


            //string text = "123";
            //Regex regex = new Regex(@"d{3}dır\B");

            //Match match = regex.Match(text);
            //Console.WriteLine(match.Success);
            #endregion
            #region [n] Operatörü
            //[n]   : Krakter aralığını belirtir
            //Ayrıca özel kraktrelerin yerinde yazılmasını da ifade eder

            //\d{3}[A-E]

            //(507) 751 45 92
            //[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}

            //string text = "123A", telephone = "(553) 882 68 63";

            //Regex regex= new Regex(@"\d{3}[A-E]");
            //Regex regexTelephone= new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}");

            //Match match = regex.Match(text);
            //Match match1 = regexTelephone.Match(telephone);

            //Console.WriteLine(match.Success);
            //Console.WriteLine(match1.Success);
            #endregion

            string telephone = "(553) 882 68 63";

            Regex regexTelephone = new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}");
            Match match1 = regexTelephone.Match(telephone);

            Console.WriteLine($"Success : {match1.Success}");
            Console.WriteLine($"Value : {match1.Value}"); // Sadece doğru olan kısmı döner
            Console.WriteLine($"Length : {match1.Length}");
            Console.WriteLine($"Index : {match1.Index}");

            Console.WriteLine(match1.Success);

        }
    }
}
