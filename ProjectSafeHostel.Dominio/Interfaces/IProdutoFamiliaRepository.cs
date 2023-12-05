using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Interfaces
{
    public interface IProdutoFamiliaRepository
    {
        Task<IEnumerable<ProdutoFamilia>> BuscarTodos();
        Task<ProdutoFamilia> BuscarPorId(int id);
        Task InserirProdutoFamilia(ProdutoFamilia produtoFamilia);
        Task AtualizarProdutoFamilia(ProdutoFamilia produtoFamilia);
        Task ExcluirProdutoFamilia(ProdutoFamilia produtoFamilia);
    }
}
