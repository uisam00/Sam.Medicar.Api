//using Microsoft.AspNetCore.Mvc;
//using Sam.Medicar.Api.Controllers.Shared;
//using Sam.Medicar.Api.DTOs.Response;
//using Sam.Medicar.Domain.Interfaces.Repositories;

//namespace Sam.Medicar.Api.Controllers.v1;

//[ApiVersion("1.0")]
//public class CategoriaController : ApiControllerBase
//{
//    private ICategoriaRepository _categoriaRepository;

//    public CategoriaController(ICategoriaRepository categoriaRepository) =>
//        _categoriaRepository = categoriaRepository;

//    [HttpGet]
//    public async Task<ActionResult<IEnumerable<ConsultaResponse>>> ObterTodas()
//    {
//        var categorias = await _categoriaRepository.ObterTodosAsync();
//        var categoriasResponse = categorias.Select(categoria => ConsultaResponse.ConverterParaResponse(categoria));
//        return Ok(categoriasResponse);
//    }

//    [HttpGet("{id}")]
//    public async Task<ActionResult<ConsultaResponse>> ObterPorId(int id)
//    {
//        var categoria = await _categoriaRepository.ObterPorIdAsync(id);
//        var categoriaResponse = ConsultaResponse.ConverterParaResponse(categoria);
//        return Ok(categoriaResponse);
//    }
//}
