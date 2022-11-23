using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\keith\OneDrive\Desktop\log.txt", text);
            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //if (num > 200000)
            //{
            //    return View("About");
            //}

            //return View();

            //return Content("Hallo");

            //List<string> names = new List<string>
            //{
            //    "Keith",
            //    "Alan",
            //    "Moore"
            //};
            //return View(names);

            User user = new User();
            user.Id = 1;
            user.firstName = "Keith";


            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid Page");
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}