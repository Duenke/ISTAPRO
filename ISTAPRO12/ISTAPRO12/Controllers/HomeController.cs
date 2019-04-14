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

        //public IActionResult Index() => View();

        [HttpGet]
        public IActionResult Index() => View(new Ticket());

        [HttpPost]
        public IActionResult Index(Ticket t)
        {
            controllerRepo.AddNewTicket(t);
            return RedirectToAction("HasBeenSubmitted");
        }
    }
}
