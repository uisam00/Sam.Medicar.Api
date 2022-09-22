using Sam.Medicar.Data.Context;
using Sam.Medicar.Data.Repositories.Shared;
using Sam.Medicar.Domain.Entities;
using Sam.Medicar.Domain.Interfaces.Repositories;

namespace Sam.Medicar.Data.Repositories;

public class CategoriaRepository : RepositoryBase<Medico>, ICategoriaRepository
{
    public CategoriaRepository(DataContext dataContext) : base(dataContext) { }
}
