using Microsoft.EntityFrameworkCore;
using PizzkaTime.Database.Models;

namespace PizzkaTime.Database
{
    public class PizzkaDbContext : DbContext
    {
        public PizzkaDbContext(DbContextOptions<PizzkaDbContext> options) : base(options) 
        {
            
        }

        DbSet<Slice> Slices { get; set; }

        DbSet<Dish> Dishes { get; set; }

        DbSet<User> Users { get; set; }

        DbSet<Restaurant> Restaurants { get; set; }
    }
}
