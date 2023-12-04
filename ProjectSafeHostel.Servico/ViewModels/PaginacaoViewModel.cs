using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.ViewModels
{
    public class PaginacaoViewModel<T>
    {
        public List<T> Itens { get; set; }
        public Paginacao Paginacao { get; set; }
    }

    public class Paginacao
    {
        public int ItensPorPagina { get; set; }
        public int PaginaAtual { get; set; }
        public int TotalItens { get; set; }

        public int TotalPaginas
        {
            get { return (int)Math.Ceiling((double)TotalItens / ItensPorPagina); }
        }
    }
}
