using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.ViewModels.ValueObject
{
    public class DoacaoViewModel
    {
        public int DOACAO_ID { get; set; }
        public int DOADOR_ID { get; set; }
        public int PRODUTO_ID { get; set; }
    }
}
