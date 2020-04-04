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
        public DbSet<Place> Places { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<PlaceMenuItem> PlaceMenuItems { get; set; }
        public DbSet<PlacePhoto> PlacePhotos { get; set; }
        public DbSet<PlaceInCirclePhoto> PlaceInCirclePhotos { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
