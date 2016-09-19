using System;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Threading;
using System.Web.Mvc;
using WebGrease.Css.Ast.Selectors;

namespace CV.Controllers
{
    public class BaseController : Controller
    {

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            var langCode = 
                requestContext.RouteData.Values["lang"] == null ? 
                string.Empty : 
                    requestContext.RouteData.Values["lang"] as string ?? 
                    string.Empty;

            var userBrowserLanguages = requestContext.HttpContext?.Request?.UserLanguages;
            if (userBrowserLanguages != null && (langCode == string.Empty && userBrowserLanguages.Any()))
            {
                langCode = userBrowserLanguages[0].Substring(0,2);
            }


            var fullLangCode = GetLocalization(langCode);

            var ci = new CultureInfo(fullLangCode);
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(ci.Name);

            base.Initialize(requestContext);
        }

        private static string GetLocalization(string code)
        {
            string result;

            switch (code)
            {
                case "en":
                    result = "en-US";
                    break;
                case "ru":
                    result = "ru-RU";
                    break;
                case "ua":
                    result = "ru-RU";
                    break;
                default:
                    result = "ru-RU";
                    break;
            }

            return result;
        }

    }
}