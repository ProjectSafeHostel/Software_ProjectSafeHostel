using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoCategoria;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoFamilia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.Interfaces
{
    public interface IProdutoFamiliaService
    {
        Task<IEnumerable<ProdutoFamiliaViewModel>> BuscarTodos();
        Task<ProdutoFamiliaViewModel> BuscarPorId(int id);
        Task InserirFamilia(NovoProdutoFamiliaViewModel familia);
        Task AtualizarFamilia(int id);
        Task ExcluirFamilia(int id);
    }
}
