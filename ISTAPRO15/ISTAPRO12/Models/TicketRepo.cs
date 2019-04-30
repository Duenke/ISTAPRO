// Replaced with the EFTicketRepo when I swapped to an Entity Framework SQL Database.




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ISTAPRO12.Models
//{
//    public class TicketRepo
//    {
//        private static TicketRepo originalRepo = new TicketRepo();

//        private List<Ticket> ticketList = new List<Ticket>();

//        public static TicketRepo updateableRepo => originalRepo;

//        public IEnumerable<Ticket> Tickets => ticketList;

//        public TicketRepo()
//        {
//            Ticket[] initialTickets =
//            {
//                new Ticket { TicketID =01, SubmitDate ="4/14/2019", OpenDate ="4/15/2019", CloseDate ="4/16/2019", EmpID =01, CustID =01, CustName ="John Doe", CustEmail ="john.doe@gmail.com", Platform ="Windows10", Summary ="Can't do anything myself #1.", Issue ="Longer version of why I can't do anything myself.", Resolution ="It was an ID10T Error."},
//                new Ticket { TicketID =02, SubmitDate ="4/15/2019", OpenDate ="4/16/2019", CloseDate ="4/16/2019", EmpID =02, CustID =02, CustName ="Jane Doe", CustEmail ="jane.doe@gmail.com", Platform ="Windows10", Summary ="Can't do anything myself #2.", Issue ="Longer version of why I can't do anything myself.", Resolution ="It was an ID10T Error."},
//                new Ticket { TicketID =03, SubmitDate ="4/16/2019", OpenDate ="4/17/2019", CloseDate ="4/16/2019", EmpID =03, CustID =03, CustName ="Junior Doe", CustEmail ="junior.doe@gmail.com", Platform ="Windows10", Summary ="Can't do anything myself #3.", Issue ="Longer version of why I can't do anything myself.", Resolution ="It was an ID10T Error."},
//            };
//            foreach (Ticket t in initialTickets)
//            {
//                AddNewTicket(t);
//            }
//        }

//        public void AddNewTicket(Ticket t) => ticketList.Add(t);
//    }
//}
