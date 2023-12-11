using AutoMapper;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Dominio.Interfaces;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;


        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<UsuarioViewModel> Autenticar(NovoUsuarioViewModel usuario)
        {
            var usuarioBuscado = await _usuarioRepository.Autenticar(usuario.Login, usuario.Senha);

            var usuarioAutenticado = _mapper.Map<UsuarioViewModel>(usuarioBuscado);

            if (usuarioAutenticado == null)
                return null;

            return usuarioAutenticado;
        }

        public async Task Cadastrar(NovoUsuarioViewModel usuarioViewModel)
        {
            var usuario = _mapper.Map<Usuario>(usuarioViewModel);
            await _usuarioRepository.Cadastrar(usuario);
        }
    }
}
