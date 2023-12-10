using ProjectSafeHostel.Servico.ViewModels.Cadastros;
using ProjectSafeHostel.Servico.ViewModels.ValueObject.Doacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.Interfaces
{
    public interface IDoacaoService
    {
        IEnumerable<Object> BuscarTodos();
        Task<DoacaoViewModel> BuscarPorId(int id);
        Task InserirDoacao(CadastrarDoacaoViewModel novaDoacao);
        Task AtualizarDoacao(int id);
        Task ExcluirDoacao(int id);
    }
}
