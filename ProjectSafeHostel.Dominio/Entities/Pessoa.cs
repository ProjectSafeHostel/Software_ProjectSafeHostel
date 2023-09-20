using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    internal class Pessoa
    {
        public int PESSOA_ID { get; private set; }
        public string NOME { get; private set; }
        public string SOBRENOME { get; private set; }
        public int IDADE { get; private set; }
        public string TIPO { get; private set; }
        public string CPF { get; private set; }]
        public DateTime DATA_CONTRATACAO { get; private set; }
        public DateTime DATA_TERMINACAO { get; private set; }
        public char TERMINACAO_FLAG { get; private set; }
        public int ENDERECO_ID { get; private set; }
        public int ALBERGUE_ID { get; private set; }
    }
}
