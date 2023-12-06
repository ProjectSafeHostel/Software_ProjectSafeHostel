using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> BuscarTodos();
        Task<Cliente> BuscarPorId(int id);
        Task InserirCliente(Cliente cliente);
        Task AtualizarCliente(Cliente cliente);
        Task ExcluirCliente(Cliente cliente);
    }
}
