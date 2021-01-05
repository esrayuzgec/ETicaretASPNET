using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ETicaretASPNET.Models
{
    public class ShoppingDetails
    {
        public string KulllaniciAdı { get; set; }

        [Required(ErrorMessage = "Lütfen Adres tanımını giriniz")]

        public string AdresBasligi { get; set; }
        [Required(ErrorMessage = "Lütfen Adres başlığını giriniz")]

        public string Adres { get; set; }
        [Required(ErrorMessage = "Lütfen Adres başlığını giriniz")]

        public string Semt { get; set; }
        [Required(ErrorMessage = "Lütfen Adres başlığını giriniz")]

        public string Mahalle { get; set; }
        [Required(ErrorMessage = "Lütfen Adres başlığını giriniz")]

        public string Postakodu { get; set; }
      


    }

}