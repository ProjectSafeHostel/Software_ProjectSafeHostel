﻿using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Interfaces
{
    public interface IDoadorRepository
    {
        IEnumerable<object> BuscarTodos();
        Task<Doador> BuscarPorCpf(string cpf);
        Task<Doador> BuscarPorCnpj(string cnpj);
        Task<Doador> BuscarPorId(int id);
        Task InserirDoador(Doador doador);
        Task AtualizarDoador(Doador doador);
        Task ExcluirDoador(Doador doador);
    }
}
