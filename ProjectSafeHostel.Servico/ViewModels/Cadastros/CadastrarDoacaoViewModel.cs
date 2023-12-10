using ProjectSafeHostel.Servico.ViewModels.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.ViewModels.Cadastros
{
    public class CadastrarDoacaoViewModel
    {
        public NovoProdutoViewModel Produto { get; set; }
        public int Doador_id { get; set; }
    }
}
