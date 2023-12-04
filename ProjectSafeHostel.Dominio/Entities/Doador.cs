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
        #region - Construtores

        public Doador(string cPF, string cNPJ, int cOLABORADOR_ID)
        {
            CPF = cPF;
            CNPJ = cNPJ;
            COLABORADOR_ID = cOLABORADOR_ID;
        }

        public Doador(int dOADOR_ID, string cPF, string cNPJ, int cOLABORADOR_ID)
        {
            DOADOR_ID = dOADOR_ID;
            CPF = cPF;
            CNPJ = cNPJ;
            COLABORADOR_ID = cOLABORADOR_ID;
        }

        #endregion


        public int DOADOR_ID { get; private set; }
        public string CPF { get; private set; }
        public string CNPJ { get; private set; }
        public int COLABORADOR_ID { get; private set; }

        // Propriedade de navegação
        public Colaborador COLABORADOR { get; private set; }
    }
}
