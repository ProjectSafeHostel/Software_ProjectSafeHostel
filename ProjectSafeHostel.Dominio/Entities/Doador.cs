using ProjectSafeHostel.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    public class Doador
    {
        public Doador(string cPF, string cNPJ, int eNDERECO_ID, int cOLABORADOR_ID, Endereco eNDERECO, Colaborador cOLABORADOR)
        {
            CPF = cPF;
            CNPJ = cNPJ;
            ENDERECO_ID = eNDERECO_ID;
            COLABORADOR_ID = cOLABORADOR_ID;
            ENDERECO = eNDERECO;
            COLABORADOR = cOLABORADOR;
        }

        public Doador(int dOADOR_ID, string cPF, string cNPJ, int eNDERECO_ID, int cOLABORADOR_ID, Endereco eNDERECO, Colaborador cOLABORADOR)
        {
            DOADOR_ID = dOADOR_ID;
            CPF = cPF;
            CNPJ = cNPJ;
            ENDERECO_ID = eNDERECO_ID;
            COLABORADOR_ID = cOLABORADOR_ID;
            ENDERECO = eNDERECO;
            COLABORADOR = cOLABORADOR;
        }


        public int DOADOR_ID { get; private set; }
        public string CPF { get; private set; }
        public string CNPJ { get; private set; }
        public int ENDERECO_ID { get; private set; }
        public int COLABORADOR_ID { get; private set; }

        // Propriedade de navegação
        public Endereco ENDERECO { get; private set; }
        public Colaborador COLABORADOR { get; private set; }



    }
}
