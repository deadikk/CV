using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Workers;

namespace CV.Views.Home
{
    public class AdminPanelController : Controller
    {
        [Route("GetVisitsCount")]
        public ActionResult GetVisitsCount()
        {
            ViewBag.Visits = GetVisits();
            ViewBag.HideMenu = true;
            return View("Index");
        }

        private int GetVisits()
        {
            var logger = new XmlLogger();
            return logger.GetVisits();
        }
    }
}