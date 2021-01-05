using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicaretASPNET.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string PImage { get; set; }
       
        public int CategoryID { get; set; }//Yabancıl Anahtar.  :(
    }
}