using Microsoft.EntityFrameworkCore;
using Restaurator.Models;

namespace Restaurator.Data
{
    public class RestauratorDbContext : DbContext
    {
        public RestauratorDbContext(DbContextOptions<RestauratorDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
