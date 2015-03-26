using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJSDemoWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Demo()
        {
            ViewBag.Title = "Angular Demo Page";

            return View();
        }

        [HttpPost]
        public JsonResult AjaxDemo(string Value1, string Value2)
        {
            return Value1 == Value2 ? Json(new { }) : Json(new { Id = 1, data = "Test Data" });
        }
    }
}
