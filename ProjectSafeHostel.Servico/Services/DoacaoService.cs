using AutoMapper;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Dominio.Interfaces;
using ProjectSafeHostel.Dominio.ValueObject;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels.Cadastros;
using ProjectSafeHostel.Servico.ViewModels.Entities.Produto;
using ProjectSafeHostel.Servico.ViewModels.ValueObject.Doacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.Services
{
    public class DoacaoService : IDoacaoService
    {
        #region - Atributos e Construtores

        private readonly IDoacaoRepository _doacaoRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutoService _produtoService;
        private IMapper _mapper;

        public DoacaoService(IDoacaoRepository doacaoRepository, IProdutoRepository produtoRepository, IProdutoService produtoService, IMapper mapper)
        {
            _doacaoRepository = doacaoRepository;
            _produtoRepository = produtoRepository;
            _produtoService = produtoService;
            _mapper = mapper;
        }

        #endregion


        public Task AtualizarDoacao(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<DoacaoViewModel> BuscarPorId(int id)
        {
            var doacao = await _doacaoRepository.BuscarPorId(id);

            var buscaDoacaoId = _mapper.Map<DoacaoViewModel>(doacao);

            return buscaDoacaoId;
        }

        public IEnumerable<Object> BuscarTodos()
        {
            try
            {
                var doacoes = _doacaoRepository.BuscarTodos();

                return doacoes;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar todas as doações: {ex.Message}");
            }
        }

        public async Task ExcluirDoacao(int id)
        {
            var buscaDoacao = await _doacaoRepository.BuscarPorId(id);

            if (buscaDoacao == null) throw new ApplicationException("Não é possível excluir uma doação que não existe!");

            int produtoID = buscaDoacao.PRODUTO_ID;

            Produto produtoExcluido = await _produtoRepository.BuscarPorId(produtoID);

            await _produtoRepository.ExcluirProduto(produtoExcluido);
            await _doacaoRepository.ExcluirDoacao(buscaDoacao);
        }

        public async Task InserirDoacao(CadastrarDoacaoViewModel novaDoacao)
        {
            var novoProduto = _mapper.Map<NovoProdutoViewModel>(novaDoacao.Produto);
            await _produtoService.InserirProduto(novoProduto);

            int produtoId = await _produtoRepository.BuscarId();

            var doacao = new NovaDoacaoViewModel();
            doacao.DOADOR_ID = novaDoacao.Doador_id;
            doacao.PRODUTO_ID = produtoId;

            var doacaoInserida = _mapper.Map<Doacao>(doacao);
            await _doacaoRepository.InserirDoacao(doacaoInserida);
        }
    }
}
