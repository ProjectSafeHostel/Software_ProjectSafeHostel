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
    public class ColaboradorRepository : IColaboradorRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;
        //private Contexto _contexto = new Contexto();

        public ColaboradorRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion


        public Task AtualizarColaborador(Colaborador colaborador)
        {
            throw new NotImplementedException();
        }

        public Task<Colaborador> BuscarPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public async Task<Colaborador> BuscarPorId(int id)
        {
            var colaborador = await _contexto.Colaborador.Where(c => c.COLABORADOR_ID == id).FirstOrDefaultAsync();

            return colaborador;
        }

        public async Task<int> BuscarId()
        {
            var ultimoId = await _contexto.Colaborador.MaxAsync(entidade => (int?)entidade.COLABORADOR_ID) ?? 0;

            return ultimoId;
        }

        public IEnumerable<Colaborador> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public async Task ExcluirColaborador(Colaborador colaborador)
        {
            try
            {
                _contexto.Colaborador.Remove(colaborador);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir colaborador: {ex.Message}");
            }
        }

        public async Task InserirColaborador(Colaborador colaborador)
        {
            try
            {
                await _contexto.Colaborador.AddAsync(colaborador);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir colaborador: {ex.Message}");
            }
        }
    }
}
