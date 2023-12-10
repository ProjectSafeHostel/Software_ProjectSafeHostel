using ProjectSafeHostel.Servico.ViewModels.Cadastros;
using ProjectSafeHostel.Servico.ViewModels.Entities.Doador;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoCategoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.Interfaces
{
    public interface IProdutoCategoriaService
    {
        IEnumerable<ProdutoCategoriaViewModel> BuscarTodos();
        Task<ProdutoCategoriaViewModel> BuscarPorId(int id);
        Task InserirCategoria(NovoProdutoCategoriaViewModel categoria);
        Task AtualizarCategoria(int id);
        Task ExcluirCategoria(int id);
    }
}
