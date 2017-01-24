using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Temperaturas.Base;
using Temperaturas.Entidades;

namespace Temperaturas
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        void Application_BeginRequest(object sender, EventArgs e)
        {
            string url = Request.Url.LocalPath.ToLower();
            string[] newURL = new string[1];
            newURL[0] = "index.html";

            if (!System.IO.File.Exists(Context.Server.MapPath(url))
                    && !url.Contains("/api")
                    && !url.Contains("_browserlink"))
            {
                Context.RewritePath("~/index.html");
            }
        }

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            Database.SetInitializer<TemperaturasContexto>(null);

            TemperaturasContexto context = new TemperaturasContexto();

            List<Cidade> cidades = context.Cidades.ToList();     
        }
    }
}
