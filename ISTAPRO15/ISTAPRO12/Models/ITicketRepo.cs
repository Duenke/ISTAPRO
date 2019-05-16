using System.Linq;

namespace ISTAPRO12.Models
{
    public interface ITicketRepo
    {
        // Still can't wrap my head around why everything needs to be an Interface.
        IQueryable<Ticket> Tickets { get; }

        void AddNewTicket(Ticket ticket);

        Ticket DeleteTicket(int ticketID);
    }
}
