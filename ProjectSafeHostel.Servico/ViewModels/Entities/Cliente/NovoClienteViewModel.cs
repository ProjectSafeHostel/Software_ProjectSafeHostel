using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.ViewModels.Entities.Cliente
{
    public class NovoClienteViewModel
    {
        public int CLIENTE_ID { get; set; }
        public string NOME { get; set; }
        public string? FOTO { get; set; } = "";
        public int ATIVO_FLAG { get; set; } = 0;
    }
}
