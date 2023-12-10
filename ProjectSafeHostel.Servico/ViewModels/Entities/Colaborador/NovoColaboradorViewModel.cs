using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.ViewModels.Entities.Colaborador
{
    public class NovoColaboradorViewModel
    {
        public string NOME { get; set; }
        public string SOBRENOME { get; set; }
        public DateTime? DATA_NASCIMENTO { get; set; }
        public string? CPF { get; set; }

        [JsonIgnore]
        public char TIPO { get; set; }
        [JsonIgnore]
        public DateTime DATA_CONTRATACAO { get; set; }
        [JsonIgnore]
        public DateTime DATA_TERMINACAO { get; set; }
        [JsonIgnore]
        public int TERMINACAO_FLAG { get; set; }
    }
}
