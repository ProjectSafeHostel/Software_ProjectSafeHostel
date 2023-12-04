using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.ViewModels.ValueObject
{
    public class RegistroViewModel
    {
        public int REGISTRO_ID { get; set; }
        public DateTime DATA_REGISTRO { get; set; }
        public int TERMINACAO_FLAG { get; set; }
        public string TERMINACAO_MOTIVO { get; set; }
        public int DOACAO_ID { get; set; }
        public int COLABORADOR_ID { get; set; }
        public int CLIENTE_ID { get; set; }
    }
}
