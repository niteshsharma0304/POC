using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobLinkDescriptionPOC.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult GetJobDescription()
        {
            ViewBag.Title = "JobDescription";
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
