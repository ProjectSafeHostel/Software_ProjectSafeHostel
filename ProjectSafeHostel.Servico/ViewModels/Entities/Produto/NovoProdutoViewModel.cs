using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.ViewModels.Entities.Produto
{
    public class NovoProdutoViewModel
    {
        public string PRODUTO_DESC { get; set; }
        public decimal PRODUTO_VALOR { get; set; }
        public int PERECIVEL_FLAG { get; set; }
        public decimal PESO_ITEM { get; set; }
        public int PRODUTO_FAMILIA_ID { get; set; }
        public int ADMINISTRADOR_ID { get; set; }
    }
}
