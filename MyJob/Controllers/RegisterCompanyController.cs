using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL;
using DAL;

namespace MyJob.Controllers
{
    public class RegisterCompanyController : Controller
    {
        // GET: RegisterCompany
        public ActionResult Index()
        {
            return View();
        }

        // GET: RegisterCompany/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegisterCompany/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegisterCompany/Create
        [HttpPost]
        public ActionResult Create(CompanyMst p_CompMst)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: RegisterCompany/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegisterCompany/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RegisterCompany/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegisterCompany/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
