using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrangeTaskMVC.Controllers
{
    public class Task2Controller : Controller
    {
        // GET: Task2
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(string name, string gender, string email, string phone, string country)
        {
            var user = new UserData()
            {
                Country = country,
                Phone = phone,
                Name = name,
                Email = email,
                Gender = gender
            };
            ViewBag.User = user;
            return View();
        }
    }
    public class UserData
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
    }
}