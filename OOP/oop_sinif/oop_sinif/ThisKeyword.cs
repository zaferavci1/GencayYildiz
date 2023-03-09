using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_sinif
{
    public class ThisKeyword
    {
        int a;
        #region this keywordu

        #region 1. Sınıfı temsil eder.
        public void X()
        {
            this.X();//burada her bu classın örneği oluşup bu metot çağrıldığında bu metot bir rekursive metota dönüşecek.
        }
        #endregion
        #region Aynı isimde Field ile mtot parametrelerini ayırmak için kullanılır.
        public void A(int a)
        {
            this.a = a; 
        }
        #endregion
        #endregion
    }
}
