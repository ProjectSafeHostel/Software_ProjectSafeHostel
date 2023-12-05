using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoCategoria;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoFamilia;

namespace ProjectSafeHostel.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoFamiliaController : ControllerBase
    {
        private readonly IProdutoFamiliaService _produtoFamiliaService;
        public ProdutoFamiliaController(IProdutoFamiliaService produtoFamiliaService)
        {
            _produtoFamiliaService = produtoFamiliaService;
        }

        #region - Metódos CRUD

        #region - GET

        [HttpGet("buscartodos")]
        public IActionResult Get()
        {
            return Ok(_produtoFamiliaService.BuscarTodos());
        }


        [HttpGet("buscarporid/{id}")]
        public IActionResult GetPorId(int id)
        {
            return Ok(_produtoFamiliaService.BuscarPorId(id));
        }

        #endregion

        #region - POST

        [HttpPost("adicionar")]
        public async Task<IActionResult> Post([FromBody] NovoProdutoFamiliaViewModel novaFamilia)
        {
            await _produtoFamiliaService.InserirFamilia(novaFamilia);

            return Ok("Familia cadastrada com sucesso");
        }

        #endregion

        #region - DELETE

        [HttpDelete("excluir/{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            await _produtoFamiliaService.ExcluirFamilia(id);

            return Ok("Familia excluída com sucesso");
        }

        #endregion

        #endregion
    }
}
