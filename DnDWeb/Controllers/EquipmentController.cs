using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DnDWeb.Models;
using Flurl.Http;

namespace DnDWeb.Controllers
{
    public class EquipmentController : Controller
    {
        // GET: EquipmentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EquipmentController/Details/5
        public ActionResult Details(string index)
        {
            string apiUri = $"https://www.dnd5eapi.co/api/equipment/{index}";
            var apiTask = apiUri.GetJsonAsync<Equipment>();
            apiTask.Wait();
            Equipment equipmentDetails = apiTask.Result;

            return View(equipmentDetails);
        }

        // GET: EquipmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquipmentController/Create
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

        // GET: EquipmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EquipmentController/Edit/5
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

        // GET: EquipmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EquipmentController/Delete/5
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
