using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreMVC_PS.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //Tables I want:
        public DbSet<Pie> Pies { get; set; }
    }
}