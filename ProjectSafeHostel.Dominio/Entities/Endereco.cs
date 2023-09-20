using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    internal class Endereco
    {
        public int ENDERECO_ID { get; private set; }
        public string RUA { get; private set; }
        public int NUMERO { get; private set; }
        public string COMPLEMENTO { get; private set; }
        public string CIDADE { get; private set; }
        public string CEP { get; private set; }
    }
}
