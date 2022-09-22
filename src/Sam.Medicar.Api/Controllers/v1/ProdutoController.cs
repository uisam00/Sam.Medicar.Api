//using Microsoft.AspNetCore.Mvc;
//using Sam.Medicar.Api.Controllers.Shared;
//using Sam.Medicar.Api.DTOs.Request;
//using Sam.Medicar.Api.DTOs.Response;
//using Sam.Medicar.Domain.Interfaces.Services;

//namespace Sam.Medicar.Api.Controllers.v1;

//[ApiVersion("1.0")]
//public class ProdutoController : ApiControllerBase
//{
//    private IProdutoService _produtoService;

//    public ProdutoController(IProdutoService produtoService) =>
//        _produtoService = produtoService;

//    [HttpGet]
//    public async Task<ActionResult<IEnumerable<ProdutoResponse>>> ObterTodos()
//    {
//        var produtos = await _produtoService.ObterTodosAsync();
//        var produtosResponse = produtos.Select(produto => ProdutoResponse.ConverterParaResponse(produto));
//        return Ok(produtosResponse);
//    }

//    [HttpGet("{id}")]
//    public async Task<ActionResult<ProdutoResponse>> ObterPorId(int id)
//    {
//        var produto = await _produtoService.ObterPorIdAsync(id);
//        var produtoResponse = ProdutoResponse.ConverterParaResponse(produto);
//        return Ok(produtoResponse);
//    }

//    [HttpPost]
//    public async Task<ActionResult<int>> Inserir(InsercaoProdutoRequest produtoRequest)
//    {
//        var produto = InsercaoProdutoRequest.ConverterParaEntidade(produtoRequest);
//        var id = (int)await _produtoService.AdicionarAsync(produto);
//        return CreatedAtAction(nameof(ObterPorId), new { id = id }, id);
//    }

//    [HttpPut]
//    public async Task<ActionResult> Atualizar(AtualizacaoProdutoRequest produtoRequest)
//    {
//        var produto = AtualizacaoProdutoRequest.ConverterParaEntidade(produtoRequest);
//        await _produtoService.AtualizarAsync(produto);
//        return Ok();
//    }

//    [HttpDelete("{id}")]
//    public async Task<ActionResult> Excluir(int id)
//    {
//        await _produtoService.RemoverPorIdAsync(id);
//        return Ok();
//    }
//}
