using System;
using System.Web.Http;
using System.Web.Routing;
using GroupDocs.Annotation.AspNetWebForms;
using GroupDocs.Annotation.AspNetWebForms.Products.Annotation.Annotator;

namespace GroupDocs.Annotation.AspNetWebForms
{
    public class Global : System.Web.HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            string licensePath = "";
            SetLicense license = new SetLicense();
            license.Set_License(licensePath); ;

            // Code that runs on application startup
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}