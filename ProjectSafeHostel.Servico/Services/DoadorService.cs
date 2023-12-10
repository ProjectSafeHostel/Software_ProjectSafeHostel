using AutoMapper;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Dominio.Interfaces;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels.Cadastros;
using ProjectSafeHostel.Servico.ViewModels.Entities.Colaborador;
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
        private readonly IColaboradorRepository _colaboradorRepository;
        private readonly IEnderecoRepository _enderecoRepository;
        private IMapper _mapper;

        public DoadorService(IDoadorRepository doadorRepository, IColaboradorRepository colaboradorRepository, IEnderecoRepository enderecoRepository, IMapper mapper)
        {
            _doadorRepository = doadorRepository;
            _colaboradorRepository = colaboradorRepository;
            _enderecoRepository = enderecoRepository;
            _mapper = mapper;
        }

        #endregion

        #region - Funções

        public Task AtualizarDoador(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<DoadorViewModel> BuscarPorCpfCnpj(string cpfCnpj)
        {
            Doador doador;
            if (cpfCnpj.Length > 11)
            {
                doador = await _doadorRepository.BuscarPorCnpj(cpfCnpj);
            }
            else
            {
                doador = await _doadorRepository.BuscarPorCpf(cpfCnpj);
            }

            DoadorViewModel buscaDoadorCpfCnpj = _mapper.Map<DoadorViewModel>(doador);

            return buscaDoadorCpfCnpj;
        }

        public async Task<DoadorViewModel> BuscarPorId(int id)
        {
            var doador = await _doadorRepository.BuscarPorId(id);

            DoadorViewModel buscaDoadorId = _mapper.Map<DoadorViewModel>(doador);

            return buscaDoadorId;
        }

        public IEnumerable<object> BuscarTodos()
        {
            try
            {
                var doadores = _doadorRepository.BuscarTodos();

                return doadores;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar todos os doadores com colaboradores: {ex.Message}");
            }
        }

        public async Task ExcluirDoador(int id)
        {
            Doador buscaDoador = await _doadorRepository.BuscarPorId(id);

            if (buscaDoador == null) throw new ApplicationException("Não é possível excluir um doador que não existe!");

            int colaboradorID = buscaDoador.COLABORADOR_ID;

            Colaborador colaboradorExcluido = await _colaboradorRepository.BuscarPorId(colaboradorID);
            Endereco enderecoExcluido = await _enderecoRepository.BuscarPorId(colaboradorID);

            await _enderecoRepository.ExcluirEndereco(enderecoExcluido);
            await _doadorRepository.ExcluirDoador(buscaDoador);
            await _colaboradorRepository.ExcluirColaborador(colaboradorExcluido);
        }

        public async Task InserirDoador(CadastrarDoadorViewModel doador)
        {
            var novoColaborador = _mapper.Map<Colaborador>(doador.Colaborador);

            if(novoColaborador.CPF.Length == 14)
            {
                novoColaborador.CPF = "";
            }
            novoColaborador.DATA_CONTRATACAO = DateTime.Now;
            novoColaborador.DATA_TERMINACAO = null;
            novoColaborador.TIPO = 'D';
            await _colaboradorRepository.InserirColaborador(novoColaborador);

            int colaboradorId = await _colaboradorRepository.BuscarId();
            doador.Doador.COLABORADOR_ID = colaboradorId;
            doador.Endereco.COLABORADOR_ID = colaboradorId;          

            var novoDoador = _mapper.Map<Doador>(doador.Doador);
            await _doadorRepository.InserirDoador(novoDoador);

            var novoEndereco = _mapper.Map<Endereco>(doador.Endereco);
            await _enderecoRepository.InserirEndereco(novoEndereco);
        }

        #endregion
    }
}
