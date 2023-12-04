using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.ValueObject
{
    public class Registro
    {
        public int REGISTRO_ID { get; private set; }
        public DateTime DATA_REGISTRO { get; private set; }
        public int TERMINACAO_FLAG { get; private set; }
        public string TERMINACAO_MOTIVO { get; private set; }
        public int DOACAO_ID { get; private set; }
        public int COLABORADOR_ID { get; private set; }
        public int CLIENTE_ID { get; private set; }

        // Propriedade de navegação
        public Doacao DOACAO { get; private set; }
        public Colaborador COLABORADOR { get; private set; }
        public Cliente CLIENTE { get; private set; }
    }
}
