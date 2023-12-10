using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    public class Colaborador
    {
        #region - Construtores

        public Colaborador() { }

        public Colaborador(string nOME, string sOBRENOME, DateTime? dATA_NASCIMENTO, char tIPO, string? cPF, DateTime dATA_CONTRATACAO, DateTime? dATA_TERMINACAO, int tERMINACAO_FLAG)
        {
            NOME = nOME;
            SOBRENOME = sOBRENOME;
            DATA_NASCIMENTO = dATA_NASCIMENTO;
            TIPO = tIPO;
            CPF = cPF;
            DATA_CONTRATACAO = DateTime.Now;
            DATA_TERMINACAO = dATA_TERMINACAO;
            TERMINACAO_FLAG = 0;
        }

        public Colaborador(int cOLABORADOR_ID, string nOME, string sOBRENOME, DateTime? dATA_NASCIMENTO, char tIPO, string? cPF, DateTime dATA_CONTRATACAO, DateTime? dATA_TERMINACAO, int tERMINACAO_FLAG)
        {
            COLABORADOR_ID = cOLABORADOR_ID;
            NOME = nOME;
            SOBRENOME = sOBRENOME;
            DATA_NASCIMENTO = dATA_NASCIMENTO;
            TIPO = tIPO;
            CPF = cPF;
            DATA_CONTRATACAO = dATA_CONTRATACAO;
            DATA_TERMINACAO = dATA_TERMINACAO;
            TERMINACAO_FLAG = tERMINACAO_FLAG;
        }

        #endregion

        public int COLABORADOR_ID { get; set; }
        public string NOME { get; set; }
        public string SOBRENOME { get; set; }
        public DateTime? DATA_NASCIMENTO { get; set; }
        public char TIPO { get; set; }
        public string? CPF { get; set; }
        public DateTime DATA_CONTRATACAO { get; set; }
        public DateTime? DATA_TERMINACAO { get; set; }
        public int TERMINACAO_FLAG { get; set; }
    }
}
