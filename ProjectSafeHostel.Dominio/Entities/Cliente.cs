using ProjectSafeHostel.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    public class Cliente
    {
        public int CLIENTE_ID { get; private set; }
        public string NOME { get; private set; }
        public string FOTO { get; private set; }
        public int ATIVO_FLAG { get; private set; }
    }
}
