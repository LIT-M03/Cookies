using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int value = 0;
            if (Request.Cookies["number"] != null)
            {
                value = int.Parse(Request.Cookies["number"].Value);
            }

            HttpCookie cookie = new HttpCookie("number", (value + 1).ToString());
            Response.Cookies.Add(cookie);

            return View(value);
        }

    }
}
