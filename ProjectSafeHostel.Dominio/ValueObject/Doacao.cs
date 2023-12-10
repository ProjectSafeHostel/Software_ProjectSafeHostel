using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.ValueObject
{
    public class Doacao
    {
        public Doacao(int dOADOR_ID, int pRODUTO_ID)
        {
            DOADOR_ID = dOADOR_ID;
            PRODUTO_ID = pRODUTO_ID;
        }

        public Doacao(int dOACAO_ID, int dOADOR_ID, int pRODUTO_ID)
        {
            DOACAO_ID = dOACAO_ID;
            DOADOR_ID = dOADOR_ID;
            PRODUTO_ID = pRODUTO_ID;
        }

        public int DOACAO_ID { get; private set; }
        public int DOADOR_ID { get; private set; }
        public int PRODUTO_ID { get; private set; }


        // Propriedade de navegação
        [JsonIgnore]
        public Doador DOADOR { get; private set; }
        [JsonIgnore]
        public Produto PRODUTO { get; private set; }
    }
}
