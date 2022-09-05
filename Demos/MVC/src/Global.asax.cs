using GroupDocs.Annotation.MVC.AppDomainGenerator;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace GroupDocs.Annotation.MVC
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Fix required to use several GroupDocs products in one project.
            // Set GroupDocs products assemblies names
            string annotationAssemblyName = "GroupDocs.Annotation.dll";
            // set GroupDocs.Annotation license
            DomainGenerator annotationDomainGenerator = new DomainGenerator(annotationAssemblyName, "GroupDocs.Annotation.License");
            annotationDomainGenerator.SetAnnotationLicense();

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}