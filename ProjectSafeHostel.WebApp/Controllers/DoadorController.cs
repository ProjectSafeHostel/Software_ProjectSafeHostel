using Microsoft.AspNetCore.Mvc;
using ProjectSafeHostel.Dados.EntityFramework;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels.Entities.Doador;

namespace ProjectSafeHostel.WebApp.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class DoadorController : ControllerBase
    {
        private readonly IDoadorService _doadorService;
        public DoadorController(IDoadorService doadorService)
        {
            _doadorService = doadorService;
        }


        #region - Metódos CRUD

        #region - GET

        [HttpGet("buscartodos")]
        public IActionResult Get()
        {
            return Ok(_doadorService.BuscarTodos());
        }


        [HttpGet("buscarporid/{id}")]
        public IActionResult GetPorId(int id)
        {
            return Ok(_doadorService.BuscarPorId(id));
        }


        [HttpGet("buscarporcpf/{cpf}")]
        public IActionResult GetPorCpf(string cpf)
        {
            return Ok(_doadorService.BuscarPorCpf(cpf));
        }


        #endregion


        #region - POST

        [HttpPost("adicionar")]
        public async Task<IActionResult> Post(NovoDoadorViewModel novoDoadorViewModel)
        {
            await _doadorService.InserirDoador(novoDoadorViewModel);

            return Ok("Doador cadastrado com sucesso");
        }

        #endregion


        #region - DELETE

        [HttpDelete("excluir/{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            await _doadorService.ExcluirDoador(id);

            return Ok("Doador excluído com sucesso");
        }

        #endregion

        #endregion
    }
}
