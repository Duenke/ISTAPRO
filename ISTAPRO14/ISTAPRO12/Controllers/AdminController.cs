using ISTAPRO12.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTAPRO12.Controllers
{
    public class AdminController : Controller
    {
        public TicketRepo controllerRepo = TicketRepo.updateableRepo;

        public IActionResult Index() => View();

        public IActionResult NewTickets() => View(controllerRepo.Tickets.OrderBy(t => t.TicketNum));

        public IActionResult ViewTicket(int ticketNum) => View(controllerRepo.Tickets.FirstOrDefault(t => t.TicketNum == ticketNum));
    }
}