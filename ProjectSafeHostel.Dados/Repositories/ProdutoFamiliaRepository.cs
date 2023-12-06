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
    public class ProdutoFamiliaRepository : IProdutoFamiliaRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;

        public ProdutoFamiliaRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion

        public Task AtualizarProdutoFamilia(ProdutoFamilia produtoFamilia)
        {
            throw new NotImplementedException();
        }

        public async Task<ProdutoFamilia> BuscarPorId(int id)
        {
            try
            {
                var familia = await _contexto.ProdutoFamilia.Where(f => f.PRODUTO_FAMILIA_ID == id).FirstOrDefaultAsync();

                return familia;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar familia: {ex.Message}");
            }
        }

        public IEnumerable<ProdutoFamilia> BuscarTodos()
        {
            try
            {
                return _contexto.ProdutoFamilia.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar familia: {ex.Message}");
            }
        }

        public async Task ExcluirProdutoFamilia(ProdutoFamilia produtoFamilia)
        {
            try
            {
                _contexto.ProdutoFamilia.Remove(produtoFamilia);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir a familia: {ex.Message}");
            }
        }

        public async Task InserirProdutoFamilia(ProdutoFamilia produtoFamilia)
        {
            try
            {
                //var categoria = await _contexto.ProdutoCategoria.Where(c => c.PRODUTO_CATEGORIA_ID == produtoFamilia.PRODUTO_CATEGORIA_ID).FirstOrDefaultAsync();

                await _contexto.ProdutoFamilia.AddAsync(produtoFamilia);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir a familia: {ex.Message}");
            }
        }
    }
}
