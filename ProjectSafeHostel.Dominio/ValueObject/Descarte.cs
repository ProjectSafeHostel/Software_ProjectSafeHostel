using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.ValueObject
{
    public class Descarte
    {
        public int DESCARTE_ID { get; private set; }
        public string MOTIVO_DESCARTE { get; private set; }
        public Produto PRODUTO_ID { get; private set; }
        public Funcionario FUNCIONARIO_ID { get; private set; }
    }
}
