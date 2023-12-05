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
        public Cliente(string nOME, string? fOTO, int aTIVO_FLAG)
        {
            NOME = nOME;
            FOTO = fOTO;
            ATIVO_FLAG = aTIVO_FLAG;
        }

        public Cliente(int cLIENTE_ID, string nOME, string? fOTO, int aTIVO_FLAG)
        {
            CLIENTE_ID = cLIENTE_ID;
            NOME = nOME;
            FOTO = fOTO;
            ATIVO_FLAG = aTIVO_FLAG;
        }

        public int CLIENTE_ID { get; private set; }
        public string NOME { get; private set; }
        public string? FOTO { get; private set; } = "";
        public int ATIVO_FLAG { get; private set; } = 0;
    }
}
