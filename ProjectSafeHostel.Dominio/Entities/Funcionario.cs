using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    public class Funcionario
    {
        public int FUNCIONARIO_ID { get; private set; }
        public string FUNCAO { get; private set; }
        public decimal SALARIO { get; private set; }
        public int COLABORADOR_ID { get; private set; }

        // Propriedade de navegação
        public Colaborador COLABORADOR { get; private set; }
    }
}
