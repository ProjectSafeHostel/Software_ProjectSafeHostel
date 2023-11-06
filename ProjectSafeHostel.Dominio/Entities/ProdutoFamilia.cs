using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    public class ProdutoFamilia
    {
        public int PRODUTO_FAMILIA_ID { get; private set; }
        public string FAMILIA { get; private set; }
        public int PRODUTO_CATEGORIA_ID { get; private set; }

        // Propriedade de navegação
        public ProdutoCategoria PRODUTO_CATEGORIA { get; private set; }
    }
}
