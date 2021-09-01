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

            cateringDataToChart.Add(new CateringModel(1, 91180, new DateTime(2021, 1,1).ToString("yyyy.MM.dd")));
            cateringDataToChart.Add(new CateringModel(2, 22548, new DateTime(2021, 2, 1).ToString("yyyy.MM.dd")));
            cateringDataToChart.Add(new CateringModel(3, 87456, new DateTime(2021, 3, 1).ToString("yyyy.MM.dd")));
            cateringDataToChart.Add(new CateringModel(4, 45879, new DateTime(2021, 4, 1).ToString("yyyy.MM.dd")));
            cateringDataToChart.Add(new CateringModel(5, 11254, new DateTime(2021, 5, 1).ToString("yyyy.MM.dd")));
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
