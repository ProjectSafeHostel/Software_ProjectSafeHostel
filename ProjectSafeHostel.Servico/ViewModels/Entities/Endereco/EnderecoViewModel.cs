using ProjectSafeHostel.Servico.ViewModels.Entities.Colaborador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.ViewModels.Entities.Endereco
{
    public class EnderecoViewModel
    {
        public int ENDERECO_ID { get; set; }
        public string LOGRADOURO { get; set; }
        public string NUMERO { get; set; }
        public string? COMPLEMENTO { get; set; }
        public string CIDADE { get; set; }
        public string? CEP { get; set; }
        public int COLABORADOR_ID { get; set; }
    }
}
