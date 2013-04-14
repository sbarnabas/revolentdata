using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RevolentData
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
     
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //allow viewing json in the browser by default
            GlobalConfiguration.Configuration.Formatters[0].SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            
            var data= new programs();
            var connstr = @"mongodb://revolent:stackpinion@ds035607.mongolab.com:35607/revolentdata";
            var client = new MongoDB.Driver.MongoClient(connstr);
            var server = client.GetServer();
            var db = server.GetDatabase("revolentdata");
            var coll = db.GetCollection<programsProgram>("movies");
            var cursor = coll.FindAll();
            data.program = cursor.ToList().ToArray();
            Application["data"] = data;


            //factual api info
            Application["factkey"] = "UVz7N3cX8wHDYon4dHoVfmj8kzYL3sDVJ2SXn8Dl";
            Application["factsec"] = "Ok2lXgEde7JazbsbZBMSJ5bYmH0wbTLycB13TUZW";
        }
    }
}