using ProjectSafeHostel.Servico.ViewModels.Cadastros;
using ProjectSafeHostel.Servico.ViewModels.Entities.Colaborador;
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
        IEnumerable<object> BuscarTodos();
        Task<DoadorViewModel> BuscarPorCpfCnpj(string cpfCnpj);
        Task<DoadorViewModel> BuscarPorId(int id);
        Task InserirDoador(CadastrarDoadorViewModel doador);
        Task AtualizarDoador(int id);
        Task ExcluirDoador(int id);
    }
}
