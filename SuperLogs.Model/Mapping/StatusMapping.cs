using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SuperLogs.Model.Mapping
{
    public class StatusMapping : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable(nameof(Status));

            builder.HasKey(s => s.IdStatus);

            builder.Property(t => t.Tipo).IsRequired();

            builder.HasMany(t => t.Logs)
                .WithOne(l => l.Status);

            builder.HasData(
                new Status { IdStatus = 1, Tipo = "Ativo" },
                new Status { IdStatus = 2, Tipo = "Arquivado" });
        }
    }
}