using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace ISTAPRO12.Models
{
    public class SeedData
    {
        // Moved manual TicketRepo.cs populator here for EF reasons.
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Tickets.Any())
            {
                context.Tickets.AddRange(
                    new Ticket { SubmitDate = "4/14/2019", OpenDate = "4/15/2019", CloseDate = "4/16/2019", EmpID = 01, CustName = "John Doe", CustEmail = "john.doe@gmail.com", Platform = "Windows10", Summary = "Can't do anything myself #1.", Issue = "Longer version of why I can't do anything myself.", Resolution = "It was an ID10T Error." },
                    new Ticket { SubmitDate = "4/15/2019", OpenDate = "4/16/2019", CloseDate = "4/16/2019", EmpID = 02, CustName = "Jane Doe", CustEmail = "jane.doe@gmail.com", Platform = "Windows10", Summary = "Can't do anything myself #2.", Issue = "Longer version of why I can't do anything myself.", Resolution = "It was an ID10T Error." },
                    new Ticket { SubmitDate = "4/16/2019", OpenDate = "4/17/2019", CloseDate = "4/16/2019", EmpID = 03, CustName = "Junior Doe", CustEmail = "junior.doe@gmail.com", Platform = "Windows10", Summary = "Can't do anything myself #3.", Issue = "Longer version of why I can't do anything myself.", Resolution = "It was an ID10T Error." }
                    );
                context.SaveChanges();
            }
        }
    }
}
