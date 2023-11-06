using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    public class Colaborador
    {
        public int COLABORADOR_ID { get; private set; }
        public string NOME { get; private set; }
        public string SOBRENOME { get; private set; }
        public int IDADE { get; private set; }
        public string TIPO { get; private set; }
        public string CPF { get; private set; }
        public DateTime DATA_CONTRATACAO { get; private set; }
        public DateTime DATA_TERMINACAO { get; private set; }
        public bool TERMINACAO_FLAG { get; private set; }
    }
}
