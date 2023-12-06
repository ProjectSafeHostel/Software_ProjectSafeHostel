using ProjectSafeHostel.Servico.ViewModels.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.Interfaces
{
    public interface IProdutoService
    {
        IEnumerable<ProdutoViewModel> BuscarTodos();
        Task<ProdutoViewModel> BuscarPorId(int id);
        Task InserirProduto(NovoProdutoViewModel produto);
        Task AtualizarProduto(int id);
        Task ExcluirProduto(int id);
    }
}
