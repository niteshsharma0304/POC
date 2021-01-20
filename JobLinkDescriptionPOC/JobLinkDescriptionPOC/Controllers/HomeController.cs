using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobLinkDescriptionPOC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult GetJobDescription()
        {
            ViewBag.Title = "JobDescription";
            return View();
        }
        public ActionResult GetParsedJobSkills()
        {
            ViewBag.Title = "ParsedJobSkills";
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
