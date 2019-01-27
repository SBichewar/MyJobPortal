using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using BL;

namespace MyJob.Controllers
{
    public class HomeCompanyController : Controller
    {
        // GET: HomeCompany
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialCompanyHeadInfor()
        {
            var context = new MyJobPortalEntities();
            ViewBag.CompInfo = context.CompanyMsts.FirstOrDefault();
            return PartialView("PartialCompanyHeadInfor", ViewBag.CompInfo);
        }
        
        public ActionResult GetJobPost()
        {
            PostJobMst f_PostMst = new PostJobMst();
            return PartialView("PartialAddJobPost", f_PostMst);
        }
        public ActionResult GetJobPostForUpdate()
        {
            var context = new MyJobPortalEntities();
            PostJobMst f_PostMst = new PostJobMst();
            f_PostMst = context.PostJobMsts.FirstOrDefault();
            return PartialView("PartialUpdateJobPost", f_PostMst);
        }
        public ActionResult PartialComapnyJobPostList()
        {
            var context = new MyJobPortalEntities();
            List<PostJobMst> f_PostJobMst = context.PostJobMsts.ToList();
            return PartialView("PartialComapnyJobPostList", f_PostJobMst);
        }
        
        public ActionResult PartialAddJobPost(PostJobMst f_PostMst)
        {
            using (var context = new MyJobPortalEntities())
            {
                context.PostJobMsts.Add(f_PostMst);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult PartialUpdateJobPost(PostJobMst f_PostMst)
        {
            using (var context = new MyJobPortalEntities())
            {
                context.Entry(f_PostMst).State= EntityState.Modified;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteJobPost(PostJobMst f_PostMst)
        {
            using (var context = new MyJobPortalEntities())
            {
                context.PostJobMsts.Attach(f_PostMst);
                context.PostJobMsts.Remove(f_PostMst);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        //Comapay candidate search page section start

        public ActionResult CompanyCadidateLookupHome()
        {
            return View();
        }
        [HttpGet]
        public string GetJobSeackerList()
        {
            using (var context=new MyJobPortalEntities())
            {
                List<SekerMst> f_SekerMst = context.SekerMsts.ToList();
                return JsonConvert.SerializeObject(f_SekerMst);
            }
        }
        //Comapay candidate search page section start
    }
}

