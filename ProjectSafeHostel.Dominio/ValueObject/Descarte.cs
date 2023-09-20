﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.ValueObject
{
    internal class Descarte
    {
        public int DESCARTE_ID { get; private set; }
        public int PRODUTO_ID { get; private set; }
        public string MOTIVO_DESCARTE { get; private set; }
        public int FUNCIONARIO_ID { get; private set; }
    }
}
