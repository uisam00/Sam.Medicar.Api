using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sam.Medicar.Domain.Entities;


namespace Sam.Medicar.Data.Mappings
{
    public class ConsultaMap : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("Consulta");

            builder.HasKey(a => a.Id);

            builder.HasOne(c => c.Agenda)
                .WithMany(a => a.Consultas)
                .HasForeignKey(a => a.IdAgenda)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
