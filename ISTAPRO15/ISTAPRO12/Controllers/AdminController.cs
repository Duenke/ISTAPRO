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
        public ITicketRepo controllerRepo;

        public AdminController(ITicketRepo repo) => controllerRepo = repo;

        public IActionResult Index() => View();

        public IActionResult NewTickets() => View(controllerRepo.Tickets.OrderBy(t => t.TicketID));

        public IActionResult ViewTicket(int ticketID) => View(controllerRepo.Tickets.FirstOrDefault(t => t.TicketID == ticketID));

        public IActionResult DeleteTicket(int ticketID)
        {
            controllerRepo.DeleteTicket(ticketID);
            return RedirectToAction("NewTickets");
        }
    }
}