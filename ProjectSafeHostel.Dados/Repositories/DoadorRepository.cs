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
    public class DoadorColaboradorViewModel
    {
        public Doador Doador { get; set; }
        public Colaborador Colaborador { get; set; }
    }

    public class DoadorRepository : IDoadorRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;
        //private Contexto _contexto = new Contexto();

        public DoadorRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion

        #region - Funções

        public async Task AtualizarDoador(Doador doador)
        {
            try
            {
                _contexto.Doador.Update(doador);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir doador: {ex.Message}");
            }
        }

        public async Task<Doador> BuscarPorId(int id)
        {
            return await _contexto.Doador.FirstOrDefaultAsync(a => a.DOADOR_ID == id);
        }

        public async Task<Doador> BuscarPorCpf(string cpf)
        {
            return await _contexto.Doador.FirstOrDefaultAsync(a => a.CPF == cpf);
        }

        public async Task<Doador> BuscarPorCnpj(string cnpj)
        {
            return await _contexto.Doador.FirstOrDefaultAsync(a => a.CNPJ == cnpj);
        }

        public IEnumerable<object> BuscarTodos()
        {
            try
            {

                IEnumerable<object> doadores = RetornaDoadoresColaboradores();
                return doadores;

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar todos os doadores: {ex.Message}");
            }
        }

        public async Task ExcluirDoador(Doador doador)
        {
            try
            {
                _contexto.Doador.Remove(doador);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir doador: {ex.Message}");
            }          
        }

        public async Task InserirDoador(Doador doador)
        {
            try
            {
                await _contexto.Doador.AddAsync(doador);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir doador: {ex.Message}");
            }
        }

        private IEnumerable<object> RetornaDoadoresColaboradores()
        {
            try
            {
                List<Doador> doadores = _contexto.Doador.ToList();
                List<Colaborador> colaborador = _contexto.Colaborador.Where(c => c.DATA_TERMINACAO == null && c.TERMINACAO_FLAG == 0).ToList();

                List<DoadorColaboradorViewModel> doador_Colaborador = doadores
                    .Join(
                        colaborador,
                        doade => doade.COLABORADOR_ID,
                        coaed => coaed.COLABORADOR_ID,
                        (doade, coaed) => new DoadorColaboradorViewModel
                        {
                            Doador = doade,
                            Colaborador = coaed
                        }
                    )
                    .ToList();

                return doador_Colaborador;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar todos os doadores: {ex.Message}");
            }
        }

        #endregion
    }
}
