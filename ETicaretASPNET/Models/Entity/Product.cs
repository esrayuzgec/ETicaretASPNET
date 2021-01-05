using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicaretASPNET.Models.Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string PImage { get; set; }
        public bool IsHome { get; set; }//ürün anasayfada mı
        public bool IsApproved { get; set; }// ürün onaylı mı? true olursa kullanıcılar görür false ise sadece admin görür.
        public bool IsFeatured { get; set; }//Öneçıkanlar.
        public int CategoryID { get; set; }//Yabancıl Anahtar.
        public virtual Category Category { get; set; }

    }
}