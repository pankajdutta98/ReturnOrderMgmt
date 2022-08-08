using Microsoft.EntityFrameworkCore;

namespace ReturnOrderMgmtSystemV1.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
        public DbSet<User> user { get; set; }

        public DbSet<ProcessedOrderData> processedOrderData { get; set; }


    }
}
