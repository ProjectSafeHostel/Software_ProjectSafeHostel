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
    public class EnderecoRepository : IEnderecoRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;
        //private Contexto _contexto = new Contexto();

        public EnderecoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion

        public Task AtualizarEndereco(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public async Task<Endereco> BuscarPorId(int id)
        {
            var endereco = await _contexto.Endereco.Where(c => c.COLABORADOR_ID == id).FirstOrDefaultAsync();

            return endereco;
        }

        public async Task ExcluirEndereco(Endereco endereco)
        {
            try
            {
                _contexto.Endereco.Remove(endereco);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir endereço: {ex.Message}");
            }
        }

        public async Task InserirEndereco(Endereco endereco)
        {
            try
            {
                await _contexto.Endereco.AddAsync(endereco);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir endereço: {ex.Message}");
            }
        }
    }
}
