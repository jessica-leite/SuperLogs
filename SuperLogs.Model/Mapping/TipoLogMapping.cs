using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SuperLogs.Model.Mapping
{
    public class TipoLogMapping : IEntityTypeConfiguration<TipoLog>
    {

        public void Configure(EntityTypeBuilder<TipoLog> builder)
        {
            builder.ToTable("TipoLog");

            builder.HasKey("IdTipoLog");

            builder.Property(t => t.Tipo).IsRequired();

            builder.HasMany(t => t.Logs)
                .WithOne(l => l.TipoLog);

            builder.HasData(
                new TipoLog() { IdTipoLog = 1, Tipo = "Debug" },
                new TipoLog() { IdTipoLog = 2, Tipo = "Warning" },
                new TipoLog() { IdTipoLog = 3, Tipo = "Error" });
        }
    }
}
