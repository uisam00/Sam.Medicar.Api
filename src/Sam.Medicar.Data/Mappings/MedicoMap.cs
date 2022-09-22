using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sam.Medicar.Domain.Entities;

namespace Sam.Medicar.Data.Mappings;

public class MedicoMap : IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {
        builder.ToTable("Medico");

        builder.HasKey(m => m.Id);

        builder.Property(p => p.Nome)
            .HasMaxLength(100)
            .IsUnicode(false);

        builder.Property(b => b.Crm)
           .HasColumnName("CRM")
           .HasMaxLength(10)
           .HasColumnType("varchar(10)");

        builder.HasOne(m => m.Especialidade)
            .WithMany(e => e.Medicos)
            .HasForeignKey(m => m.IdEspecialidade)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(new[]
        {
            new Medico(1, "Drauzio Varella", "3711", "drauzinho@medicar.com.br", 1),
            new Medico(2, "Gregory House", "2544", "gregory@medicar.com.br", 2),
            new Medico(3, "Medicones Doutoris", "2227", "medicones@medicar.com.br", 3),
            new Medico(4, "Lauro Cirurgis", "4367", "lauro@medicar.com.br", 4)
        });
    }
}
