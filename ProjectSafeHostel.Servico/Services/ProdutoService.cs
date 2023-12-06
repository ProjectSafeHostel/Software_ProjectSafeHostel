using AutoMapper;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Dominio.Interfaces;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels.Entities.Produto;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoFamilia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.Services
{
    public class ProdutoService : IProdutoService
    {
        #region - Atributos e Construtores

        private readonly IProdutoRepository _produtoRepository;
        private IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        #endregion

        public Task AtualizarProduto(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProdutoViewModel> BuscarPorId(int id)
        {
            var produto = await _produtoRepository.BuscarPorId(id);

            ProdutoViewModel buscaProduto = _mapper.Map<ProdutoViewModel>(produto);

            return buscaProduto;
        }

        public IEnumerable<ProdutoViewModel> BuscarTodos()
        {
            try
            {
                var produto = _produtoRepository.BuscarTodos();

                return _mapper.Map<IEnumerable<ProdutoViewModel>>(produto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar produto: {ex.Message}");
            }
        }

        public async Task ExcluirProduto(int id)
        {
            var buscaProduto = await _produtoRepository.BuscarPorId(id);

            if (buscaProduto == null) throw new ApplicationException("Não é possível excluir um produto que não existe!");

            var buscaCategoria = await _produtoRepository.BuscarPorId(buscaProduto.PRODUTO_ID);
            await _produtoRepository.ExcluirProduto(buscaCategoria);

            await _produtoRepository.ExcluirProduto(buscaProduto);
        }

        public async Task InserirProduto(NovoProdutoViewModel produto)
        {
            produto.ADMINISTRADOR_ID = 1;
            var novoProduto = _mapper.Map<Produto>(produto);

            await _produtoRepository.InserirProduto(novoProduto);
        }
    }
}
