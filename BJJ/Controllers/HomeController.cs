using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using BJJ.Models;

namespace BJJ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult SignUp(Academy academy)
		{
            if(academy != null){
                return RedirectToAction("/Home/Login");
            }
            return RedirectToAction("Login");
		}
    }
}
