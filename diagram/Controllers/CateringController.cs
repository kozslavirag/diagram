using diagram.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace diagram.Controllers
{
    public class CateringController : Controller
    {
        // GET: CateringController
        public ActionResult Index()
        {
            List<CateringModel> cateringDataToChart = new List<CateringModel>();

            cateringDataToChart.Add(new CateringModel(1546300800, 91180));
            cateringDataToChart.Add(new CateringModel(1548979200, 22548));
            cateringDataToChart.Add(new CateringModel(1551398400, 87456));
            cateringDataToChart.Add(new CateringModel(1554076800, 45879));
            cateringDataToChart.Add(new CateringModel(1556668800, 11254));
            ViewBag.CateringModels = JsonConvert.SerializeObject(cateringDataToChart);
            return View();
        }

        // GET: CateringController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CateringController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CateringController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CateringController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CateringController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CateringController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CateringController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
