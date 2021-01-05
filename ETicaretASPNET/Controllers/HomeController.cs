using ETicaretASPNET.Models;
using ETicaretASPNET.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaretASPNET.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DataContext db = new DataContext(); // veritabanı bağlantısı      
        public ActionResult Index()
        {
            var urun = db.Products.Where(i => i.IsHome && i.IsApproved).Select(i => new ProductModel() {

                ProductID = i.ProductID,
                ProductName = i.ProductName,
                ProductDescription = i.ProductDescription.Length > 25 ? i.ProductDescription.Substring(0, 25) + "..." : i.ProductDescription,
                Price = i.Price,
                Stock = i.Stock,
                PImage = i.PImage,
                CategoryID = i.CategoryID


            }).ToList();//Anasayfada ürünleri listele
            return View(urun);
        }
        public PartialViewResult FeaturedProductList()
        {
            return PartialView(db.Products.Where(x=>x.IsFeatured && x.IsApproved).ToList());
        }

        public ActionResult Search(string q)
        {
            var p = db.Products.Where(i => i.IsApproved == true);
            if (!string.IsNullOrEmpty(q)) {
                p = p.Where(i => i.ProductName.Contains(q)||i.ProductDescription.Contains(q));

            }
            return View(p.ToList());
        }

        public ActionResult ProductList(int id)
        {
            return View(db.Products.Where(i=>i.CategoryID==id).ToList());
        }
        public ActionResult ProductDetails(int id)
        {
            var product = db.Products.Where(i => i.ProductID == id).FirstOrDefault();
            return View(product);

        }
        public ActionResult Product()
        {
            return View(db.Products.ToList());
        }



    }
}