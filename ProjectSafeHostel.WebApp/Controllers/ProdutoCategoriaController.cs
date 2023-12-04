using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoCategoria;

namespace ProjectSafeHostel.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoCategoriaController : ControllerBase
    {
        private readonly IProdutoCategoriaService _produtoCategoriaService;
        public ProdutoCategoriaController(IProdutoCategoriaService produtoCategoria)
        {
            _produtoCategoriaService = produtoCategoria;
        }

        #region - Metódos CRUD

        #region - GET

        [HttpGet("buscartodos")]
        public IActionResult Get()
        {
            return Ok(_produtoCategoriaService.BuscarTodos());
        }


        [HttpGet("buscarporid/{id}")]
        public IActionResult GetPorId(int id)
        {
            return Ok(_produtoCategoriaService.BuscarPorId(id));
        }

        #endregion

        #region - POST

        [HttpPost("adicionar")]
        public async Task<IActionResult> Post([FromBody] NovoProdutoCategoriaViewModel novaCategoria)
        {
            await _produtoCategoriaService.InserirCategoria(novaCategoria);

            return Ok("Categoria cadastrada com sucesso");
        }

        #endregion

        #region - DELETE

        [HttpDelete("excluir/{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            await _produtoCategoriaService.ExcluirCategoria(id);

            return Ok("Categoria excluída com sucesso");
        }

        #endregion

        #endregion
    }
}
