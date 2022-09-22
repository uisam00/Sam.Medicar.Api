using Sam.Medicar.Domain.Entities.Shared;

namespace Sam.Medicar.Domain.Interfaces.Services.Shared;

public interface IServiceBase<TEntity> : IDisposable where TEntity : Entity
{
    Task<IEnumerable<TEntity>> ObterTodosAsync();
    Task<TEntity?> ObterPorIdAsync(int id);
    Task<object> AdicionarAsync(TEntity objeto);
    Task AtualizarAsync(TEntity objeto);
    Task RemoverAsync(TEntity objeto);
    Task RemoverPorIdAsync(int id);
}
