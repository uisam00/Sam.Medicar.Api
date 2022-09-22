using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Sam.Medicar.Domain.Entities;

namespace Sam.Medicar.Data.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options) { }
    
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder
            .Properties<string>()
            .AreUnicode(false)
            .HaveMaxLength(500);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Consulta> Consulta { get; set; }
    public DbSet<Especialidade> Especialidade { get; set; }
    public DbSet<Medico> Medico { get; set; }
    public DbSet<Agenda> Agenda { get; set; }
}
