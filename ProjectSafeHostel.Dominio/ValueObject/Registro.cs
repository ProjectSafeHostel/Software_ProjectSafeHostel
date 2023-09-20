using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.ValueObject
{
    internal class Registro
    {
        public int REGISTRO_ID { get; private set; }
        public DateTime REGISTRO_DATA { get; private set; }
        public char TERMINACAO_FLAG { get; private set; }
        public string TERMINACAO_MOTIVO { get; private set; }
    }
}
