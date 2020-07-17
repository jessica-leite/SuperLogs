using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperLogs.Model.Mapping;

namespace SuperLogs.Model.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Ambiente> Ambiente { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<TipoLog> TipoLog { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TipoLogMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
