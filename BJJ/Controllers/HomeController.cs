using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Services;
using BJJ.Models;
using BJJ.Persistence;

namespace BJJ.Controllers
{
    public class HomeController : Controller
    {
        AcademyDB db = new AcademyDB();
        Response response = new Response();

        public ActionResult Index()
        {
            return View();
        }

        [WebMethod]
        public ActionResult SignUp(Academy academy)
		{
            response.status = false;
            if(academy != null){
                response.message = db.addAcademy(academy);
				if (response.message != "Success")
				{
					throw new Exception(response.message);
				}
                else{
					response.message = academy.AcademyName + " singed up with success!";
					response.status = true;
                }
            }

            return Json(new { status = response.status, message = response.message }, JsonRequestBehavior.AllowGet);
		}

		[WebMethod]
		public ActionResult Login(Academy academy)
		{
			response.status = false;
			if (academy != null)
			{
                try{
					Academy academySession = db.FindAcademy(academy);
					if (academySession != null)
					{
						Session["Academy"] = academySession;
						response.status = true;
					}
					else
					{
						throw new Exception("Academy not found. Check your email and password and try again.");
					}
                }
                catch(Exception ex){
                    string error = ex.Message;
                    response.message = error;
                }
			}

			return Json(new { status = response.status, message = response.message }, JsonRequestBehavior.AllowGet);
		}
    }
}
