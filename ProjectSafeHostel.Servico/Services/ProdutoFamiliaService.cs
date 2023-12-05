using AutoMapper;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Dominio.Interfaces;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoCategoria;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoFamilia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.Services
{
    public class ProdutoFamiliaService : IProdutoFamiliaService
    {
        #region - Atributos e Construtores

        private readonly IProdutoFamiliaRepository _produtoFamiliaRepository;
        private readonly IProdutoCategoriaRepository _produtoCategoriaRepository;
        private IMapper _mapper;

        public ProdutoFamiliaService(IProdutoFamiliaRepository produtoFamiliaRepository, IProdutoCategoriaRepository produtoCategoriaRepository, IMapper mapper)
        {
            _produtoFamiliaRepository = produtoFamiliaRepository;
            _produtoCategoriaRepository = produtoCategoriaRepository;
            _mapper = mapper;
        }

        #endregion

        #region - Funções

        public Task AtualizarFamilia(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProdutoFamiliaViewModel> BuscarPorId(int id)
        {
            var familia = await _produtoFamiliaRepository.BuscarPorId(id);

            ProdutoFamiliaViewModel buscaFamilia = _mapper.Map<ProdutoFamiliaViewModel>(familia);

            return buscaFamilia;
        }

        public async Task<IEnumerable<ProdutoFamiliaViewModel>> BuscarTodos()
        {
            try
            {
                var familia = await _produtoFamiliaRepository.BuscarTodos();

                return _mapper.Map<IEnumerable<ProdutoFamiliaViewModel>>(familia);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar familia: {ex.Message}");
            }
        }

        public async Task ExcluirFamilia(int id)
        {
            var buscaFamilia = await _produtoFamiliaRepository.BuscarPorId(id);

            if (buscaFamilia == null) throw new ApplicationException("Não é possível excluir uma familia que não existe!");

            var buscaCategoria = await _produtoCategoriaRepository.BuscarPorId(buscaFamilia.PRODUTO_CATEGORIA_ID);
            await _produtoCategoriaRepository.ExcluirCategoria(buscaCategoria);

            await _produtoFamiliaRepository.ExcluirProdutoFamilia(buscaFamilia);
        }

        public async Task InserirFamilia(NovoProdutoFamiliaViewModel familia)
        {
            var novaFamiliaa = _mapper.Map<ProdutoFamilia>(familia);
            await _produtoFamiliaRepository.InserirProdutoFamilia(novaFamiliaa);
        }

        #endregion
    }
}
