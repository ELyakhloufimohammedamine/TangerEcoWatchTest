using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TangerEcoWatchTest.Models;

namespace TangerEcoWatchTest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TangerEcoWatchTest.Models.Report> Report { get; set; } = default!;
    }
}