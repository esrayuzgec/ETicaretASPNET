using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ETicaretASPNET.Models
{
    public class Login
    {

        [Required]
        [DisplayName("Kulanıcı Adı : ")]
        public string NickName { get; set; }
        [Required]
        [DisplayName("Sifreniz : ")]
        public string Sifre { get; set; }
        public bool RememberMe { get; set; }
    }
}