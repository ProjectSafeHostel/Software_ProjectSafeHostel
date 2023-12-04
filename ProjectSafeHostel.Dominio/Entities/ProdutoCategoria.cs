using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    public class ProdutoCategoria
    {
        public ProdutoCategoria(string dESCRICAO)
        {
            DESCRICAO = dESCRICAO;
        }

        public ProdutoCategoria(int pRODUTO_CATEGORIA_ID, string dESCRICAO)
        {
            PRODUTO_CATEGORIA_ID = pRODUTO_CATEGORIA_ID;
            DESCRICAO = dESCRICAO;
        }

        public int PRODUTO_CATEGORIA_ID { get; private set; }
        public string DESCRICAO { get; private set; }
    }
}
