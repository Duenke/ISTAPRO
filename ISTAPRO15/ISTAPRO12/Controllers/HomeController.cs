using ISTAPRO12.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTAPRO12.Controllers
{
    public class HomeController : Controller
    {
        public ITicketRepo controllerRepo;

        public HomeController(ITicketRepo repo) => controllerRepo = repo;

        public IActionResult Index() => View();

        public IActionResult HasBeenSubmitted() => View();

        [HttpGet]
        public IActionResult SubmitTicket() => View(new Ticket());

        [HttpPost]
        public IActionResult SubmitTicket(Ticket t)
        {
            if (ModelState.IsValid)
            {
                // Nuked this because EF & SQL assign TicketID as an Identity PK now.
                //t.TicketID = controllerRepo.Tickets.Max(p => p.TicketID) + 1;
                controllerRepo.AddNewTicket(t);
                return RedirectToAction("HasBeenSubmitted");
            }
            else
            {
                return View(t);
            }
        }
    }
}
