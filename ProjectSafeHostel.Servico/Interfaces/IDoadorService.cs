using ProjectSafeHostel.Servico.ViewModels.Entities.Doador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.Interfaces
{
    public interface IDoadorService
    {
        IEnumerable<DoadorViewModel> BuscarTodos();
        IEnumerable<DoadorViewModel> BuscarPorCpf(string cpf);
        Task<DoadorViewModel> BuscarPorId(int id);
        Task InserirDoador(NovoDoadorViewModel doador);
        Task AtualizarDoador(int id);
        Task ExcluirDoador(int id);
    }
}
