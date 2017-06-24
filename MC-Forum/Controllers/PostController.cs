using MC_Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MC_Forum.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Submit_Post()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit_Post(Post post)
        {

            if (Session["UserId"] != null)
            {
                if (ModelState.IsValid)
                {
                    using (OurDbContext db = new OurDbContext())
                    {
                        post.ID = (int) Session["UserId"];
                        db.Post.Add(post);
                        db.SaveChanges();
                    }
                    ModelState.Clear();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View("Login", "Account");
            }

        }
    }
}