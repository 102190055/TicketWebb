using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketWeb.Data;

namespace TicketWeb.Views.BookTicket
{
    public class BookTicketController : Controller
    {
        private TicketWebContext _dbContext;

        public BookTicketController(TicketWebContext dbCOntext)
        {
            _dbContext = dbCOntext;
        }
        // GET: BookTicketController
        public ActionResult Index(int start, int end)
        {
            var listFlight = _dbContext.ChuyenBays.Where(s => s.SanBayDen_ID == start && s.SanBayDi_ID == end);
            return View(listFlight.ToList());
        }

        // GET: BookTicketController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookTicketController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookTicketController/Create
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

        // GET: BookTicketController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookTicketController/Edit/5
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

        // GET: BookTicketController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookTicketController/Delete/5
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
