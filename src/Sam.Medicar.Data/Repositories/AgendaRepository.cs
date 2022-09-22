using Microsoft.EntityFrameworkCore;
using Sam.Medicar.Data.Context;
using Sam.Medicar.Data.Repositories.Shared;
using Sam.Medicar.Domain.Entities;
using Sam.Medicar.Domain.Interfaces.Repositories;

namespace Sam.Medicar.Data.Repositories;

public class AgendaRepository : RepositoryBase<Agenda>, IAgendaRepository
{
    public AgendaRepository(DataContext dataContext) : base(dataContext) { }

    public async override Task<IEnumerable<Agenda>> ObterTodosAsync()
    {
        return await Context.Agenda
            .Include(p => p.Medico)
            .AsNoTracking()
            .ToListAsync();
    }

    public async override Task<Agenda?> ObterPorIdAsync(int id)
    {
        return await Context.Agenda
            .Include(p => p.Medico)
            .FirstOrDefaultAsync(p => p.Id.Equals(id));
    }
}
