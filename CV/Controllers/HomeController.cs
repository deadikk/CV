using System.Web.Mvc;
using CV.App_LocalResources;

namespace CV.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.Title = Res.MyName;
            return View();
        }

    }
}