using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    internal class Cliente
    {
        public string CLIENTE_ID { get; private set; }
        public string NOME { get; private set; }
        public string FOTO { get; private set; }
        public char ATIVO_FLAG { get; private set; }
        public int REGISTRO_ID { get; private set; }
    }
}
