using Artemis_Shield.Models;
using Microsoft.EntityFrameworkCore;

namespace Artemis_Shield.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BahamutArticles> BahamutArticles { get; set; }

        
    }
}
