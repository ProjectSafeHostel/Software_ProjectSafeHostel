using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    public class Produto
    {
        public int PRODUTO_ID { get; private set; }
        public string PRODUTO_DESC { get; private set; }
        public decimal PRODUTO_VALOR { get; private set; }
        public int PERECIVEL_FLAG { get; private set; }
        public decimal PESO_ITEM { get; private set; }
        public int PRODUTO_FAMILIA_ID { get; private set; }
        public int ADMINISTRADOR_ID { get; private set; }

        // Propriedade de navegação
        public ProdutoFamilia PRODUTO_FAMILIA { get; private set; }
        public Administrador ADMINISTRADOR { get; private set; }
    }
}
