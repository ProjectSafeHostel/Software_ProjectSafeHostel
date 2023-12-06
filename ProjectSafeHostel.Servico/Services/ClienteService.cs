using AutoMapper;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Dominio.Interfaces;
using ProjectSafeHostel.Servico.Interfaces;
using ProjectSafeHostel.Servico.ViewModels.Entities.Cliente;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoCategoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.Services
{
    public class ClienteService : IClienteService
    {
        #region - Atributos e Construtores

        private readonly IClienteRepository _clienteRepository;
        private IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IColaboradorRepository colaboradorRepository, IEnderecoRepository enderecoRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        #endregion

        public async Task AtualizarCliente(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ClienteViewModel> BuscarPorId(int id)
        {
            var cliente = await _clienteRepository.BuscarPorId(id);

            ClienteViewModel buscaClientea = _mapper.Map<ClienteViewModel>(cliente);

            return buscaClientea;
        }

        public IEnumerable<ClienteViewModel> BuscarTodos()
        {
            var cliente = _clienteRepository.BuscarTodos();

            return _mapper.Map<IEnumerable<ClienteViewModel>>(cliente);
        }

        public async Task ExcluirCliente(int id)
        {
            var buscaCliente = await _clienteRepository.BuscarPorId(id);

            if (buscaCliente == null) throw new ApplicationException("Não é possível excluir um cliente que não existe!");

            await _clienteRepository.ExcluirCliente(buscaCliente);
        }

        public async Task InserirCliente(NovoClienteViewModel novoCliente)
        {
            var cliente = _mapper.Map<Cliente>(novoCliente);
            await _clienteRepository.InserirCliente(cliente);
        }
    }
}
