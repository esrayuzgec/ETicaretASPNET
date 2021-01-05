using ETicaretASPNET.Models;
using ETicaretASPNET.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaretASPNET.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        DataContext db = new DataContext();
        public ActionResult Index()
        {
            return View(GetCart());
        }


        // GET: Sepete Ekle
         [HttpGet]
        public ActionResult AddToCart(int ProductID)
        {

            var product = db.Products.FirstOrDefault(i => i.ProductID == ProductID);
            if (product!=null)
            {
                GetCart().AddProduct(product, 1);
            }
            return RedirectToAction("Index");
        }


        //Sepetten Sil
        public ActionResult RemoveFromCart(int ProductID)
        {

            var product = db.Products.FirstOrDefault(i => i.ProductID == ProductID);
            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }
            return RedirectToAction("Index");
        }

 
       //Zaten bir sepet ve ürün varsa yeniden oluşturulmayı önle
        public Cart GetCart()
        {

            var cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }

            return cart;
        }

        public PartialViewResult Summary()
        {
            return PartialView(GetCart());
        }
        public ActionResult CheckOut()
        {

            return View(new ShoppingDetails());
        }

        [HttpPost]
        public ActionResult CheckOut(ShoppingDetails urun)
        {
            var sepet = GetCart();

            if (sepet.CartLines.Count == 0)
            {

                ModelState.AddModelError("Urun Yok","Sepetinizde ürün bulunmamaktadır");
            }
            if (ModelState.IsValid)
            {
                // alının ürünlerin veritabanına kaydedilmesi için
                sepet.Clear();
                return View("View");
            }
            else
            {
                return View(urun);
            }
           
        }

    }
}