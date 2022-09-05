using System.Web.Http;

namespace GroupDocs.Annotation.AspNetMvc.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // enable CORS
            config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}