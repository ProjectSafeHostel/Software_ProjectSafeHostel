using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> BuscarTodos();
        Task<Produto> BuscarPorId(int id);
        Task InserirProduto(Produto produto);
        Task AtualizarProduto(Produto produto);
        Task ExcluirProduto(Produto produto);
    }
}
