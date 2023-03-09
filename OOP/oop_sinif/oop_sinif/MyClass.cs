using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_sinif
{
    public class MyClass
    {
        public int a;
        #region Full Property
        //field isimleri küçük property isimleri büyük harfle başlamalıdır.
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}
        #endregion
        #region property
        //prop imzalarda field oluşturmamıza gerek yok o arka planda kendisine bir field oluşturuyor
        // public int fieldAgerekYok { get; set; } = 10;
        //prop propertyler readonly olabilir ama writeonly olamaz çünkü writeonly olduğunda sadece yazılacak ama buna hiçbiryerden erişemeyeceğim için engellenmiş
        //readonly olmasının sebebş şse prop ilk oluşturulurken değer atayabilme durumuzu olması

        #endregion
        #region Ref Property
        //Bu property de oluşturduğumuz field ın sadece referansını dönerek stack üzerindeki veriyi azaltıyoruz.
        //private string isim = "zafer";

        //public ref readonly  string MyProperty => ref isim;
        #endregion
        #region Inıt Only Prop
        //nesnenin sadece ilk oluşturulma anında değere atılmasının sağlar constructor da diyebiliriz.
        //Getter only properties den farkı nesne ilk oluşturulurken değer atanmasını sağlar.
        //public int MyProperty { get; init; }
        #endregion
        #region class içersinde tanımlanan class bir class elemanı mıdır?
        //public class MyClass2
        //{

        //}
        //hayır değildir.
        #endregion
        #region Class elemanlarına açıkalma satırı nasıl eklenir?
        /// <summary>
        /// bu bir field dır. Bir Class elemanıdır.
        /// </summary>
        //public int b;
        #endregion
    }
}
