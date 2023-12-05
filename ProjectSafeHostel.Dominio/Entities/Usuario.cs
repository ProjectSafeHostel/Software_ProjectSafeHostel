﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Entities
{
    public class Usuario
    {
        #region construtor

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        #endregion

        #region Propiedades

        public string Login { get; private set; }
        public string Senha { get; private set; }

        #endregion
    }
}
