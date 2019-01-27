using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL;
using DAL;

namespace MyJob.Controllers
{
    public class StateController : Controller
    {
        // GET: State
        public ActionResult Index()
        {
            return View();
        }

        // GET: State/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: State/Create
        public ActionResult Create()
        {
            ViewBag.Country= new SelectList(DbLib.GetCountryList(), "CountryId", "CountryName");
            return View();
        }

        // POST: State/Create
        [HttpPost]
        public ActionResult Create(TblState f_State)
        {
            try
            {
                DbLib f_DbLib = new DbLib();
                f_DbLib.CreateState(f_State);
                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: State/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: State/Edit/5
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

        // GET: State/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: State/Delete/5
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
