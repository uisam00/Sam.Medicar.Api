using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sam.Medicar.Domain.Entities;
using System.Reflection.Emit;

namespace Sam.Medicar.Data.Mappings
{
    public class AgendaMap : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.ToTable("Agenda");

            builder.HasKey(a => a.Id);

            builder.HasOne(a => a.Medico)
                .WithMany(m => m.Agendas)
                .HasForeignKey(a => a.IdMedico)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(e => e.Horarios)
            .HasConversion(
                v => string.Join(',', v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));

            builder.HasData(new[]
            {
                new Agenda(1, 1),
                new Agenda(2, 1),
                new Agenda(3, 2),
                new Agenda(4, 2),
                new Agenda(5, 3),
                new Agenda(6, 3),
                new Agenda(7, 4),
                new Agenda(8, 4),
            });
        }
    }
}
