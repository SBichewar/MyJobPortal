using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BL;
using Common;
using System.IO;

namespace MyJob.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialHeadInfor()
        {
            if (Session["UserId"] != null)
            {
                int f_UserId = Convert.ToInt32(Session["UserId"]);
                DbLib f_DbLib = new DbLib();
                ProfileHeader f_User = f_DbLib.ProfileHeader(f_UserId);
                ViewBag.UserInfo = f_User;
                return PartialView("PartialHeaderInfor", ViewBag.UserInfo);
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        public ActionResult PartialProfileSummer()
        {
            if (Session["UserId"] != null)
            {
                int f_UserId = Convert.ToInt32(Session["UserId"]);
                return PartialView("ParrialprofileSummery");
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        public ActionResult PartialkeySkill()
        {
            if (Session["UserId"] != null)
            {
                int f_UserId = Convert.ToInt32(Session["UserId"]);
                return PartialView("PartialkeySkill");
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        public ActionResult PartialEmployment()
        {
            if (Session["UserId"] != null)
            {
                int f_UserId = Convert.ToInt32(Session["UserId"]);
                DbLib f_DbLib = new DbLib();
                Employement f_Employeement = f_DbLib.GetEmployeement(f_UserId);
                ViewBag.EmpInfor = f_Employeement;
                return PartialView("PartialEmployment");
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        public ActionResult PartialEducation()
        {
            if (Session["UserId"] != null)
            {
                int f_UserId = Convert.ToInt32(Session["UserId"]);
                DbLib f_DbLib = new DbLib();
                Education f_Education = f_DbLib.GetEducationDetails(f_UserId);
                ViewBag.f_Education = f_Education;
                return PartialView("PartialEducation", ViewBag.f_Education);
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        public ActionResult PartialProjects()
        {
            if (Session["UserId"] != null)
            {
                int f_UserId = Convert.ToInt32(Session["UserId"]);
                return PartialView("PartialProjects");
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        public ActionResult ParrialprofileSummery()
        {
            if (Session["UserId"] != null)
            {
                int f_UserId = Convert.ToInt32(Session["UserId"]);
                return PartialView("ParrialprofileSummery");
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        [HttpPost]
        public ActionResult PartialAddSkill(TblSkillSet f_SkillSet)
        {
            if (Session["UserId"] != null)
            {
                int f_UserId = Convert.ToInt32(Session["UserId"]);
                DbLib f_DbLib = new DbLib();
                f_DbLib.AddSkill(f_SkillSet);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        [HttpGet]
        public ActionResult GetPartialSkill()
        {
            if (Session["UserId"] != null)
            {
                int f_UserId = Convert.ToInt32(Session["UserId"]);
                return PartialView("PartialAddSkill");
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        [HttpPost]
        public ActionResult PartialAddProjects(TblProject f_Project)
        {
            if (Session["UserId"] != null)
            {
               
                int f_UserId = Convert.ToInt32(Session["UserId"]);
                DbLib f_DbLib = new DbLib();
                f_DbLib.AddProject(f_Project);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        [HttpGet]
        public ActionResult GetPartialAddProjects()
        {
            if (Session["UserId"] != null)
            {
                ViewBag.Year = new SelectList(DbLib.GetYearList(), "Year", "Year");
                int f_UserId = Convert.ToInt32(Session["UserId"]);
                return PartialView("PartialAddProjects");
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        [HttpGet]
        public ActionResult GetPartialAddProfileSummery()
        {
            if (Session["UserId"] != null)
            {
                int f_UserId = Convert.ToInt32(Session["UserId"]);
                return PartialView("PartialAddProfileSummery");
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        [HttpPost]
        public ActionResult PartialAddProfileSummery(TblProfileSummery f_ProfileSummery)
        {
            if (Session["UserId"] != null)
            {
                int f_UserId = Convert.ToInt32(Session["UserId"]);
                DbLib f_DbLib = new DbLib();
                f_DbLib.AddProfileSummery(f_ProfileSummery);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        [HttpGet]
        public ActionResult GetPartialEmployeement()
        {
            if (Session["UserId"] != null)
            {
                int f_UserId = Convert.ToInt32(Session["UserId"]);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        [HttpGet]
        public ActionResult GetAddResumePartialView()
        {
            if (Session["UserId"] != null)
            {
                return PartialView("AddResumePartialView");
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
        [HttpPost]
        public ActionResult PartialAddResume(HttpPostedFileBase fileUpload1)
        {
            if (Session["UserId"] != null)
            {
                JobSeacker f_JobSeacker = new JobSeacker();
                var f_ResumeName = Path.GetFileName(fileUpload1.FileName);
                var f_ResumePath = Path.Combine(Server.MapPath("~/Resume"), Convert.ToInt32(Session["UserId"]) + f_ResumeName);
                fileUpload1.SaveAs(f_ResumePath);
                f_JobSeacker.UpdateResume(Convert.ToInt32(Session["UserId"]),  f_ResumeName);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("login", "login");
            }
        }
    }
}