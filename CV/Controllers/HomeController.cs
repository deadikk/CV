using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using CV.App_LocalResources;
using CV.Workers;

namespace CV.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            
            ViewBag.Title = Res.MyName;
            LogVisit(new XmlLogger());

            return View();
        }
        
        private static void LogVisit(ILogger logger)
        {
            try
            {
                logger.WriteLog($"Visit at {DateTime.UtcNow.ToShortDateString()} : {DateTime.UtcNow.ToLongTimeString()} - {System.Web.HttpContext.Current.Request.Url.AbsolutePath}");
            }
            catch
            {
                //ignore exception
            }
        }

    }
}