using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        public DbSet<Room>? Rooms { get; set; }

        public DbSet<Person>? Persons { get; set; }

        public DbSet<Activity>? Activities { get; set; }

        public DbSet<PersonActivity>? PersonActivities { get; set; }

        public DbSet<Expense>? Expenses { get; set; }
    }
}
