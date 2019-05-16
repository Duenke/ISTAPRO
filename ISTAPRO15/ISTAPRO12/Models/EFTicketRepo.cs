using System.Linq;

namespace ISTAPRO12.Models
{
    public class EFTicketRepo : ITicketRepo
    {
        // Copied template from the book...struggling with this EF stuff.
        private readonly ApplicationDbContext context;

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
                    dbEntry.OpenDate = ticket.OpenDate;
                    dbEntry.CloseDate = ticket.CloseDate;
                    dbEntry.CustName = ticket.CustName;
                    dbEntry.CustEmail = ticket.CustEmail;
                    dbEntry.Platform = ticket.Platform;
                    dbEntry.Summary = ticket.Summary;
                    dbEntry.Issue = ticket.Issue;
                    dbEntry.Resolution = ticket.Resolution;
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