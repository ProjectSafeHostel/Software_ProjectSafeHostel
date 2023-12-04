using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Interfaces
{
    public interface IColaboradorRepository
    {
        IEnumerable<Colaborador> BuscarTodos();
        Task<Colaborador> BuscarPorCpf(string cpf);
        Task<Colaborador> BuscarPorId(int id);
        Task<int> BuscarId();
        Task InserirColaborador(Colaborador colaborador);
        Task AtualizarColaborador(Colaborador colaborador);
        Task ExcluirColaborador(Colaborador colaborador);
    }
}
