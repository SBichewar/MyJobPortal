using BL;
using DAL;
using Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyJob.Controllers
{
    public class CityController : Controller
    {
        // GET: Taluka
        public ActionResult Index()
        {
            return View();
        }

        // GET: Taluka/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Taluka/Create
        public ActionResult Create()
        {
            ViewBag.Country = new SelectList(DbLib.GetCountryList(), "CountryId", "CountryName");

            return View();
        }

        // POST: Taluka/Create
        [HttpPost]
        public ActionResult Create(City f_City)
        {
           
                try
                {
                    DbLib f_DbLib = new DbLib();
                    f_DbLib.CreateCity(f_City);
                    return RedirectToAction("Create");
                }
                catch
                {
                    return View();
                }
            
        }

        // GET: Taluka/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Taluka/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, City f_City)
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

        // GET: Taluka/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Taluka/Delete/5
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
        public string GetStateByContryId(string StateId)
        {
            IEnumerable<TblDist> DistList = DbLib.GetDistListByStateId(Convert.ToInt32(StateId));
            string s = JsonConvert.SerializeObject(DistList);
            return s;
        }

        [HttpGet]
        public string GetCityByDistId(string DistId)
        {
            IEnumerable<TblCity> CityList = DbLib.GetCityListByDistId(Convert.ToInt32(DistId));
            string s = JsonConvert.SerializeObject(CityList);
            return s;
        }
        
    }
}
