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

        [HttpPost()]
        public async Task<IActionResult> Post(UsuarioViewModel usuario)
        {
            bool podeLogar = await _usuarioService.Autenticar(usuario);

            if (!podeLogar)
            {
                BadRequest("Login inválido");
            }

            return base.RedirectToAction("Index", "Home");
        }

        #endregion

        #endregion

    }
}
