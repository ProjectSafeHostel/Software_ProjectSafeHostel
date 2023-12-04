using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Servico.ViewModels.Entities.Colaborador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.ViewModels.Cadastros
{
    public class CadastrarFuncionarioViewModel
    {
        public Colaborador Colaborador { get; set; }
        public Funcionario Funcionario { get; set; }
        public Endereco Endereco { get; set; }
    }
}
