using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using BL;

namespace MyJob.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(Login p_Login)
        {
            DbLib f_dblib = new DbLib();
            int f_UserId = f_dblib.Login(p_Login);
            if (f_UserId>0)
            {
                Session["UserId"] = f_UserId;
                return RedirectToAction("Index","Home");
            }
            else {
                return View();
            }
        }
    }
}