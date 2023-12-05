using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.Services;
using ProjectSafeHostel.Servico.ViewModels.Entities.Cliente;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoCategoria;

namespace ProjectSafeHostel.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        #region - Metódos CRUD

        #region - GET

        [HttpGet("buscartodos")]
        public IActionResult Get()
        {
            return Ok(_clienteService.BuscarTodos());
        }


        [HttpGet("buscarporid/{id}")]
        public IActionResult GetPorId(int id)
        {
            return Ok(_clienteService.BuscarPorId(id));
        }

        #endregion

        #region - POST

        [HttpPost("adicionar")]
        public async Task<IActionResult> Post([FromBody] NovoClienteViewModel novoCliente)
        {
            await _clienteService.InserirCliente(novoCliente);

            return Ok("Cliente cadastrado com sucesso");
        }

        #endregion

        #region - DELETE

        [HttpDelete("excluir/{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            await _clienteService.ExcluirCliente(id);

            return Ok("Cliente excluído com sucesso");
        }

        #endregion

        #endregion
    }
}
