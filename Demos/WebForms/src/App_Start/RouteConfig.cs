using Microsoft.AspNet.FriendlyUrls;
using System.Web.Routing;

namespace GroupDocs.Annotation.WebForms
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            routes.MapPageRoute(
             "Annotation",
             "",
             "~/Annotation.aspx"
         );
        }
    }
}
