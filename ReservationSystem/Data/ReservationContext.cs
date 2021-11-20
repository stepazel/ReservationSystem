using Microsoft.EntityFrameworkCore;
using ReservationSystem.Models;

namespace ReservationSystem.Data
{
    public class ReservationContext : DbContext
    {
        public ReservationContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Concert> Concerts { get; set; }
    }
}