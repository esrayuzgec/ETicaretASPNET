using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ETicaretASPNET.Models.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {

                new Category(){CategoryName="Solmayan Gül",Description="Solmayan Güller"},
                new Category(){CategoryName="Orkide",Description="Orkide Çeşitleri"}



            };
            foreach(var item in kategoriler)
            {

                context.Categories.Add(item);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {

                new Product(){ProductName="Siyah Solmayan Gül",ProductDescription="Solmayan Güller",Price=2500,Stock=50,IsHome=true,CategoryID=1,PImage="fanus_siyah.jpg",IsApproved=true,IsFeatured=false},
                new Product(){ProductName="Yeşil Solmayan Gül",ProductDescription="Solmayan Güller",Price=2000,Stock=62,IsHome=true,CategoryID=1,PImage="fanus_yesil.jpg",IsApproved=true,IsFeatured=false},
                new Product(){ProductName="Mavi Orkide",ProductDescription="Sevdiklerinizi mutlu edin.",Price=2000,Stock=62,IsHome=false,CategoryID=2,PImage="orkide_mavi.jpg",IsApproved=true,IsFeatured=false}


            };
            foreach(var item in urunler)
            {
                context.Products.Add(item);

            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}