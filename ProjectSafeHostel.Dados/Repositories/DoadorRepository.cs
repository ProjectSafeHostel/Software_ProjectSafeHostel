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

        public IEnumerable<object> BuscarTodosDoadoresComColaboradores()
        {
            try
            {
                //var doadoresComColaboradores = _contexto.Doador
                //    .Include(d => d.COLABORADOR)
                //    .Select(d => new
                //    {
                //        DoadorId = d.DOADOR_ID,
                //        d.CPF,
                //        d.CNPJ,
                //        ColaboradorId = d.COLABORADOR.COLABORADOR_ID,
                //        Nome = d.COLABORADOR.NOME,
                //        Sobrenome = d.COLABORADOR.SOBRENOME,
                //        DataNascimento = d.COLABORADOR.DATA_NASCIMENTO,
                //        Tipo = d.COLABORADOR.TIPO,
                //        ColaboradorCPF = d.COLABORADOR.CPF,
                //        DataContratacao = d.COLABORADOR.DATA_CONTRATACAO,
                //        DataTerminacao = d.COLABORADOR.DATA_TERMINACAO,
                //        TerminacaoFlag = d.COLABORADOR.TERMINACAO_FLAG
                //    })
                //    .Where(d => d.Tipo == 'D' &&
                //            (d.CNPJ == null) &&
                //            (d.DataTerminacao == null || d.DataTerminacao == DateTime.MinValue))
                //    .ToList();

                var doadoresComColaboradores = from doador in _contexto.Doador
                                join colaborador in _contexto.Colaborador
                                on doador.COLABORADOR_ID equals colaborador.COLABORADOR_ID
                                where colaborador.TIPO == 'D' && 
                                    (doador.CNPJ == null || doador.CPF == null) && 
                                    (colaborador.DATA_TERMINACAO == null || colaborador.DATA_TERMINACAO == DateTime.MinValue)
                                select new
                                {
                                    DoadorId = doador.DOADOR_ID,
                                    doador.CPF,
                                    doador.CNPJ,
                                    ColaboradorId = colaborador.COLABORADOR_ID,
                                    Nome = colaborador.NOME,
                                    Sobrenome = colaborador.SOBRENOME,
                                    DataNascimento = colaborador.DATA_NASCIMENTO,
                                    Tipo = colaborador.TIPO,
                                    ColaboradorCPF = colaborador.CPF,
                                    DataContratacao = colaborador.DATA_CONTRATACAO,
                                    DataTerminacao = colaborador.DATA_TERMINACAO,
                                    TerminacaoFlag = colaborador.TERMINACAO_FLAG
                                };

                return doadoresComColaboradores;
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

        #endregion
    }
}
