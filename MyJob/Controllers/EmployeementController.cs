using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BL;
using Common;
using Newtonsoft.Json;

namespace MyJob.Controllers
{
    public class EmployeementController : Controller
    {
        // GET: Employeement
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employeement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employeement/Create
        public ActionResult Create()
        {
            ViewBag.AnualSalery = new SelectList(DbLib.GetAnualSaleryList(), "AnualSalery", "AnualSalery");
            ViewBag.AnualSaleryInThouset = new SelectList(DbLib.GetAnualSaleryInThousetList(), "AnualSaleryInThouset", "AnualSaleryInThouset");
            ViewBag.Year = new SelectList(DbLib.GetYearList(), "Year", "Year");
            return View();
        }

        // POST: Employeement/Create
        [HttpPost]
        public ActionResult Create(Employement p_Empl)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    DbLib f_DbLib = new DbLib();
                    f_DbLib.CreateEmpolyeement(p_Empl);
                    return RedirectToAction("Create");
                }
                else
                {
                    return RedirectToAction("Create");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Employeement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employeement/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employeement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employeement/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public string GetDistList()
        {
            IEnumerable<TblDist> CityList = DbLib.GetDistList();
            string s = JsonConvert.SerializeObject(CityList);
            return s;
        }
        
    }
}
