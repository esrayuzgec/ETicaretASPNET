using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ETicaretASPNET.Models.Entity
{
    public class DataContext:DbContext//veritabanı oturum işlemlerini gerçekleştirip oluşturulan oturumlar üzerinden işlemlerin yapılmasını sağlar.
    {

        public DataContext() : base("dataConnection")
        {

            Database.SetInitializer(new DataInitializer());

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }




    }
}