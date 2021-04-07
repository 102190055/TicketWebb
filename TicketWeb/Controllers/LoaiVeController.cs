using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketWeb.Data;
using TicketWeb.Models;

namespace TicketWeb.Controllers
{
    public class LoaiVeController : Controller
    {
        private TicketWebContext _dbContext;

        public LoaiVeController(TicketWebContext dbCOntext)
        {
            _dbContext = dbCOntext;
        }
        // GET: LoaiVeController
        public ActionResult Index()
        {
            var listLoaiVe = _dbContext.LoaiVe.ToList();
            return View(listLoaiVe);
        }

        // GET: LoaiVeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiVeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LoaiVe collection)
        {
            if (ModelState.IsValid)
            {
                _dbContext.LoaiVe.Add(collection);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: LoaiVeController/Edit/5
        public ActionResult Edit(int id)
        {
            var editing = _dbContext.LoaiVe.Find(id);
            return View(editing);
        }

        // POST: LoaiVeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LoaiVe model)
        {
            try
            {
                var oldItem = _dbContext.LoaiVe.Find(model.ID);
                oldItem.ID = model.ID;
                oldItem.Code = model.Code;
                oldItem.ChuyenBay_ID = model.ChuyenBay_ID;
                oldItem.Name = model.Name;
                oldItem.Price = model.Price;
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoaiVeController/Delete/5
        public ActionResult Delete(int id)
        {
            var deleting = _dbContext.LoaiVe.Find(id);
            return View(deleting);
        }

        // POST: LoaiVeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var deleting = _dbContext.LoaiVe.Find(id);
            if (deleting == null)
            {
                return View();
            }
            else
            {
                _dbContext.LoaiVe.Remove(deleting);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
