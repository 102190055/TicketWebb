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
    public class VeMayBayController : Controller
    {
        private TicketWebContext _dbContext;

        public VeMayBayController(TicketWebContext dbCOntext)
        {
            _dbContext = dbCOntext;
        }
        // GET: VeMayBayController
        public ActionResult Index()
        {
            var ListVeMayBay = _dbContext.VeMayBay.ToList();
            return View(ListVeMayBay);
        }
        // GET: VeMayBayController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VeMayBayController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VeMayBay collection)
        {
            if (ModelState.IsValid)
            {
                _dbContext.VeMayBay.Add(collection);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: VeMayBayController/Edit/5
        public ActionResult Edit(int id)
        {
            var editing = _dbContext.VeMayBay.Find(id);
            return View(editing);
        }

        // POST: VeMayBayController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VeMayBay model)
        {
            try
            {
                var oldItem = _dbContext.VeMayBay.Find(model.ID);
                oldItem.ID = model.ID;
                oldItem.ChuyenBay_ID = model.ChuyenBay_ID;
                oldItem.Loaive_ID = model.Loaive_ID;
                oldItem.TenKhach = model.TenKhach;
                oldItem.Cmnd = model.Cmnd;
                oldItem.NgaySinh = model.NgaySinh;
                oldItem.PhoneNumber = model.PhoneNumber;
                oldItem.Email = model.Email;
                oldItem.NguoiDat_ID = model.NguoiDat_ID;
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VeMayBayController/Delete/5
        public ActionResult Delete(int id)
        {
            var deleting = _dbContext.VeMayBay.Find(id);
            return View();
        }

        // POST: VeMayBayController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var deleting = _dbContext.VeMayBay.Find(id);
            if (deleting == null)
            {
                return View();
            }
            else
            {
                _dbContext.VeMayBay.Remove(deleting);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
