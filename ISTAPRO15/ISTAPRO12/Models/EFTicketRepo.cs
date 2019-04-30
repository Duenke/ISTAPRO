﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTAPRO12.Models
{
    public class EFTicketRepo : ITicketRepo
    {
        // Copied template from the book...struggling with this EF stuff.
        private ApplicationDbContext context;

        public EFTicketRepo(ApplicationDbContext ctx) => context = ctx;

        public IQueryable<Ticket> Tickets => context.Tickets;

        public void AddNewTicket(Ticket ticket)
        {
            if (ticket.TicketID == 0)
            {
                context.Tickets.Add(ticket);
            }
            else
            {
                Ticket dbEntry = context.Tickets
                    .FirstOrDefault(p => p.TicketID == ticket.TicketID);
                if (dbEntry != null)
                {
                    dbEntry.SubmitDate = ticket.SubmitDate;
                    dbEntry.CustName = ticket.CustName;
                    dbEntry.CustEmail = ticket.CustEmail;
                    dbEntry.Platform = ticket.Platform;
                    dbEntry.Summary = ticket.Summary;
                    dbEntry.Issue = ticket.Issue;
                }
            }
            context.SaveChanges();
        }

        public Ticket DeleteTicket(int ticketID)
        {
            Ticket dbEntry = context.Tickets.FirstOrDefault(p => p.TicketID == ticketID);
            if (dbEntry != null)
            {
                context.Tickets.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}