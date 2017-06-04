using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MC_Forum.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            if(Session["UserId"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}