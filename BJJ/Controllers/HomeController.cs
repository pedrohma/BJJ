using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using BJJ.Models;
using BJJ.Persistence;

namespace BJJ.Controllers
{
    public class HomeController : Controller
    {
        AcademyDB db = new AcademyDB();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignUp(Academy academy)
		{
            string value = "";
            if(academy != null){
                value = db.addAcademy(academy);
            }
            if(value != "Success"){
                throw new Exception(value);
            }

            return View("Home");
		}
    }
}
