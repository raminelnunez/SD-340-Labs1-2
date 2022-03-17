using ATCLab1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ATCLab1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Credit> Credits { get; set; }
    }
}