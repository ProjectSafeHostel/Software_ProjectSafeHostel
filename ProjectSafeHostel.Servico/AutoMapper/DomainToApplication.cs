using AutoMapper;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Dominio.ValueObject;
using ProjectSafeHostel.Servico.ViewModels;
using ProjectSafeHostel.Servico.ViewModels.Entities.Cliente;
using ProjectSafeHostel.Servico.ViewModels.Entities.Colaborador;
using ProjectSafeHostel.Servico.ViewModels.Entities.Doador;
using ProjectSafeHostel.Servico.ViewModels.Entities.Endereco;
using ProjectSafeHostel.Servico.ViewModels.Entities.Produto;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoCategoria;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoFamilia;
using ProjectSafeHostel.Servico.ViewModels.ValueObject.Doacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.AutoMapper
{
    public class DomainToApplication : Profile
    {
        public DomainToApplication()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Colaborador, ColaboradorViewModel>();
            CreateMap<Doacao, DoacaoViewModel>();
            CreateMap<Doador, DoadorViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<ProdutoCategoria, ProdutoCategoriaViewModel>();
            CreateMap<ProdutoFamilia, ProdutoFamiliaViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}
