using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleProject.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            ViewBag.ItemList = "Computer Shop Item List Page";

            return View();
        }
        public ActionResult Enquery()
        {
            ViewBag.text = "this is Enquery page";
            return View();
        }
        [HttpPost]
        public ActionResult form1(int id, string Name, string category, int price)
        {
            ViewBag.id = id;
            ViewBag.Name = Name;
            ViewBag.category = category;
            ViewBag.price = price;




            return View("Index");
        }
    }
}