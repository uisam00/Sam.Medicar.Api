using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sam.Medicar.Domain.Entities;

namespace Sam.Medicar.Data.Mappings
{
    public class EspecialidadeMap : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.ToTable("Especialidade");

            builder.HasKey(m => m.Id);


            builder.Property(p => p.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);


            builder.HasData(new[]
            {
                new Especialidade(1, "Pediatria"),
                new Especialidade(2, "Ginecologia"),
                new Especialidade(3, "Cardiologia"),
                new Especialidade(4, "Clínico Geral")
            });
        }
    }
}
