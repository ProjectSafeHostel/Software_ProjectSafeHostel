using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels.Cadastros;
using ProjectSafeHostel.Servico.ViewModels.Entities.Produto;

namespace ProjectSafeHostel.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoacaoController : ControllerBase
    {
        private readonly IDoacaoService _doacaoService;
        public DoacaoController(IDoacaoService doacaoService)
        {
            _doacaoService = doacaoService;
        }

        #region - Metódos CRUD

        #region - GET

        [HttpGet("buscartodos")]
        public IActionResult Get()
        {
            return Ok(_doacaoService.BuscarTodos());
        }


        [HttpGet("buscarporid/{id}")]
        public IActionResult GetPorId(int id)
        {
            return Ok(_doacaoService.BuscarPorId(id));
        }

        #endregion

        #region - POST

        [HttpPost("adicionar")]
        public async Task<IActionResult> Post([FromBody] CadastrarDoacaoViewModel novaDoacao)
        {
            await _doacaoService.InserirDoacao(novaDoacao);

            return Ok("Doação cadastrada com sucesso");
        }

        #endregion

        #region - DELETE

        [HttpDelete("excluir/{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            await _doacaoService.ExcluirDoacao(id);

            return Ok("Doação excluída com sucesso");
        }

        #endregion

        #endregion
    }
}
