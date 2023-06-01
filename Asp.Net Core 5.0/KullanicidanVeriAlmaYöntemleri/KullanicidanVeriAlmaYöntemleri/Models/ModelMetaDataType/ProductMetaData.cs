using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace KullanicidanVeriAlmaYöntemleri.Models.ModelMetaDataType
{
    public class ProductMetaData
    {
        [Required(ErrorMessage = "Lütfen Product Name'i giriniz.")]
        [StringLength(100, ErrorMessage = "Lütfen product namei 100 karakter giriniz.")]
        public string Name { get; set; }
        
        [EmailAddress(ErrorMessage = "Lütfen doğru bir email adresi giriniz.")]
        public string Email { get; set; }
    }
}
