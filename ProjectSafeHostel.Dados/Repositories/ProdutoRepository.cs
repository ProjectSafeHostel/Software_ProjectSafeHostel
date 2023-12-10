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
    public class ProdutoRepository : IProdutoRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;

        public ProdutoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion

        public async Task AtualizarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public async Task<Produto> BuscarPorId(int id)
        {
            try
            {
                var produto = await _contexto.Produto.Where(f => f.PRODUTO_ID == id).FirstOrDefaultAsync();

                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar produto: {ex.Message}");
            }
        }

        public async Task<int> BuscarId()
        {
            var ultimoId = await _contexto.Produto.MaxAsync(entidade => (int?)entidade.PRODUTO_ID) ?? 0;

            return ultimoId;
        }

        public IEnumerable<Produto> BuscarTodos()
        {
            try
            {
                return _contexto.Produto.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar produto: {ex.Message}");
            }
        }

        public async Task ExcluirProduto(Produto produto)
        {
            try
            {
                _contexto.Produto.Remove(produto);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir a produto: {ex.Message}");
            }
        }

        public async Task InserirProduto(Produto produto)
        {
            try
            {
                await _contexto.Produto.AddAsync(produto);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir a produto: {ex.Message}");
            }
        }
    }
}
