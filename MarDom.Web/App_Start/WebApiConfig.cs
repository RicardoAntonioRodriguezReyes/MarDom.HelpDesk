using System.Net.Http.Headers;
using System.Web.Http;

namespace MarDom.Web.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            configuration.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            configuration.Routes.MapHttpRoute(
name: "API Default",
routeTemplate: "api/{controller}/{action}/{id}",
defaults: new { id = RouteParameter.Optional });
        }
    }
}