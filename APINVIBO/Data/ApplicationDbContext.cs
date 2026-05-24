using Microsoft.EntityFrameworkCore;
using APINVIBO.Models;

namespace APINVIBO.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Invitado> Invitados { get; set; }
    }
}