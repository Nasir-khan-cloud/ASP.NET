using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public JavaScriptResult WarningMessage()
        {
            var msg = "alert('Are you sure want to Continue?');";
            return new JavaScriptResult() { Script = msg };
        }
        [HttpGet]
        public FileResult Download()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"D:\folder\mytxt.txt");
            string filename = "mytxt.txt";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, filename);
        }
        [HttpGet]
        public PartialViewResult messagepage()
        {
            return PartialView("message");
        }
        public ActionResult Enquiry()
        {
            return View();
        }
        public ActionResult Purchase()
        {
            return View();
        }
        public ActionResult DarkLayoutPage()
        {
            return View();
        }

    }
}