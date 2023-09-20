using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.ValueObject
{
    internal class Estoque
    {
        public int ESTOQUE_ID { get; private set; }
        public int PRODUTO_ID { get; private set; }
        public DateTime DATA_ENTRADA { get; private set; }
        public DateTime DATA_SAIDA { get; private set; }
        public DateTime DATA_VENCIMENTO { get; private set; }
        public string LOCAL_PRODUTO { get; private set; }
        public char VENCIMENTO_FLAG { get; private set; }
        public int QUANTIDADE_ITENS { get; private set; }
        public decimal PESO_TOTAL { get; private set; }
        public string USUARIO_RETIRADA_ESTOQUE { get; private set; }
    }
}
