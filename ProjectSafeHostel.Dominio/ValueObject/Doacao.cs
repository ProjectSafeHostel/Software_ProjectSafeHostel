using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.ValueObject
{
    internal class Doacao
    {
        public int DOACAO_ID { get; private set; }
        public int DOADOR_ID { get; private set; }
        public int PRODUTO_ID { get; private set; }
        public int REGISTRO_ID { get; private set; }
    }
}
