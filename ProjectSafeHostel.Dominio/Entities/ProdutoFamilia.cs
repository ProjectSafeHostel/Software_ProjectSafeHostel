using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    public class ProdutoFamilia
    {
        public ProdutoFamilia(string fAMILIA, int pRODUTO_CATEGORIA_ID)
        {
            FAMILIA = fAMILIA;
            PRODUTO_CATEGORIA_ID = pRODUTO_CATEGORIA_ID;
        }

        public ProdutoFamilia(int pRODUTO_FAMILIA_ID, string fAMILIA, int pRODUTO_CATEGORIA_ID)
        {
            PRODUTO_FAMILIA_ID = pRODUTO_FAMILIA_ID;
            FAMILIA = fAMILIA;
            PRODUTO_CATEGORIA_ID = pRODUTO_CATEGORIA_ID;
        }

        public int PRODUTO_FAMILIA_ID { get; private set; }
        public string FAMILIA { get; private set; }
        public int PRODUTO_CATEGORIA_ID { get; private set; }

        // Propriedade de navegação
        [JsonIgnore]
        public ProdutoCategoria PRODUTO_CATEGORIA { get; private set; }
    }
}
