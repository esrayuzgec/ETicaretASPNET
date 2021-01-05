using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ETicaretASPNET.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız : ")]
        public string KulllaniciAdı { get; set; }
        [Required]
        [DisplayName("Soyadınız : ")]
        public string KulllaniciSoyadı { get; set; }
        [Required]
        [DisplayName("Kulanıcı Adı : ")]
        public string NickName { get; set; }
        [Required]
        [DisplayName("Mail Adresiniz: ")]
        [EmailAddress(ErrorMessage ="Geçerli Bir Mail Adresi Giriniz.")]
        public string KullanıcıMail { get; set; }
        [Required]
        [DisplayName("Sifreniz : ")]
        public string Sifre { get; set; }
        [Required]
        [DisplayName("Sifreniz Yeniden : ")]
        [Compare("Sifre", ErrorMessage ="Şifreler Aynı Değil.")]
        public string Sİfre2 { get; set; }
    }
}