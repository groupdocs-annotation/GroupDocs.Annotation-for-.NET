using GroupDocs.Annotation.WebForms.AppDomainGenerator;
using System;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace GroupDocs.Annotation.WebForms
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Fix required to use several GroupDocs products in one project.
            // Set GroupDocs products assemblies names
            string annotationAssemblyName = "GroupDocs.Annotation.dll";
            // set GroupDocs.Annotation license
            DomainGenerator annotationDomainGenerator = new DomainGenerator(annotationAssemblyName, "GroupDocs.Annotation.License");
            annotationDomainGenerator.SetAnnotationLicense();

            // Code that runs on application startup
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}