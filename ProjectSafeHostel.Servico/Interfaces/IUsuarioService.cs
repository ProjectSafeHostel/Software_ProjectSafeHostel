using ProjectSafeHostel.Servico.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.Interfaces
{
    public interface IUsuarioService
    {
        public Task<bool> Autenticar(NovoUsuarioViewModel usuario);
        public Task Cadastrar(NovoUsuarioViewModel usuario);
    }
}
