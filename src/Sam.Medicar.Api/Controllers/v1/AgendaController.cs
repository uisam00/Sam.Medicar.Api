using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sam.Medicar.Api.Controllers.Shared;
using Sam.Medicar.Domain.Interfaces.Repositories;

namespace Sam.Medicar.Api.Controllers.v1;

[ApiVersion("1.0")]
public class AgendaController : ApiControllerBase
{
    private ICategoriaRepository _categoriaRepository;

    public AgendaController(ICategoriaRepository categoriaRepository) =>
        _categoriaRepository = categoriaRepository;

    //[HttpGet]
    //public async Task<ActionResult<IEnumerable<ConsultaResponse>>> ObterTodas()
    //{
    //    var categorias = await _categoriaRepository.ObterTodosAsync();
    //    var categoriasResponse = categorias.Select(categoria => ConsultaResponse.ConverterParaResponse(categoria));
    //    return Ok(categoriasResponse);
    //}
    [HttpGet]
    [Authorize]
    public async Task<ActionResult<string>> ObterOk()
    {

        return Ok("OK");
    }
}
