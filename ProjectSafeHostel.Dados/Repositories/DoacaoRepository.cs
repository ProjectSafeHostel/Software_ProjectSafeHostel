using Microsoft.EntityFrameworkCore;
using ProjectSafeHostel.Dados.EntityFramework;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Dominio.Interfaces;
using ProjectSafeHostel.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dados.Repositories
{
    public class DoacaoDoadorProdutoViewModel
    {
        public Doador Doador { get; set; }
        public Produto Produto { get; set; }
    }

    public class DoacaoRepository : IDoacaoRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;

        public DoacaoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion


        public Task AtualizarDoacao(Doacao doacao)
        {
            throw new NotImplementedException();
        }

        public async Task<Doacao> BuscarPorId(int id)
        {
            var doacao = await _contexto.Doacao.Where(c => c.DOACAO_ID == id).FirstOrDefaultAsync();

            return doacao;
        }

        public IEnumerable<Object> BuscarTodos()
        {
            try
            {
                IEnumerable<object> doacoes = RetornaDoacoes();
                return doacoes;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar doação: {ex.Message}");
            }
        }

        public async Task ExcluirDoacao(Doacao doacao)
        {
            try
            {
                _contexto.Doacao.Remove(doacao);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir doação: {ex.Message}");
            }
        }

        public async Task InserirDoacao(Doacao doacao)
        {
            try
            {
                await _contexto.Doacao.AddAsync(doacao);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir doação: {ex.Message}");
            }
        }


        private IEnumerable<object> RetornaDoacoes()
        {
            try
            {
                List<Doacao> doacoes = _contexto.Doacao.ToList();
                List<Doador> doadores = _contexto.Doador.ToList();
                List<Produto> produtos = _contexto.Produto.ToList();
                List<Colaborador> colaboradores = _contexto.Colaborador.ToList();

                var resultadoJoin = doacoes
                    .Join(
                        produtos,
                        doacaoProduto => doacaoProduto.PRODUTO_ID,
                        produtoDoacao => produtoDoacao.PRODUTO_ID,
                        (doacao, produto) => new { Doacao = doacao, Produto = produto }
                    )
                    .Join(
                        doadores,
                        doacaodoadores => doacaodoadores.Doacao.DOADOR_ID,
                        doadorDoacao => doadorDoacao.DOADOR_ID,
                        (doacaoProduto, doador) => new
                        {
                            Doacao = doacaoProduto.Doacao,
                            Produto = doacaoProduto.Produto,
                            Doador = doador
                        }
                    )
                    .Join(
                        colaboradores,
                        doacaoProdutoDoador => doacaoProdutoDoador.Doador.COLABORADOR_ID,
                        colaborador => colaborador.COLABORADOR_ID,
                        (doacaoProdutoDoador, colaborador) => new
                        {
                            Doacao = doacaoProdutoDoador.Doacao,
                            Produto = doacaoProdutoDoador.Produto,
                            Doador = doacaoProdutoDoador.Doador,
                            Colaborador = colaborador
                        }
                    )
                    .ToList();

                return resultadoJoin;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar todas as doações: {ex.Message}");
            }
        }
    }
}
