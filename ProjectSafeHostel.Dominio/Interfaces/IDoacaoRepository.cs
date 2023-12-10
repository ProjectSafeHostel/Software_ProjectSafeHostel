using ProjectSafeHostel.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Interfaces
{
    public interface IDoacaoRepository
    {
        IEnumerable<Object> BuscarTodos();
        Task<Doacao> BuscarPorId(int id);
        Task InserirDoacao(Doacao doacao);
        Task AtualizarDoacao(Doacao doacao);
        Task ExcluirDoacao(Doacao doacao);
    }
}
