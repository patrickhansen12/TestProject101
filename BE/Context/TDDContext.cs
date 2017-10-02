using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    class TDDContext : DbContext
    {
        static DbContextOptions<TDDContext> options =
            new DbContextOptionsBuilder<TDDContext>()
                .UseInMemoryDatabase("TheDB").Options;

        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
    }
}
