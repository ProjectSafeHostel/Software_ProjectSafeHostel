using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.ViewModels.Entities.Colaborador
{
    public class ColaboradorViewModel
    {
        public int COLABORADOR_ID { get; set; }
        public string NOME { get; set; }
        public string SOBRENOME { get; set; }
        public DateTime DATA_NASCIMENTO { get; set; }
        public char TIPO { get; set; }
        public string CPF { get; set; }
        public DateTime DATA_CONTRATACAO { get; set; }
        public DateTime? DATA_TERMINACAO { get; set; }
        public int TERMINACAO_FLAG { get; set; }
    }
}
