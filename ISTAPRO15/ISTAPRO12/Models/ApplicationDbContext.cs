﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace ISTAPRO12.Models
{
    public class ApplicationDbContext : DbContext
    {
        // Apparently "links" the ITicketRepo and the EFTicketRepo???
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Ticket> Tickets { get; set; }
    }
}