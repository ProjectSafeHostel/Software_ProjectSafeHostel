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
        public Produto(string pRODUTO_DESC, decimal pRODUTO_VALOR, int pERECIVEL_FLAG, decimal pESO_ITEM, int pRODUTO_FAMILIA_ID, int aDMINISTRADOR_ID)
        {
            PRODUTO_DESC = pRODUTO_DESC;
            PRODUTO_VALOR = pRODUTO_VALOR;
            PERECIVEL_FLAG = pERECIVEL_FLAG;
            PESO_ITEM = pESO_ITEM;
            PRODUTO_FAMILIA_ID = pRODUTO_FAMILIA_ID;
            ADMINISTRADOR_ID = aDMINISTRADOR_ID;
        }

        public Produto(int pRODUTO_ID, string pRODUTO_DESC, decimal pRODUTO_VALOR, int pERECIVEL_FLAG, decimal pESO_ITEM, int pRODUTO_FAMILIA_ID, int aDMINISTRADOR_ID)
        {
            PRODUTO_ID = pRODUTO_ID;
            PRODUTO_DESC = pRODUTO_DESC;
            PRODUTO_VALOR = pRODUTO_VALOR;
            PERECIVEL_FLAG = pERECIVEL_FLAG;
            PESO_ITEM = pESO_ITEM;
            PRODUTO_FAMILIA_ID = pRODUTO_FAMILIA_ID;
            ADMINISTRADOR_ID = aDMINISTRADOR_ID;
        }

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
