using ETicaretASPNET.Identity;
using ETicaretASPNET.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ETicaretASPNET
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer(new DataInitializer());

            var ctx = new DataContext();
            ctx.Database.Initialize(true);

            Database.SetInitializer(new IdentityInitializer());

            var ctx2 = new IdentityDataContext();
            ctx2.Database.Initialize(true);

        }
    }
}
