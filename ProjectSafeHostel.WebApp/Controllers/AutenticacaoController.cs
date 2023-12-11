using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.Services;
using ProjectSafeHostel.Servico.ViewModels;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoCategoria;
using ProjectSafeHostel.WebApp.Models;
using System.Diagnostics;

namespace ProjectSafeHostel.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public AutenticacaoController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        #region - Metódos CRUD

        #region - POST

        [HttpPost("autenticar")]
        public async Task<IActionResult> Post(NovoUsuarioViewModel usuario)
        {
            bool podeLogar = await _usuarioService.Autenticar(usuario);

            if (!podeLogar)
            {
                return BadRequest("Login inválido");
            }

            return Ok("Autenticado");
        }

        [HttpPost("adicionar")]
        public async Task<IActionResult> PostCadastrar(NovoUsuarioViewModel usuario)
        {
            await _usuarioService.Cadastrar(usuario);

            return Ok("Usuário cadastrado com sucesso");
        }

        #endregion

        #endregion

    }
}
