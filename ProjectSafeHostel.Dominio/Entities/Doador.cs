using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    internal class Doador
    {
        public int DOADOR_ID { get; private set; }
        public string CPF { get; private set; }
        public string CNPJ { get; private set; }
        public int ENDERECO_ID { get; private set; }
        public int REGISTRO_ID { get; private set; }
        public int PESSOA_ID { get; private set; }
        public int ALBERGUE_ID { get; private set; }
    }
}
