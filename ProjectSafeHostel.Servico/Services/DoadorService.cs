using AutoMapper;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Dominio.Interfaces;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels.Entities.Doador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.Services
{
    public class DoadorService : IDoadorService
    {
        #region - Atributos e Construtores

        private readonly IDoadorRepository _doadorRepository;
        private IMapper _mapper;

        public DoadorService(IDoadorRepository doadorRepository, IMapper mapper)
        {
            _doadorRepository = doadorRepository;
            _mapper = mapper;
        }

        #endregion

        #region - Funções

        public Task AtualizarDoador(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DoadorViewModel> BuscarPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public Task<DoadorViewModel> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DoadorViewModel> BuscarTodos()
        {
            return (IEnumerable<DoadorViewModel>)_doadorRepository.BuscarTodos();
        }

        public async Task ExcluirDoador(int id)
        {
            Doador buscaDoador = await _doadorRepository.BuscarPorId(id);

            if (buscaDoador == null) throw new ApplicationException("Não é possível excluir um doador que não existe!");

            await _doadorRepository.ExcluirDoador(buscaDoador);
        }

        public async Task InserirDoador(NovoDoadorViewModel doador)
        {
            Doador novoDoador = _mapper.Map<Doador>(doador);
            await _doadorRepository.InserirDoador(novoDoador);
        }

        #endregion

        #region - Regras de Negócio

        #endregion
    }
}
