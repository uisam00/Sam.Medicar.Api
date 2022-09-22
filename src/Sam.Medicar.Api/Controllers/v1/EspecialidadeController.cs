using Microsoft.AspNetCore.Mvc;
using Sam.Medicar.Api.Controllers.Shared;
using Sam.Medicar.Application.Interfaces;

namespace Sam.Medicar.Api.Controllers.v1;

[ApiVersion("1.0")]
[ApiController]
public class EspecialidadeController : ApiControllerBase
{
    private readonly IEspecialidadeService _especialidadeService;

    public EspecialidadeController(IEspecialidadeService especialidadeService)
    {
        _especialidadeService = especialidadeService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var Especialidades = await _especialidadeService.GetAlEspecialidadesAsync();
            if (Especialidades == null) return NoContent();

            return Ok(Especialidades);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar recuperar Especialidades. Erro: {ex.Message}");
        }
    }

    //[HttpGet("{id}")]
    //public async Task<ActionResult<ConsultaResponse>> ObterPorId(int id)
    //{
    //    var especialidade = await _especialidadeRepository.ObterPorIdAsync(id);
    //    var especialidadeResponse = ConsultaResponse.ConverterParaResponse(especialidade);
    //    return Ok(especialidadeResponse);
    //}
}
