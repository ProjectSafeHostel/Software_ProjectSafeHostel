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
    public class Endereco
    {
        #region - Construtores

        public Endereco() { }

        public Endereco(string lOGRADOURO, string nUMERO, string? cOMPLEMENTO, string cIDADE, string? cEP, int cOLABORADOR_ID)
        {
            LOGRADOURO = lOGRADOURO;
            NUMERO = nUMERO;
            COMPLEMENTO = cOMPLEMENTO;
            CIDADE = cIDADE;
            CEP = cEP;
            COLABORADOR_ID = cOLABORADOR_ID;
        }

        public Endereco(int eNDERECO_ID, string lOGRADOURO, string nUMERO, string? cOMPLEMENTO, string cIDADE, string? cEP, int cOLABORADOR_ID)
        {
            ENDERECO_ID = eNDERECO_ID;
            LOGRADOURO = lOGRADOURO;
            NUMERO = nUMERO;
            COMPLEMENTO = cOMPLEMENTO;
            CIDADE = cIDADE;
            CEP = cEP;
            COLABORADOR_ID = cOLABORADOR_ID;
        }

        #endregion


        public int ENDERECO_ID { get; set; }
        public string LOGRADOURO { get; set; }
        public string NUMERO { get; set; }
        public string? COMPLEMENTO { get; set; }
        public string CIDADE { get; set; }
        public string? CEP { get; set; }
        public int COLABORADOR_ID { get; set; }

        // Propriedade de navegação
        public Colaborador COLABORADOR { get; private set; }
    }
}
