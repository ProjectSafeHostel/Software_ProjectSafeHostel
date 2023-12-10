using AutoMapper;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Dominio.Interfaces;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoCategoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.Services
{
    public class ProdutoCategoriaService : IProdutoCategoriaService
    {
        #region - Atributos e Construtores

        private readonly IProdutoCategoriaRepository _produtoCategoriaRepository;
        private IMapper _mapper;

        public ProdutoCategoriaService(IProdutoCategoriaRepository produtoCategoriaRepository, IMapper mapper)
        {
            _produtoCategoriaRepository = produtoCategoriaRepository;
            _mapper = mapper;
        }

        #endregion

        #region - Funções

        public Task AtualizarCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProdutoCategoriaViewModel> BuscarPorId(int id)
        {
            var categoria = await _produtoCategoriaRepository.BuscarPorId(id);

            ProdutoCategoriaViewModel buscaCategoria = _mapper.Map<ProdutoCategoriaViewModel>(categoria);

            return buscaCategoria;
        }

        public IEnumerable<ProdutoCategoriaViewModel> BuscarTodos()
        {
            try
            {
                var categorias = _produtoCategoriaRepository.BuscarTodos();

                return _mapper.Map<IEnumerable<ProdutoCategoriaViewModel>>(categorias);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar todas as categorias: {ex.Message}");
            }
        }

        public async Task ExcluirCategoria(int id)
        {
            var buscaCategoria = await _produtoCategoriaRepository.BuscarPorId(id);

            if (buscaCategoria == null) throw new ApplicationException("Não é possível excluir uma categoria que não existe!");

            await _produtoCategoriaRepository.ExcluirCategoria(buscaCategoria);
        }

        public async Task InserirCategoria(NovoProdutoCategoriaViewModel categoria)
        {
            var novaCategoria = _mapper.Map<ProdutoCategoria>(categoria);
            await _produtoCategoriaRepository.InserirCategoria(novaCategoria);
        }

        #endregion
    }
}
