using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.ValueObject
{
    public class Doacao
    {
        public int DOACAO_ID { get; private set; }
        public int DOADOR_ID { get; private set; }
        public int PRODUTO_ID { get; private set; }

        // Propriedade de navegação
        public Doador DOADOR { get; private set; }
        public Produto PRODUTO { get; private set; }
    }
}
