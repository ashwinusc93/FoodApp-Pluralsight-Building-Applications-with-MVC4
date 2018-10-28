using FoodApp2.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodApp2.Controllers
{
    // Action and Controller Level Filters [Authorize]
    [Log]
    public class CuisineController : Controller
    {
        public ActionResult Search(string name = "french")
        {
            throw new Exception("Application Error");

            var message = Server.HtmlEncode(name);

            //Action Result
            //return File(Server.MapPath("~/Content/site.css"), "text/css");
            //return Json(new { Message = message, Name = "Ash" }, JsonRequestBehavior.AllowGet);

            return Content(message);
        }
    }
}