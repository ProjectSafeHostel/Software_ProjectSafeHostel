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
    public class ProdutoCategoriaRepository : IProdutoCategoriaRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;
        //private Contexto _contexto = new Contexto();

        public ProdutoCategoriaRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion


        public Task AtualizarCategoria(ProdutoCategoria produtoCategoria)
        {
            throw new NotImplementedException();
        }

        public async Task<ProdutoCategoria> BuscarPorId(int id)
        {
            var categoria = await _contexto.ProdutoCategoria.Where(c => c.PRODUTO_CATEGORIA_ID == id).FirstOrDefaultAsync();

            return categoria;
        }

        public IEnumerable<ProdutoCategoria> BuscarTodos()
        {
            return _contexto.ProdutoCategoria.ToList();
        }

        public async Task ExcluirCategoria(ProdutoCategoria produtoCategoria)
        {
            try
            {
                _contexto.ProdutoCategoria.Remove(produtoCategoria);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir a categoria: {ex.Message}");
            }
        }

        public async Task InserirCategoria(ProdutoCategoria produtoCategoria)
        {
            try
            {
                await _contexto.ProdutoCategoria.AddAsync(produtoCategoria);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir a categoria: {ex.Message}");
            }
        }
    }
}
