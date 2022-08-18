using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using GroupDocs.Annotation.AspNetMvc.App_Start;
using GroupDocs.Annotation.AspNetMvc.Products.Annotation.Annotator;

namespace GroupDocs.Annotation.AspNetMvc
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            string licensePath = "";
            SetLicense license = new SetLicense();
            license.Set_License(licensePath);

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}