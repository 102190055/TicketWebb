using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using TicketWeb.Data;
using TicketWeb.Models;

namespace TicketWeb.Controllers
{
    //[Authorize(Roles = "admin")]
    public class FlightController : Controller
    {
        private TicketWebContext _dbContext;

        public FlightController(TicketWebContext dbCOntext)
        {
            _dbContext = dbCOntext;
        }
        // GET: FlightController
        
        public ActionResult Index()
        {
            var listFlight = _dbContext.ChuyenBays.ToList();
            return View(listFlight);
        }

        // GET: FlightController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ChuyenBay collection)
        {
            if(ModelState.IsValid)
            {
                _dbContext.ChuyenBays.Add(collection);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }           
                return View();           
        }

        // GET: FlightController/Edit/5
        public ActionResult Edit(int id)
        {
            var editing = _dbContext.ChuyenBays.Find(id);
            return View(editing);
        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ChuyenBay model)
        {
            try
            {
                var oldItem = _dbContext.ChuyenBays.Find(model.ID);
                oldItem.MaChuyenBay = model.MaChuyenBay;
                oldItem.MayBayID = model.MayBayID;
                oldItem.SanBayDen_ID = model.SanBayDen_ID;
                oldItem.SanBayDi_ID = model.SanBayDi_ID;
                oldItem.SoGhe_Hang1 = model.SoGhe_Hang1;
                oldItem.SoGhe_Hang2 = model.SoGhe_Hang2;
                oldItem.ThoiGianDuKienBay = model.ThoiGianDuKienBay;
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Delete/5
        public ActionResult Delete(int id)
        {
            var deleting = _dbContext.ChuyenBays.Find(id);
            return View(deleting);
        }

        // POST: FlightController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var deleting = _dbContext.ChuyenBays.Find(id);
                _dbContext.ChuyenBays.Remove(deleting);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


    }
}
