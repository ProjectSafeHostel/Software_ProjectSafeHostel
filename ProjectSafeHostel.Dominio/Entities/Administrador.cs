using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    internal class Administrador
    {
        public int ADMINISTRADOR_ID { get; private set; }
        public decimal SALARIO { get; private set; }
        public int PESSOA_ID { get; private set; }
        public int ALBERGUE_ID { get; private set; }
    }
}
