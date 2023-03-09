


MyRecord myRecord = new MyRecord("zafer", 18);
var (m, y) = myRecord;



record MyRecord(string name,int yas)//burası constructor
    //bu semantik record özelliğidir
{
    //poisitonal record bizim constructor deconstructor larımızı daha rahat daha şemantik bir şekilde oluşturmamızı sağlıyor.
    /*
     * bu parametrelerin karşılığı compieler seviyesinde porpertyler otomatik oluşturulur.
     * bu propertyler oluşturulurken init şeklinde oluşturulur.
     * init nedir: bu recorddan nesne oluşturulurken object initialiezer seviyesinde değer atanacak ve bir 
     *      daha değeri değiştirilemeyecek.
     */

    public MyRecord():this("name",12)
    {
        
    }
    public MyRecord(string name):this()
    {
        
    }
}