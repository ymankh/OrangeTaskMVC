using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OrangeTaskMVC.Controllers
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
        [HttpPost]
        public ActionResult Contact(FormCollection form)
        {
            ViewBag.hasData = "true";
            ViewBag.name = form["name"];
            ViewBag.email = form["email"];
            ViewBag.message = form["message"];
            ViewBag.subject = form["subject"];

            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Services()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            string email = form["email"];
            string passward = form["password"];
            if (email == "test@test.test" && passward == "0000")
                Session["authantecated"] = "true";
            return RedirectToAction("Login");
        }
        public ActionResult Logout()
        {
            Session["authantecated"] = "false";
            return RedirectToAction("Index");
        }
        public ActionResult Login()
        {
            try
            {
                var x = (string)Session["authantecated"];
                if (x == "true")
                    return RedirectToAction("Index");
            }

            catch (Exception ex)
            { }

            return View();
        }
        public ActionResult Register()
        {
            var x = Session["authantecated"];
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}