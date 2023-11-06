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
    public class DoadorRepository : IDoadorRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;    

        public DoadorRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion

        #region - Funções

        public Task AtualizarDoador(Doador doador)
        {
            throw new NotImplementedException();
        }

        public async Task<Doador> BuscarPorId(int id)
        {
            return await _contexto.Doador.FirstOrDefaultAsync(a => a.DOADOR_ID == id);
        }

        public IEnumerable<Doador> BuscarPorCpf(string cpf)
        {
            return (IEnumerable<Doador>)_contexto.Doador.AllAsync(a => a.CPF == cpf);
        }

        public IEnumerable<Doador> BuscarTodos()
        {
            return _contexto.Doador.ToList();
        }

        public Task ExcluirDoador(Doador doador)
        {
            _contexto.Doador.Remove(doador);
            return _contexto.SaveChangesAsync();
        }

        public async Task InserirDoador(Doador doador)
        {
            await _contexto.AddAsync(doador);
        }

        #endregion
    }
}
