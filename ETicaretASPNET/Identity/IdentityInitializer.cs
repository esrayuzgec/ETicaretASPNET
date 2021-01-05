using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace ETicaretASPNET.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {

            if (!context.Roles.Any(i => i.Name == "Admin"))
            {

                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "Admin", Description = "Admin Rolü" };
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {

                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "User Rolü" };
                manager.Create(role);
            }

            if (!context.Users.Any(i => i.Name == "Esra Yüzgeç"))
            {

                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "Esra", Surname = "Yüzgeç", Email = "esrayuzgec0@gmail.com", UserName = "esrayuzgec" };
                manager.Create(user,"esrayuzgec12345");
                manager.AddToRole(user.Id, "Admin");
                manager.AddToRole(user.Id, "User");
            }

            if (!context.Users.Any(i => i.Name == "Merve Erdoğan"))
            {

                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "Merve", Surname = "Erdogan", Email = "merveee2@gmail.com", UserName = "merveerdogan" };
                manager.Create(user, "merveerdogan12345");
              
                manager.AddToRole(user.Id, "User");
            }

            base.Seed(context);
        }

    }
}