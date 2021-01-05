using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ETicaretASPNET.App_Start.Startup1))]

namespace ETicaretASPNET.App_Start
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions()
            // LOGİN LOGOUT İŞLEMKERİ COOKİE BAZLI ÇALIŞIR
            {
                AuthenticationType = "ApplicationCookie", //HANGİ TİP COOKİE İLE İŞLEM YAPACAĞINI BELİRLER
                LoginPath = new PathString("/Account/Login")//KULLANİCİ YETKİSİ OLMAYAN BİR ALANA ERİŞMEK İSTEDİĞİNDE YÖNLENDİRİLEN DEFAULT SAYFASIDIR.


            });
            
            }
    }
}
//  OWİN NEDİR?
//open web interface for  .Net ,.Net uygulaması ile .net sunucusunun birbirinden ayrılması için oluşturulmuş yapıları barındıran bir interfacetir.
//Çalıştığı ortamdan bağımsızdır