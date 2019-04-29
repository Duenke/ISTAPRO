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
        public TicketRepo controllerRepo = TicketRepo.updateableRepo;

        public IActionResult Index() => View();

        public IActionResult HasBeenSubmitted() => View();

        [HttpGet]
        public IActionResult SubmitTicket() => View(new Ticket());

        [HttpPost]
        public IActionResult SubmitTicket(Ticket t)
        {
            if (ModelState.IsValid)
            {
                t.TicketNum = controllerRepo.Tickets.Max(p => p.TicketNum) + 1;
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
