using KullanicidanVeriAlmaYöntemleri.Models.ModelMetaDataType;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace KullanicidanVeriAlmaYöntemleri.Models
{
    [ModelMetadataType(typeof(ProductMetaData))]

    public class Product
    {
        //Validation tanımlama şansımız var ama tanımlamayı önermiyorlar
        //[Required(ErrorMessage ="Lütfen Product Name'i giriniz.")]
        //[StringLength(100,ErrorMessage ="Lütfen product namei 100 karakter giriniz.")]
        public string Name { get; set; }
        public int Quantity { get; set; }
        //[EmailAddress(ErrorMessage ="Lütfen doğru bir email adresi giriniz.")]
        public string Email { get; set; }

    }
}
