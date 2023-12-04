using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dominio.Interfaces
{
    public interface IEnderecoRepository
    {
        Task<Endereco> BuscarPorId(int id);
        Task InserirEndereco(Endereco endereco);
        Task AtualizarEndereco(Endereco endereco);
        Task ExcluirEndereco(Endereco endereco);
    }
}
