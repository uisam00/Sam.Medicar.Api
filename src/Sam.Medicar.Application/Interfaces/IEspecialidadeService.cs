
using Sam.Medicar.Application.Dtos;
namespace Sam.Medicar.Application.Interfaces;
public interface IEspecialidadeService
{
    Task<List<EspecialidadeDto>> GetAlEspecialidadesAsync();

}
