using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using BL;

namespace MyJob.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult Index()
        {
            return View();
        }

        // GET: Education/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Education/Create
        public ActionResult Create()
        {
            ViewBag.Year = new SelectList(DbLib.GetYearList(), "Year", "Year");
            return View();
        }

        // POST: Education/Create
        [HttpPost]
        public ActionResult Create(TblEducation f_edgu)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    DbLib f_DbLib = new DbLib();
                    f_DbLib.CreateEducation(f_edgu);
                    return RedirectToAction("Create", "Employeement");
                }
                else
                {
                    return View(f_edgu);
                }
            }
            catch
            {
                return RedirectToAction("Create", "Employeement");
            }
        }

        // GET: Education/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Education/Edit/5
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

        // GET: Education/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Education/Delete/5
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
        [HttpGet]
        public string GetQualification()
        {
            DbLib f_DbLib = new DbLib();
            return JsonConvert.SerializeObject(f_DbLib.GetQualification());
        }
        [HttpGet]
        public string GetEducationType()
        {
            DbLib f_DbLib = new DbLib();
            return JsonConvert.SerializeObject(f_DbLib.GetEducationType());
        }
    }
}
