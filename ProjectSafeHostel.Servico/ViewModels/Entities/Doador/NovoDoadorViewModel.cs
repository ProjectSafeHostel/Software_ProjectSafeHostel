using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Servico.ViewModels.Entities.Colaborador;
using ProjectSafeHostel.Servico.ViewModels.Entities.Endereco;
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
        public int COLABORADOR_ID { get; set; }
    }
}
