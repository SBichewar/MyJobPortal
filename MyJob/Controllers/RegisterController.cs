using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using System.IO;
using  Common;
using BL;

namespace MyJob.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            ViewBag.Country = new SelectList(DbLib.GetCountryList(), "CountryId", "CountryName");
            return View();
        }
        [HttpPost]
        public ActionResult Index(User f_User, HttpPostedFileBase fileUpload, HttpPostedFileBase fileUpload1)
        {
            string f_ResumeName = null;
            string fileName = null;
            try {
                JobSeacker f_JobSeacker = new JobSeacker();
                TblUser f_TblUser = f_JobSeacker.UserRegister(f_User);
                if (fileUpload.ContentLength > 0)
                {
                    fileName = Path.GetFileName(fileUpload.FileName);
                    var path = Path.Combine(Server.MapPath("~/img"), f_TblUser.UserId+ fileName);
                    fileUpload.SaveAs(path);
                }
                if (fileUpload1.ContentLength > 0)
                {
                     f_ResumeName = Path.GetFileName(fileUpload1.FileName);
                    var f_ResumePath = Path.Combine(Server.MapPath("~/Resume"), f_TblUser.UserId + f_ResumeName);
                    fileUpload1.SaveAs(f_ResumePath);
                }
                f_JobSeacker.UserProfiePic(f_TblUser, fileName, f_ResumeName);
                return RedirectToAction("Create", "Education");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Create", "Education");
            }
        }
    }
}