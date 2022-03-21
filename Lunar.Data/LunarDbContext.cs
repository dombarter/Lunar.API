using Lunar.Models;
using Microsoft.EntityFrameworkCore;

namespace Lunar.Data
{
    public class LunarDbContext : DbContext
    {
        public DbSet<Moon> Moons { get; set; }

        public LunarDbContext(DbContextOptions<LunarDbContext> options): base(options) { }
    }
}
