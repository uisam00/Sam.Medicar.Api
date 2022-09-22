using AutoMapper;
using Sam.Medicar.Application.Dtos;
using Sam.Medicar.Application.Interfaces;
using Sam.Medicar.Domain.Entities;
using Sam.Medicar.Domain.Interfaces.Repositories;

namespace Sam.Medicar.Application.Services;
public class EspecialidadeService : IEspecialidadeService
{
    private readonly IEspecialidadeRepository _especialidadeRepository;
    private readonly IMapper _mapper;
    public EspecialidadeService(IEspecialidadeRepository especialidadeRepository,
                              IMapper mapper)
    {
        _especialidadeRepository = especialidadeRepository;
        _mapper = mapper;
    }

    public async Task<List<EspecialidadeDto>> GetAlEspecialidadesAsync()
    {
        try
        {
            var especialidades = await _especialidadeRepository.ObterTodosAsync();
            if (especialidades == null) return null;

            var resultado = _mapper.Map<List<EspecialidadeDto>>(especialidades);

            return resultado;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
