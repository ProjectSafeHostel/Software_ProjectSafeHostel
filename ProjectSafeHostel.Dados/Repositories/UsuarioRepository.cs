using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectSafeHostel.Dados.EntityFramework;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dados.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;
        private readonly IMapper _mapper;

        public UsuarioRepository(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        #endregion


        public async Task<Usuario> Autenticar(string login, string senha)
        {
            var usuario = await _contexto.Usuario.Where(filtro =>
                        filtro.Login == login && filtro.Senha == senha).FirstOrDefaultAsync();
            return _mapper.Map<Usuario>(usuario);


        }

        public async Task Cadastrar(Usuario novoUsuario)
        {
            try
            {
                await _contexto.Usuario.AddAsync(novoUsuario);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir o usuário: {ex.Message}");
            }
        }
    }
}
