using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketWeb.Models;

namespace TicketWeb.Controllers
{
    //[Authorize(Roles = "Administrator")]
    public class FlightController : Controller
    {
        public IActionResult Index()
        {
            FlightIndexModel model = new FlightIndexModel();
            return View(model);
        }

    }
}
