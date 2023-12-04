using Microsoft.AspNetCore.Mvc;
using ProjectSafeHostel.Dados.EntityFramework;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels.Cadastros;
using ProjectSafeHostel.Servico.ViewModels.Entities.Doador;
using ProjectSafeHostel.Servico.ViewModels.Entities.Endereco;

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


        [HttpGet("buscarporcpfcnpj/{cpfCnpj}")]
        public IActionResult GetPorCpf(string cpfCnpj)
        {
            return Ok(_doadorService.BuscarPorCpfCnpj(cpfCnpj));
        }


        #endregion


        #region - POST

        [HttpPost("adicionar")]
        public async Task<IActionResult> Post([FromBody] CadastrarDoadorViewModel novoDoador)
        {
            await _doadorService.InserirDoador(novoDoador);

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
