using ProjectSafeHostel.Servico.ViewModels.Entities.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.Interfaces
{
    public interface IClienteService
    {
        IEnumerable<ClienteViewModel> BuscarTodos();
        Task<ClienteViewModel> BuscarPorId(int id);
        Task InserirCliente(NovoClienteViewModel novoCliente);
        Task AtualizarCliente(int id);
        Task ExcluirCliente(int id);
    }
}
