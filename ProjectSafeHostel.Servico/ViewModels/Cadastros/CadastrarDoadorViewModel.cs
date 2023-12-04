using ProjectSafeHostel.Servico.ViewModels.Entities.Colaborador;
using ProjectSafeHostel.Servico.ViewModels.Entities.Doador;
using ProjectSafeHostel.Servico.ViewModels.Entities.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.ViewModels.Cadastros
{
    public class CadastrarDoadorViewModel
    {
        public NovoDoadorViewModel Doador { get; set; }
        public NovoColaboradorViewModel Colaborador { get; set; }
        public NovoEnderecoViewModel Endereco { get; set; }
    }
}
