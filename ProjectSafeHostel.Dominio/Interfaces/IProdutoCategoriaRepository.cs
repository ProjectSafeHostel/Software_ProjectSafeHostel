using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Interfaces
{
    public interface IProdutoCategoriaRepository
    {
        IEnumerable<ProdutoCategoria> BuscarTodos();
        Task<ProdutoCategoria> BuscarPorId(int id);
        Task InserirCategoria(ProdutoCategoria produtoCategoria);
        Task AtualizarCategoria(ProdutoCategoria produtoCategoria);
        Task ExcluirCategoria(ProdutoCategoria produtoCategoria);
    }
}
