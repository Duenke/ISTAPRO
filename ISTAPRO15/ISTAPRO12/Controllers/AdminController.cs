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

        public IActionResult NewTickets() => View(controllerRepo.Tickets.Where(t => t.OpenDate == null).OrderBy(t => t.TicketID));

        public IActionResult OpenTickets() => View(controllerRepo.Tickets.Where(t => t.OpenDate != null && t.CloseDate == null).OrderBy(t => t.TicketID));

        public IActionResult ClosedTickets() => View(controllerRepo.Tickets.Where(t => t.CloseDate != null).OrderBy(t => t.TicketID));

        public IActionResult ViewNewTicket(int ticketID) => View(controllerRepo.Tickets.FirstOrDefault(t => t.TicketID == ticketID));

        public IActionResult ViewOpenTicket(int ticketID) => View(controllerRepo.Tickets.FirstOrDefault(t => t.TicketID == ticketID));

        public IActionResult ViewClosedTicket(int ticketID) => View(controllerRepo.Tickets.FirstOrDefault(t => t.TicketID == ticketID));

        public IActionResult PullTicket(int ticketID)
        {
            Ticket ticket = controllerRepo.Tickets.FirstOrDefault(t => t.TicketID == ticketID);
            if (ticket.OpenDate == null)
            {
                ticket.OpenDate = DateTime.Now.ToString();
            }
            return View(ticket);
        }

        [HttpPost]
        public IActionResult SaveTicket(int ticketID, string openDate, string resolution)
        {
            Ticket ticket = controllerRepo.Tickets.FirstOrDefault(t => t.TicketID == ticketID);
            ticket.OpenDate = openDate;
            ticket.Resolution = resolution;
            controllerRepo.AddNewTicket(ticket);
            return RedirectToAction("OpenTickets");
        }

        public IActionResult CloseTicket(int ticketID)
        {
            Ticket ticket = controllerRepo.Tickets.FirstOrDefault(t => t.TicketID == ticketID);
            ticket.CloseDate = DateTime.Now.ToString();
            controllerRepo.AddNewTicket(ticket);
            return RedirectToAction("ClosedTickets");
        }

        public IActionResult DeleteTicket(int ticketID)
        {
            controllerRepo.DeleteTicket(ticketID);
            return RedirectToAction("NewTickets");
        }
    }
}