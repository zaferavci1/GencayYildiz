/*
 * Nesneler arasında terminolojik olarak isimlendirilecek ilişki türleri vardır.
 * Bu ilişkiler kalıtım, referans yahut soyutlama gibi durumların getirisidir.
 * 
 */
#region is - a ilişkisi
/*
 * is - a ilişkisi tamamıyla kalıtımla alakalıdır. 
 * C# progalmalama dilinde iki sınıf arasında : (kalıtım) operatörü varsa orada bir is - a ilişkisi mevcuttur.
 * not.docx dosaysından örneklere bak. 
 */
#endregion
#region has - a ilişkisi
/*
 * Bir sınıfın bbaşka bir sınıfın nesnesine sahip olması durumudur.
 */
#endregion
#region can - do ilişkisi
/*
 * Interface yapılanmasını getirdiği bir ilişki türüdür.
 * Interface'ler içlerindeki imzaları class'lara uygulatmak zorunda olduğundan dolayı 
 *      uygulanan class'ın yapabileceklerini,kabiliyetlerini gösterdiği için bu ilişki çıkar.
 * Can do ilişkisi bir sınıfın kabiliyetlerini belirtmektedir. 
 */
#endregion
#region Association Nedir?
/*
 * Sınfılar arsındaki bağlantının zayıf olduğu durumlara verilen addır.
 * Bu bağlantı oldukça gevşektir.
 * yani sınıflar arsında bağlantı vardır ama birbirinden bağımsızdırlar.
 */
#endregion
#region Aggregation ve Composition
/*
 * Nesnelerin birleştirilip daha büyük bir nesne yapma haline denir.
 * her ikside bu durumu ifade eder.
 * her iskinde de sahiplik (has - a) ilişkisi vardır.
 *      
              Aggregation 
       Sahip olunan nesnenin, sahip olan nesneden bağımsız bir şekilde var olabilmesidir. 
       Yani bir nesne bir nesnenin sahibi(has a). Sahip nesne, sahip olduğu nesne olmadan var olamaz
           ama sahibi olan nesne(alt nesne ) kendi başına var olabilir.
             
             Composition
       Buradaki durum ise aggregation dan fark olarak alt nesne sahibi olunan nesne ile birlikte bir anlam kazanmaktadır.
       Buradaki parçalanma iki nesnenin de birbirinden ayrı bir şekilde var olmalarının bir anlam ifade etmeyeceğini gösterir.
 */
#endregion