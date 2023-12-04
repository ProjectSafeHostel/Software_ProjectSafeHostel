using ProjectSafeHostel.Servico.ViewModels.Entities.Colaborador;
using ProjectSafeHostel.Servico.ViewModels.Entities.Doador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.ViewModels.Buscas
{
    public class BuscarDoadorViewModel
    {
        public int DoadorId { get; set; }
        public string? CPF { get; set; }
        public string? CNPJ { get; set; }

        // Propriedades do Colaborador
        public int ColaboradorId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Tipo { get; set; }
        public string? ColaboradorCPF { get; set; }
        public DateTime DataContratacao { get; set; }
        public DateTime? DataTerminacao { get; set; }
        public int TerminacaoFlag { get; set; }
    }
}
