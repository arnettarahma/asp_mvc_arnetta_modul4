using System;
using System.Collections.Generic;
using System.Web.Mvc;
using asp_mvc_arnetta_modul3.Security;

namespace asp_mvc_arnetta_modul3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Welcome()
        {
            return View();
        }
        [AuthorizeRoles("Admin")]
        public ActionResult AdminOnly()
        {
            return View();
        }
        public ActionResult UnAuthorized()
        {
            return View();
        }
    }
}