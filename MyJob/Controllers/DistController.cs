using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
namespace MyJob.Controllers
{
    public class DistController : Controller
    {
        // GET: Dist
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dist/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dist/Create
        public ActionResult Create()
        {
            ViewBag.Country = new SelectList(DbLib.GetCountryList(), "CountryId", "CountryName");

            return View();
        }

        // POST: Dist/Create
        [HttpPost]
        public ActionResult Create(TblDist f_Dist)
        {
            try
            {
                DbLib f_DbLib = new DbLib();
                f_DbLib.CreateDist(f_Dist);
                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }

        }

        // GET: Dist/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dist/Edit/5
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

        // GET: Dist/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dist/Delete/5
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
        public string GetStateByContryId(string CountryId)
        {
            IEnumerable<TblState> Statelist = DbLib.GetStateListByCountryId(Convert.ToInt32(CountryId));
            string s = JsonConvert.SerializeObject(Statelist);
            return s;
        }
    }
}
