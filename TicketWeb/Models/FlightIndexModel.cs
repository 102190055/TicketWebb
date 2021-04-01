using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketWeb.Data;

namespace TicketWeb.Models
{
    public class FlightIndexModel
    {
        public List<Flight> Flights { get; set; }  
    }
    public class Flight { }
}
