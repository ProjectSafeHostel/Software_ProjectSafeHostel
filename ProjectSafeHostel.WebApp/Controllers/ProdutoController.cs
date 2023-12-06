using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels.Entities.Produto;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoFamilia;

namespace ProjectSafeHostel.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        #region - Metódos CRUD

        #region - GET

        [HttpGet("buscartodos")]
        public IActionResult Get()
        {
            return Ok(_produtoService.BuscarTodos());
        }


        [HttpGet("buscarporid/{id}")]
        public IActionResult GetPorId(int id)
        {
            return Ok(_produtoService.BuscarPorId(id));
        }

        #endregion

        #region - POST

        [HttpPost("adicionar")]
        public async Task<IActionResult> Post([FromBody] NovoProdutoViewModel novoProduto)
        {
            await _produtoService.InserirProduto(novoProduto);

            return Ok("Produto cadastrado com sucesso");
        }

        #endregion

        #region - DELETE

        [HttpDelete("excluir/{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            await _produtoService.ExcluirProduto(id);

            return Ok("Produto excluído com sucesso");
        }

        #endregion

        #endregion
    }
}
