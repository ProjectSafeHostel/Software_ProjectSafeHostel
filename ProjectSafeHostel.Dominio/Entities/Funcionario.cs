using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    public class Funcionario
    {
        #region - Construtores

        public Funcionario() { }

        public Funcionario(char fUNCAO, decimal sALARIO, int cOLABORADOR_ID)
        {
            FUNCAO = fUNCAO;
            SALARIO = sALARIO;
            COLABORADOR_ID = cOLABORADOR_ID;
        }

        #endregion

        public int FUNCIONARIO_ID { get; set; }
        public char FUNCAO { get; set; }
        public decimal SALARIO { get; set; }
        public int COLABORADOR_ID { get; set; }

        // Propriedade de navegação
        public Colaborador COLABORADOR { get; set; }
    }
}
