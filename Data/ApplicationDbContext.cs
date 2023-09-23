using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Work.Models;

namespace Work.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProgramDetail> ProgramDetails { get; set; }
        public DbSet<AppForm> AppForms { get; set; }
        public DbSet<WorkFlow> WorkFlows { get; set; }
        public DbSet<StageType> StageTypes { get; set; }
    }
}