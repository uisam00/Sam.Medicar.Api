using Microsoft.EntityFrameworkCore;
using Sam.Medicar.Data.Context;
using Sam.Medicar.Data.Repositories.Shared;
using Sam.Medicar.Domain.Entities;
using Sam.Medicar.Domain.Interfaces.Repositories;

namespace Sam.Medicar.Data.Repositories;

public class EspecialidadeRepository : RepositoryBase<Especialidade>, IEspecialidadeRepository
{
    public EspecialidadeRepository(DataContext dataContext) : base(dataContext) { }

    public async override Task<IEnumerable<Especialidade>> ObterTodosAsync()
    {
        return await Context.Especialidade
            .Include(p => p.Medicos)
                .ThenInclude(p => p.Agendas)
            .AsNoTracking()
            .ToListAsync();
    }

    public async override Task<Especialidade?> ObterPorIdAsync(int id)
    {
        return await Context.Especialidade
            .Include(p => p.Medicos)
                .ThenInclude(p => p.Agendas)
            .FirstOrDefaultAsync(p => p.Id.Equals(id));
    }
}
