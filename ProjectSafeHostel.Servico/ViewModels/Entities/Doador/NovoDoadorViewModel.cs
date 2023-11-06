using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.ViewModels.Entities.Doador
{
    public class NovoDoadorViewModel
    {
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public int ENDERECO_ID { get; set; }
        public int COLABORADOR_ID { get; set; }

        // Propriedade de navegação
        public Endereco ENDERECO { get; set; }
        public Colaborador COLABORADOR { get; set; }
    }
}
