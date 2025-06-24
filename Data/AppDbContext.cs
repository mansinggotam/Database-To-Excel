using DatabaseToExcel.Model;
using Microsoft.EntityFrameworkCore;

namespace DatabaseToExcel.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op) : base(op) { }
        public DbSet<Player> Players { get; set; }

    }
}
