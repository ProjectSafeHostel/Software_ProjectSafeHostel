using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    internal class Albergue
    {
        public int ALBERGUE_ID { get; private set; }
        public string NOME { get; private set; }
        public string CNPJ { get; private set; }
        public int ENDERECO_ID { get; private set; }
    }
}
