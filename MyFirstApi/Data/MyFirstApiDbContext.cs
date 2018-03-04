using Microsoft.EntityFrameworkCore;
using MyFirstApi.Models;

namespace MyFirstApi.Data
{
    public class MyFirstApiDbContext : DbContext
    {
        public MyFirstApiDbContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}