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

        public async Task<bool> Autenticar(UsuarioViewModel usuario)
        {
            var usuarioAutenticado = await _usuarioRepository
                .Autenticar(usuario.Login, usuario.Senha);

            if (usuarioAutenticado == null)
                throw new ApplicationException("Login/Senha inválidos ou não existe");

            return true;
        }

        public async Task Cadastrar(UsuarioViewModel usuarioViewModel)
        {
            var usuario = _mapper.Map<Usuario>(usuarioViewModel);
            await _usuarioRepository.Cadastrar(usuario);
        }
    }
}
