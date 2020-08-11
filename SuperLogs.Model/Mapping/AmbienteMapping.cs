using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SuperLogs.Model.Mapping
{
    public class AmbienteMapping : IEntityTypeConfiguration<Ambiente>
    {
        public void Configure(EntityTypeBuilder<Ambiente> builder)
        {
            builder.ToTable(nameof(Ambiente));

            builder.HasKey(a => a.IdAmbiente);

            builder.Property(a => a.Tipo).IsRequired();

            builder.HasMany(a => a.Logs)
                .WithOne(l => l.Ambiente);

            builder.HasData(
                new Ambiente { IdAmbiente = 1, Tipo = "Produção" },
                new Ambiente { IdAmbiente = 2, Tipo = "Homologação" },
                new Ambiente { IdAmbiente = 3, Tipo = "Dev" });
        }
    }
}